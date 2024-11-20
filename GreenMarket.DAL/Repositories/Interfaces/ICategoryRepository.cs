using GreenMarket.DAL.Entities;

namespace GreenMarket.DAL.Repositories.Interfaces;

public interface ICategoryRepository : IRepository<CategoryEntity>
{
    public IEnumerable<CategoryEntity> GetMain();
    public IEnumerable<CategoryEntity> GetAllPending();
    public IEnumerable<CategoryEntity> GetByParentId(Guid id);
}