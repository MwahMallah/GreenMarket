using GreenMarket.BL.Services;
using GreenMarket.BL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GreenMarket.BL.Installers;

public static class GreenMarketBlInstaller
{
    public static void InstallBl(this IServiceCollection service)
    {
        service.AddScoped<IUserAuthenticator, UserAuthenticator>();
        service.AddScoped<IJwtProvider, JwtProvider>();
    }
}