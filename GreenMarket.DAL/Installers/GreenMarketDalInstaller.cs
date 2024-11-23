using GreenMarket.DAL.Repositories;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GreenMarket.DAL.Installers;

public static class GreenMarketDalInstaller
{
    public static void InstallDal(this IServiceCollection service)
    {
        service.AddScoped<IUserRepository, UserRepository>();
        service.AddScoped<ICategoryRepository, CategoryRepository>();
        service.AddScoped<IProductRepository, ProductRepository>();
        service.AddScoped<IOrderRepository, OrderRepository>();
        service.AddScoped<IProductAttributeRepository, ProductAttributeRepository>();
        service.AddScoped<IHarvestRepository, HarvestRepository>();
    }
}