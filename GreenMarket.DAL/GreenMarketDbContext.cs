﻿using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL;

public class GreenMarketDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; } = null!;
    public DbSet<CategoryEntity> Categories { get; set; } = null!;
    public DbSet<ProductEntity> Products { get; set; } = null!;
    public DbSet<AttributeEntity> Attributes { get; set; } = null!;
    public DbSet<ProductAttributeEntity> ProductAttribute { get; set; } = null!;
    public DbSet<OrderEntity> Orders { get; set; } = null!;
    public DbSet<HarvestEntity> Harvests { get; set; } = null!;

    private readonly Guid _adminId = Guid.NewGuid(); 
    private readonly Guid _maksimId = Guid.NewGuid(); 
    private readonly Guid _antonId = Guid.NewGuid(); 
    private readonly Guid _nastyaId = Guid.NewGuid(); 
    private readonly Guid _ilyaId = Guid.NewGuid(); 
    
    private readonly Guid _cropCategoryId = Guid.NewGuid();
    private readonly Guid _vegetableCategoryId = Guid.NewGuid();
    private readonly Guid _fruitCategoryId = Guid.NewGuid();
        
    private readonly Guid _tomatoCategoryId = Guid.NewGuid();
    private readonly Guid _watermelonCategoryId = Guid.NewGuid();
    private readonly Guid _avocadoCategoryId = Guid.NewGuid();
    private readonly Guid _potatoCategoryId = Guid.NewGuid();
    
    private readonly Guid _tominoCategoryId = Guid.NewGuid();
    private readonly Guid _romaCategoryId = Guid.NewGuid();
    
    private readonly Guid _orangeSweetPotatoProductId = Guid.NewGuid();
    private readonly Guid _russetPotatoProductId = Guid.NewGuid();
    
    private readonly Guid _fuerteAvocadoProductId = Guid.NewGuid();
    private readonly Guid _gwenAvocadoProductId = Guid.NewGuid();
    
    public GreenMarketDbContext(DbContextOptions<GreenMarketDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProductAttributeEntity>()
            .HasOne(pa => pa.Product)
            .WithMany(p => p.Attributes)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<ProductAttributeEntity>()
            .HasOne(pa => pa.Attribute)
            .WithMany(p => p.Products)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<OrderEntity>()
            .HasOne(uo => uo.Product)
            .WithMany(p => p.Orders)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<OrderEntity>()
            .HasOne(uo => uo.User)
            .WithMany(u => u.Orders)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<HarvestEntity>()
            .HasMany(h => h.Participants)
            .WithMany(u => u.Harvests)
            .UsingEntity(
                "UserHarvest", // Name of junction table
                j => j
                    .HasOne(typeof(UserEntity),"User")
                    .WithMany()
                    .HasForeignKey("UserId") // Foreign Key for users
                    .OnDelete(DeleteBehavior.Restrict), // Delete behaviour
                j => j
                    .HasOne(typeof(HarvestEntity), "Harvest")
                    .WithMany()
                    .HasForeignKey("HarvestId") // Foreign Key for harvests
                    .OnDelete(DeleteBehavior.Restrict)  // Delete behaviour
            );

        
        SeedUsers(modelBuilder);
        SeedProductsAndCategories(modelBuilder);
        SeedAttributes(modelBuilder);
    }

    private void SeedAttributes(ModelBuilder modelBuilder)
    {
        var priceKgAttributeId = Guid.NewGuid();
        var pricePieceAttributeId = Guid.NewGuid();
        var placeOfOriginAttributeIe = Guid.NewGuid();
        
        modelBuilder.Entity<AttributeEntity>().HasData([
            new AttributeEntity
            {
                Id = priceKgAttributeId,
                Name = "Price/kg",
                CategoryId = _potatoCategoryId
            }, 
            new AttributeEntity
            {
                Id = pricePieceAttributeId,
                Name = "Price/piece",
                CategoryId = _avocadoCategoryId
            },
            new AttributeEntity
            {
                Id = placeOfOriginAttributeIe,
                Name = "Place of origin",
                CategoryId = _avocadoCategoryId
            }
        ]);

        modelBuilder.Entity<ProductAttributeEntity>().HasData([
            new ProductAttributeEntity
            {
                Id = Guid.NewGuid(),
                Value = "25",
                ProductId = _fuerteAvocadoProductId,
                AttributeId = pricePieceAttributeId,
            },
            new ProductAttributeEntity
            {
                Id = Guid.NewGuid(),
                Value = "35",
                ProductId = _gwenAvocadoProductId,
                AttributeId = pricePieceAttributeId,
            },
            new ProductAttributeEntity
            {
                Id = Guid.NewGuid(),
                Value = "100",
                AttributeId = priceKgAttributeId,
                ProductId = _russetPotatoProductId 
            },
            new ProductAttributeEntity
            {
                Id = Guid.NewGuid(),
                Value = "80",
                AttributeId = priceKgAttributeId,
                ProductId = _orangeSweetPotatoProductId 
            },
            new ProductAttributeEntity
            {
                Id = Guid.NewGuid(),
                Value = "Czechia",
                AttributeId = placeOfOriginAttributeIe,
                ProductId = _fuerteAvocadoProductId 
            },
            new ProductAttributeEntity
            {
                Id = Guid.NewGuid(),
                Value = "Puerto Rico",
                AttributeId = placeOfOriginAttributeIe,
                ProductId = _gwenAvocadoProductId 
            }
        ]);
    }

    private void SeedProductsAndCategories(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryEntity>().HasData([
            new CategoryEntity
            {
                Id = _cropCategoryId,
                Name = "Crops",
            },
            new CategoryEntity
            {
                Id = _fruitCategoryId,
                Name = "Fruits",
                ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                ParentId = _cropCategoryId
            },
            new CategoryEntity
            {
                Id = _vegetableCategoryId,
                Name = "Vegetables",
                ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                ParentId = _cropCategoryId
            },
            new CategoryEntity
            {
                Id = _tomatoCategoryId,
                Name = "Tomato",
                ParentId = _vegetableCategoryId,
                ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s"
            },
            new CategoryEntity()
            {
                Id = _tominoCategoryId,
                Name = "Tomino",
                ImgUrl = "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg",
                ParentId = _tomatoCategoryId,
            },
            new CategoryEntity()
            {
                Id = _romaCategoryId,
                Name = "Roma",
                ImgUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz",
                ParentId = _tomatoCategoryId,
            },
            new CategoryEntity
            {
                Id = _potatoCategoryId,
                Name = "Potato",
                ParentId = _vegetableCategoryId,
                ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg"
            },
            new CategoryEntity
            {
                Id = _watermelonCategoryId,
                Name = "Watermelon",
                ParentId = _fruitCategoryId,
                ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg"
            },
            new CategoryEntity
            {
                Id = _avocadoCategoryId,
                Name = "Avocado",
                ParentId = _fruitCategoryId,
                ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s"
            }
        ]);
        
        modelBuilder.Entity<ProductEntity>().HasData([
            new ProductEntity
            {
                Id = _orangeSweetPotatoProductId,
                Name = "Orange sweet",
                ImgUrl = "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg",
                CategoryId = _potatoCategoryId,
                CreatorId = _maksimId,
                Stock = 3
            },
            new ProductEntity
            {
                Id = _russetPotatoProductId,
                Name = "Russet",
                ImgUrl = "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter",
                CategoryId = _potatoCategoryId,
                CreatorId = _maksimId,
                Stock = 4 
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Anton's tasty tomino",
                Description = "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.",
                CategoryId = _tominoCategoryId,
                CreatorId = _antonId,
                Stock = 5
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Ilya's sweet tomino",
                Description = "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!",
                CategoryId = _tominoCategoryId,
                CreatorId = _ilyaId,
                Stock = 1
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Augusta",
                CategoryId = _watermelonCategoryId,
                CreatorId = _antonId,
                Stock = 2
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Dragon King",
                CategoryId = _watermelonCategoryId,
                CreatorId = _antonId,
                Stock = 3
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Happy family",
                CategoryId = _watermelonCategoryId,
                CreatorId = _antonId,
                Stock = 10
            },
            new ProductEntity
            {
                Id = _fuerteAvocadoProductId,
                Name = "Fuerte",
                Description = "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.",
                ImgUrl = "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg",
                CategoryId = _avocadoCategoryId,
                CreatorId = _maksimId,
                Stock = 11
            },
            new ProductEntity
            {
                Id = _gwenAvocadoProductId,
                Name = "Gwen",
                Description = "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.",
                ImgUrl = "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png",
                CategoryId = _avocadoCategoryId,
                CreatorId = _nastyaId,
                Stock = 5
            }
        ]);
    }


    private void SeedUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasData([
            new UserEntity
            {
                Id = _adminId,
                Name = "admin",
                ImgUrl = "",
                Password = "admin",
                Username = "admin",
                Role = UserRole.Admin,
                Email = "admin@admin.com"
            },
            new UserEntity
            {
                Id = _maksimId,
                Name = "Maksim",
                ImgUrl =
                    "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                Password = "123",
                Username = "MaksimDubr",
                Role = UserRole.User,
                Email = "maksim@mail.com"
            },
            new UserEntity
            {
                Id = _antonId,
                Name = "Anton",
                ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                Password = "123456",
                Username = "AntonHavl",
                Role = UserRole.User,
                Email = "anton@mail.com"
            },
            new UserEntity
            {
                Id = _nastyaId,
                Name = "Nastya",
                ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                Password = "1234",
                Username = "NastyaMiro",
                Role = UserRole.User,
                Email = "nastya@mail.com"
            },
            new UserEntity
            {
                Id = _ilyaId,
                Name = "Ilya",
                ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                Password = "123456",
                Username = "IlyaVeryBad",
                Role = UserRole.User,
                Email = "ilya@mail.com"
            }
        ]);
    }
}