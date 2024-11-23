using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;

namespace GreenMarket.DAL.Repositories;

public class AttributeRepository : RepositoryBase<AttributeEntity>, IAttributeRepository
{
    public AttributeRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
    }
}