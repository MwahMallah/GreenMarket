using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL.Repositories;

public class OrderRepository : RepositoryBase<OrderEntity>, IOrderRepository
{
    private readonly GreenMarketDbContext _dbContext;

    public OrderRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override OrderEntity? GetById(Guid? id)
    {
        return _dbContext.Orders
            .Include(o => o.User)
            .Include(o => o.Product)
            .FirstOrDefault(o => o.Id == id);
    }

    public IEnumerable<OrderEntity> GetAllActiveByCreator(Guid creatorId)
    {
        return _dbContext.Orders
            .Include(o => o.User)
            .Include(o => o.Product)
            .Where(o => o.Status == OrderStatus.Active
                        && o.Product.CreatorId == creatorId);
    }
    
    public IEnumerable<OrderEntity> GetAllDeliveredByCreator(Guid creatorId)
    {
        return _dbContext.Orders
            .Include(o => o.User)
            .Include(o => o.Product)
            .Where(o => o.Status == OrderStatus.Delivered 
                        && o.Product.CreatorId == creatorId);
    }
}