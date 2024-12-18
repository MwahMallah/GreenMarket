﻿using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL.Repositories;

public class CategoryRepository : RepositoryBase<CategoryEntity>, ICategoryRepository
{
    private readonly GreenMarketDbContext _dbContext;

    public CategoryRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<CategoryEntity> GetMain()
    {
        var root = _dbContext.Categories.FirstOrDefault(c => c.ParentId == null);
        return _dbContext.Categories
            .Where(c => c.ParentId == root!.Id)
            .Include(c => c.Products)
            .Include(c => c.SubCategories);
    }

    public IEnumerable<CategoryEntity> GetByParentId(Guid id)
    {
        return _dbContext.Categories
            .Where(c => c.ParentId == id)
            .Include(c => c.Products)
            .Include(c => c.SubCategories);
    }
}