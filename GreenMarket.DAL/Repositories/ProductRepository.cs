using GreenMarket.DAL.Entities;
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

    public IEnumerable<ProductEntity> GetByCategoryId(Guid categoryId)
    {
        return _dbContext.Products
            .Where(p => p.CategoryId == categoryId)
            .Include(p => p.Attributes)
            .ThenInclude(pa => pa.Attribute);
    }
}