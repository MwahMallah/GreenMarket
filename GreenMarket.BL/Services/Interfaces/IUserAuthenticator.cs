using GreenMarket.DAL.Entities;

namespace GreenMarket.BL.Services.Interfaces;

public interface IUserAuthenticator
{
    public bool Verify(UserEntity user, string password);
}