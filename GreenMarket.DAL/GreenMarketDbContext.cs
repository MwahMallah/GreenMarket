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
                ImgUrl = "",
                Password = "admin",
                Username = "admin",
                Role = UserRole.Admin
            },
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Maksim",
                ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                Password = "123",
                Username = "MaksimDubr",
                Role = UserRole.User
            },
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Anton",
                ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                Password = "123456",
                Username = "AntonHavl",
                Role = UserRole.User
            },
            new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = "Nastya",
                ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                Password = "1234",
                Username = "NastyaMiro",
                Role = UserRole.User
            }
        ]);
    }
}