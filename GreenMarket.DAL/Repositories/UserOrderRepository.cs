using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;

namespace GreenMarket.DAL.Repositories;

public class UserOrderRepository : RepositoryBase<UserOrderEntity>, IUserOrderRepository
{
    public UserOrderRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
    }
}