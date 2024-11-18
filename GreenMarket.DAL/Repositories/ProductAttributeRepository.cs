using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;

namespace GreenMarket.DAL.Repositories;

public class ProductAttributeRepository
    : RepositoryBase<ProductAttributeEntity>, IProductAttributeRepository
{
    public ProductAttributeRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
    }
}