using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
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

    public override CategoryEntity Create(CategoryEntity entity)
    {
        foreach (var attr in entity.Attributes)
        {
            _dbContext.Attributes.Add(attr);
        }
        
        var addedEntity = _dbContext.Categories.Add(entity).Entity;
        _dbContext.SaveChanges();
        return addedEntity;
    }
    
    public override CategoryEntity? GetById(Guid? id)
    {
        return _dbContext.Categories
            .Include(c => c.Attributes)
            .Include(c => c.Products)
            .FirstOrDefault(c => c.Id == id);
    }
    
    public override IEnumerable<CategoryEntity> GetAll()
    {
        return _dbContext.Categories
            .Include(c => c.Parent)
            .Include(c => c.Attributes)
            .Where(c => c.Status == CategoryStatus.Accepted);
    }

    public IEnumerable<CategoryEntity> GetAllPending()
    {
        return _dbContext.Categories
            .Include(c => c.Attributes)
            .Where(c => c.Status == CategoryStatus.Pending);
    }
    
    public IEnumerable<CategoryEntity> GetMain()
    {
        var root = _dbContext.Categories.FirstOrDefault(c => c.ParentId == null);
        return _dbContext.Categories
            .Where(c => c.ParentId == root!.Id 
                        && c.Status == CategoryStatus.Accepted)
            .Include(c => c.Products)
            .Include(c => c.SubCategories);
    }

    public IEnumerable<CategoryEntity> GetByParentId(Guid id)
    {
        return _dbContext.Categories
            .Where(c => c.ParentId == id
                        && c.Status == CategoryStatus.Accepted)
            .Include(c => c.Products)
            .Include(c => c.SubCategories);
    }

    public override void Update(CategoryEntity updatedEntity)
    {
        foreach (var attr in updatedEntity.Attributes)
        {
            _dbContext.Attributes.Update(attr);
        }

        _dbContext.Categories.Update(updatedEntity);
        _dbContext.SaveChanges();
    }

    public override void Delete(CategoryEntity entity)
    {
        foreach (var product in entity.Products)
        {
            MarkDeleteProductAttributes(product);
            MarkDeleteProductOrders(product);
            _dbContext.Products.Remove(product);
        }

        _dbContext.Attributes.RemoveRange(entity.Attributes);

        _dbContext.Categories.Remove(entity);
        _dbContext.SaveChanges();
    }

    private void MarkDeleteProductOrders(ProductEntity product)
    {
        var orders = _dbContext.Orders
            .Where(o => o.ProductId == product.Id);

        _dbContext.Orders.RemoveRange(orders);
    }
    
    private void MarkDeleteProductAttributes(ProductEntity product)
    {
        var attributes = _dbContext.ProductAttribute
            .Where(a => a.ProductId == product.Id);

        _dbContext.ProductAttribute.RemoveRange(attributes);
    }
}