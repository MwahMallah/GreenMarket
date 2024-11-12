using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL;

public class GreenMarketDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ProductEntity> Products { get; set; }

    public GreenMarketDbContext(DbContextOptions<GreenMarketDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SeedUsers(modelBuilder);
        SeedProductsAndCategories(modelBuilder);
    }

    private void SeedProductsAndCategories(ModelBuilder modelBuilder)
    {
        var vegetableCategoryId = Guid.NewGuid();
        var fruitCategoryId = Guid.NewGuid();
        
        var tomatoCategoryId = Guid.NewGuid();
        var watermelonCategoryId = Guid.NewGuid();
        var potatoCategoryId = Guid.NewGuid();
        
        modelBuilder.Entity<CategoryEntity>().HasData([
            new CategoryEntity
            {
                Id = fruitCategoryId,
                Name = "Fruits",
                ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4"
            },
            new CategoryEntity
            {
                Id = vegetableCategoryId,
                Name = "Vegetables",
                ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg"
            },
            new CategoryEntity
            {
                Id = tomatoCategoryId,
                Name = "Tomato",
                ParentId = vegetableCategoryId,
                ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s"
            },
            new CategoryEntity
            {
                Id = potatoCategoryId,
                Name = "Potato",
                ParentId = vegetableCategoryId,
                ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg"
            },
            new CategoryEntity
            {
                Id = watermelonCategoryId,
                Name = "Watermelon",
                ParentId = fruitCategoryId,
                ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg"
            }
        ]);
        
        modelBuilder.Entity<ProductEntity>().HasData([
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Tomino",
                CategoryId = tomatoCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Roma",
                CategoryId = tomatoCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Augusta",
                CategoryId = watermelonCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Dragon King",
                CategoryId = watermelonCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Happy family",
                CategoryId = watermelonCategoryId,
            }
        ]);
    }


    private void SeedUsers(ModelBuilder modelBuilder)
    {
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