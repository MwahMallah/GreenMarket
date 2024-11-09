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

    public IEnumerable<CategoryEntity> GetAllWithProducts()
    {
        return _dbContext.Categories
            .Include(c => c.Products);
    }

    public IEnumerable<CategoryEntity> GetMain()
    {
        return _dbContext.Categories
            .Include(c => c.Products);
    }
}