using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL.Repositories;

public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
{
    private readonly GreenMarketDbContext _dbContext;

    public UserRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override UserEntity? GetById(Guid? id)
    {
        return _dbContext.Users
            .Include(u => u.Orders)
                .ThenInclude(o => o.Product)
            .FirstOrDefault(u => u.Id == id);
    }
    
    public UserEntity? GetByIdWithCreatedProducts(Guid id)
    {
        return _dbContext.Users
            .Include(u => u.CreatedProducts)
                .ThenInclude(p => p.Attributes)
            .Include(u => u.CreatedProducts)
                .ThenInclude(p => p.Customers)
            .FirstOrDefault(u => u.Id == id);
    }

    public UserEntity? GetByUsername(string username)
    {
        return _dbContext.Users.FirstOrDefault(u => u.Username == username);
    }

    public UserEntity? GetByEmail(string email)
    {
        return _dbContext.Users.FirstOrDefault(u => u.Email == email);
    }
}