using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL;

public class GreenMarketDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }

    public GreenMarketDbContext(DbContextOptions<GreenMarketDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>().HasData([
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Maksim"
            },
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Anton"
            },
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Nastya"
            }
        ]);
    }
}