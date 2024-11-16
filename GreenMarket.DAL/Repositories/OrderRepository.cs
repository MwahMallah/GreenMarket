using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;

namespace GreenMarket.DAL.Repositories;

public class OrderRepository : RepositoryBase<OrderEntity>, IOrderRepository
{
    public OrderRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
    }
}