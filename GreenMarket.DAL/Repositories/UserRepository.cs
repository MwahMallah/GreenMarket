using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;

namespace GreenMarket.DAL.Repositories;

public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
{
    private readonly GreenMarketDbContext _dbContext;

    public UserRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public UserEntity? GetByUsername(string username)
    {
        return _dbContext.Users.FirstOrDefault(u => u.Username == username);
    }
}