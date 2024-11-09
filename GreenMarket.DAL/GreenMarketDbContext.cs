using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL;

public class GreenMarketDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<AttributeEntity> Attributes { get; set; }
    public DbSet<ProductAttributeEntity> ProductAttribute { get; set; }
    
    private readonly Guid _vegetableCategoryId = Guid.NewGuid();
    private readonly Guid _fruitCategoryId = Guid.NewGuid();
        
    private readonly Guid _tomatoCategoryId = Guid.NewGuid();
    private readonly Guid _watermelonCategoryId = Guid.NewGuid();
    private readonly Guid _avocadoCategoryId = Guid.NewGuid();
    private readonly Guid _potatoCategoryId = Guid.NewGuid();
    
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
                Id = _fruitCategoryId,
                Name = "Fruits",
                ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4"
            },
            new CategoryEntity
            {
                Id = _vegetableCategoryId,
                Name = "Vegetables",
                ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg"
            },
            new CategoryEntity
            {
                Id = _tomatoCategoryId,
                Name = "Tomato",
                ParentId = _vegetableCategoryId,
                ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s"
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
            },
            new ProductEntity
            {
                Id = _russetPotatoProductId,
                Name = "Russet",
                ImgUrl = "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter",
                CategoryId = _potatoCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Tomino",
                CategoryId = _tomatoCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Roma",
                CategoryId = _tomatoCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Augusta",
                CategoryId = _watermelonCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Dragon King",
                CategoryId = _watermelonCategoryId,
            },
            new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = "Happy family",
                CategoryId = _watermelonCategoryId,
            },
            new ProductEntity
            {
                Id = _fuerteAvocadoProductId,
                Name = "Fuerte",
                ImgUrl = "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg",
                CategoryId = _avocadoCategoryId,
            },
            new ProductEntity
            {
                Id = _gwenAvocadoProductId,
                Name = "Gwen",
                ImgUrl = "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png",
                CategoryId = _avocadoCategoryId,
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