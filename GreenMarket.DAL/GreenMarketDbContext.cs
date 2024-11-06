using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
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
                Name = "admin",
                Password = "admin",
                Username = "admin",
                Role = UserRole.Admin
            },
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Maksim",
                Password = "123",
                Username = "MaksimDubr",
                Role = UserRole.User
            },
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Anton",
                Password = "123456",
                Username = "AntonHavl",
                Role = UserRole.User
            },
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Nastya",
                Password = "1234",
                Username = "NastyaMiro",
                Role = UserRole.User
            }
        ]);
    }
}