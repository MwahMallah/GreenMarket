using GreenMarket.DAL.Entities.Interfaces;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL.Repositories;

public abstract class RepositoryBase<TEntity> : IRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly GreenMarketDbContext _dbContext;
    private readonly DbSet<TEntity> _entities;

    protected RepositoryBase(GreenMarketDbContext dbContext)
    {
        _dbContext = dbContext;
        _entities = dbContext.Set<TEntity>();
    }
    
    public virtual TEntity? GetById(Guid? id)
    {
        return _entities.FirstOrDefault(e => e.Id == id);
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        return _entities;
    }

    public TEntity Create(TEntity entity)
    {
        var addedEntity = _entities.Add(entity).Entity;
        _dbContext.SaveChanges();
        return addedEntity;
    }

    public virtual void Update(TEntity updatedEntity)
    {
        _entities.Update(updatedEntity);
        _dbContext.SaveChanges();
    }

    public virtual void Delete(TEntity entity)
    {
        _entities.Remove(entity);
        _dbContext.SaveChanges();
    }
}