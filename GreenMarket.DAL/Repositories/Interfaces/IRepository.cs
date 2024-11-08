using GreenMarket.DAL.Entities.Interfaces;

namespace GreenMarket.DAL.Repositories.Interfaces;

public interface IRepository<TEntity>
    where TEntity : class, IEntity
{
    public TEntity? GetById(Guid id);
    public IEnumerable<TEntity> GetAll();
    public TEntity Create(TEntity entity);
    public void Update(TEntity updatedEntity);
    public void Delete(TEntity entityToDelete);
}