using GreenMarket.DAL.Entities;

namespace GreenMarket.BL.Services.Interfaces;

public interface IJwtProvider
{
    public string CreateToken(UserEntity user);
}