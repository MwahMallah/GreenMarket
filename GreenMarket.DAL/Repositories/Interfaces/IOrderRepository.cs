using GreenMarket.DAL.Entities;

namespace GreenMarket.DAL.Repositories.Interfaces;

public interface IOrderRepository : IRepository<OrderEntity>
{
    public IEnumerable<OrderEntity> GetAllActiveByCreator(Guid creatorId);
    public IEnumerable<OrderEntity> GetAllDeliveredByCreator(Guid creatorId);
}