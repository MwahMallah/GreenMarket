using GreenMarket.DAL.Entities;

namespace GreenMarket.DAL.Repositories.Interfaces;

public interface IProductRepository : IRepository<ProductEntity>
{
    public IEnumerable<ProductEntity> GetByCategoryId(Guid categoryId);
}