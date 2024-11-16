﻿using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL.Repositories;

public class ProductRepository : RepositoryBase<ProductEntity>, IProductRepository
{
    private readonly GreenMarketDbContext _dbContext;

    public ProductRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override ProductEntity? GetById(Guid? id)
    {
        return _dbContext.Products
            .Include(p => p.Attributes)
                .ThenInclude(pa => pa.Attribute)
            .Include(p => p.Orders)
                .ThenInclude(c => c.User)
            .FirstOrDefault(p => p.Id == id);
    }

    public IEnumerable<ProductEntity> GetByCategoryId(Guid categoryId)
    {
        return _dbContext.Products
            .Where(p => p.CategoryId == categoryId)
            .Include(p => p.Attributes)
            .ThenInclude(pa => pa.Attribute)
            .Include(p => p.Orders);
    }

    //Deletes all orders and product itself in one db transaction
    public override void Delete(ProductEntity entity)
    {
        foreach (var order in entity.Orders)
        {
            _dbContext.Orders.Remove(order);
        }

        _dbContext.Products.Remove(entity);
        _dbContext.SaveChanges();
    }
}