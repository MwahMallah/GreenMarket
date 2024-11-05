using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL;

public class GreenMarketDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }

    public GreenMarketDbContext(DbContextOptions<GreenMarketDbContext> options)
        : base(options)
    {
    }
}