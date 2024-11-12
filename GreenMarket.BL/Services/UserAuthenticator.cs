using GreenMarket.BL.Services.Interfaces;
using GreenMarket.DAL.Entities;

namespace GreenMarket.BL.Services;

public class UserAuthenticator : IUserAuthenticator
{
    public bool Verify(UserEntity user, string password)
    {
        return user.Password == password;
    }
}