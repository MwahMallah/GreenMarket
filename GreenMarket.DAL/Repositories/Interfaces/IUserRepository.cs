using GreenMarket.DAL.Entities;

namespace GreenMarket.DAL.Repositories.Interfaces;

public interface IUserRepository : IRepository<UserEntity>
{
    public UserEntity? GetByUsername(string username);
}