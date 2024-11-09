using GreenMarket.DAL.Entities;

namespace GreenMarket.DAL.Repositories.Interfaces;

public interface ICategoryRepository : IRepository<CategoryEntity>
{
    public IEnumerable<CategoryEntity> GetAllWithProducts();
    public IEnumerable<CategoryEntity> GetMain();
}