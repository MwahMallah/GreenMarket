﻿// <auto-generated />
using System;
using GreenMarket.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenMarket.DAL.Migrations
{
    [DbContext(typeof(GreenMarketDbContext))]
    partial class GreenMarketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenMarket.DAL.Entities.AttributeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Attributes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("32de2d64-595a-4a01-83cc-d51d7b0cb07b"),
                            CategoryId = new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"),
                            Name = "Price/kg"
                        },
                        new
                        {
                            Id = new Guid("586b0156-bb25-49ae-802a-d46a702aaa10"),
                            CategoryId = new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"),
                            Name = "Price/piece"
                        },
                        new
                        {
                            Id = new Guid("3b217371-438f-4270-babb-c733219a9ce7"),
                            CategoryId = new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"),
                            Name = "Place of origin"
                        });
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.CategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e24516b-65dc-4579-960a-7c35b07f8a60"),
                            Name = "Crops",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("7cdf1a1d-6225-405f-bc35-7550b6c26c0d"),
                            ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                            Name = "Fruits",
                            ParentId = new Guid("0e24516b-65dc-4579-960a-7c35b07f8a60"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("0eeff68f-287e-4ab0-b7fd-78daea33d991"),
                            ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                            Name = "Vegetables",
                            ParentId = new Guid("0e24516b-65dc-4579-960a-7c35b07f8a60"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("389e0ab7-12c1-49ab-ab90-30603aa5c0ad"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s",
                            Name = "Tomato",
                            ParentId = new Guid("0eeff68f-287e-4ab0-b7fd-78daea33d991"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("dcf4fe5e-3837-4b9a-a0a3-7e1a89cfa9f9"),
                            ImgUrl = "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg",
                            Name = "Tomino",
                            ParentId = new Guid("389e0ab7-12c1-49ab-ab90-30603aa5c0ad"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("6587d65a-3f4e-4acf-8373-febe3db9b112"),
                            ImgUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz",
                            Name = "Roma",
                            ParentId = new Guid("389e0ab7-12c1-49ab-ab90-30603aa5c0ad"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"),
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg",
                            Name = "Potato",
                            ParentId = new Guid("0eeff68f-287e-4ab0-b7fd-78daea33d991"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("58c13104-1288-47cb-afff-b7419b2130c0"),
                            ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg",
                            Name = "Watermelon",
                            ParentId = new Guid("7cdf1a1d-6225-405f-bc35-7550b6c26c0d"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s",
                            Name = "Avocado",
                            ParentId = new Guid("7cdf1a1d-6225-405f-bc35-7550b6c26c0d"),
                            Status = 0
                        });
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.HarvestEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Harvests");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("Rating")
                        .HasColumnType("real");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.ProductAttributeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AttributeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AttributeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAttribute");

                    b.HasData(
                        new
                        {
                            Id = new Guid("97081f01-db27-4591-99c0-305614ae3167"),
                            AttributeId = new Guid("586b0156-bb25-49ae-802a-d46a702aaa10"),
                            ProductId = new Guid("f6104dd5-5500-4e69-82b2-141d410d4951"),
                            Value = "25"
                        },
                        new
                        {
                            Id = new Guid("60519d34-fb27-47ce-9c6c-ff7fc670a1c1"),
                            AttributeId = new Guid("586b0156-bb25-49ae-802a-d46a702aaa10"),
                            ProductId = new Guid("5be52c42-3370-4b55-bff5-6eb879e126f8"),
                            Value = "35"
                        },
                        new
                        {
                            Id = new Guid("4b8af20d-8e15-4773-98a4-9cbbbc8d1f24"),
                            AttributeId = new Guid("32de2d64-595a-4a01-83cc-d51d7b0cb07b"),
                            ProductId = new Guid("cc49e65c-4ee8-48f4-a874-2a18b60758d6"),
                            Value = "100"
                        },
                        new
                        {
                            Id = new Guid("f0ca3f69-dcf8-411f-b973-d55c57ee91d2"),
                            AttributeId = new Guid("32de2d64-595a-4a01-83cc-d51d7b0cb07b"),
                            ProductId = new Guid("f905e84d-f60e-4d76-9875-865ac02da4f5"),
                            Value = "80"
                        },
                        new
                        {
                            Id = new Guid("f64972ea-2482-4a31-b28d-1e9491706c1b"),
                            AttributeId = new Guid("3b217371-438f-4270-babb-c733219a9ce7"),
                            ProductId = new Guid("f6104dd5-5500-4e69-82b2-141d410d4951"),
                            Value = "Czechia"
                        },
                        new
                        {
                            Id = new Guid("42dcfd43-e9e1-481c-bbee-507f7d3c4625"),
                            AttributeId = new Guid("3b217371-438f-4270-babb-c733219a9ce7"),
                            ProductId = new Guid("5be52c42-3370-4b55-bff5-6eb879e126f8"),
                            Value = "Puerto Rico"
                        });
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f905e84d-f60e-4d76-9875-865ac02da4f5"),
                            CategoryId = new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"),
                            CreatorId = new Guid("2801e25e-1851-4a67-91b4-b79764768c93"),
                            ImgUrl = "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg",
                            Name = "Orange sweet",
                            Stock = 3,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("cc49e65c-4ee8-48f4-a874-2a18b60758d6"),
                            CategoryId = new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"),
                            CreatorId = new Guid("2801e25e-1851-4a67-91b4-b79764768c93"),
                            ImgUrl = "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter",
                            Name = "Russet",
                            Stock = 4,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("9909bfd9-bcc4-4e5d-bca6-bbe27467df33"),
                            CategoryId = new Guid("dcf4fe5e-3837-4b9a-a0a3-7e1a89cfa9f9"),
                            CreatorId = new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"),
                            Description = "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.",
                            Name = "Anton's tasty tomino",
                            Stock = 5,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("f843683c-18fc-4a45-8787-91e8f9e50ca6"),
                            CategoryId = new Guid("dcf4fe5e-3837-4b9a-a0a3-7e1a89cfa9f9"),
                            CreatorId = new Guid("7443f593-e895-44f6-b8b0-08faf7710e6b"),
                            Description = "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!",
                            Name = "Ilya's sweet tomino",
                            Stock = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("a0bbe0f5-d840-461b-8919-2aa23878963c"),
                            CategoryId = new Guid("58c13104-1288-47cb-afff-b7419b2130c0"),
                            CreatorId = new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"),
                            Name = "Augusta",
                            Stock = 2,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("285a41a6-59ae-4170-acd3-cccfa7a1b09e"),
                            CategoryId = new Guid("58c13104-1288-47cb-afff-b7419b2130c0"),
                            CreatorId = new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"),
                            Name = "Dragon King",
                            Stock = 3,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("27135dc4-ce49-423f-a650-ae85bd1b4811"),
                            CategoryId = new Guid("58c13104-1288-47cb-afff-b7419b2130c0"),
                            CreatorId = new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"),
                            Name = "Happy family",
                            Stock = 10,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("f6104dd5-5500-4e69-82b2-141d410d4951"),
                            CategoryId = new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"),
                            CreatorId = new Guid("2801e25e-1851-4a67-91b4-b79764768c93"),
                            Description = "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.",
                            ImgUrl = "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg",
                            Name = "Fuerte",
                            Stock = 11,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("5be52c42-3370-4b55-bff5-6eb879e126f8"),
                            CategoryId = new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"),
                            CreatorId = new Guid("473c0b7b-0253-4abf-bc1d-8d539de26a56"),
                            Description = "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.",
                            ImgUrl = "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png",
                            Name = "Gwen",
                            Stock = 5,
                            Type = 0
                        });
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4233b31a-0ccf-41d5-8524-fda1cd59896d"),
                            Email = "admin@admin.com",
                            ImgUrl = "",
                            Name = "admin",
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("2801e25e-1851-4a67-91b4-b79764768c93"),
                            Email = "maksim@mail.com",
                            ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                            Name = "Maksim",
                            Password = "123",
                            Role = 1,
                            Username = "MaksimDubr"
                        },
                        new
                        {
                            Id = new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"),
                            Email = "anton@mail.com",
                            ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                            Name = "Anton",
                            Password = "123456",
                            Role = 1,
                            Username = "AntonHavl"
                        },
                        new
                        {
                            Id = new Guid("473c0b7b-0253-4abf-bc1d-8d539de26a56"),
                            Email = "nastya@mail.com",
                            ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                            Name = "Nastya",
                            Password = "1234",
                            Role = 1,
                            Username = "NastyaMiro"
                        },
                        new
                        {
                            Id = new Guid("7443f593-e895-44f6-b8b0-08faf7710e6b"),
                            Email = "ilya@mail.com",
                            ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                            Name = "Ilya",
                            Password = "123456",
                            Role = 1,
                            Username = "IlyaVeryBad"
                        });
                });

            modelBuilder.Entity("UserHarvest", b =>
                {
                    b.Property<Guid>("HarvestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HarvestId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserHarvest");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.AttributeEntity", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.CategoryEntity", "Category")
                        .WithMany("Attributes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.CategoryEntity", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.CategoryEntity", "Parent")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.HarvestEntity", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.ProductEntity", "Product")
                        .WithMany("Harvests")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.OrderEntity", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.ProductEntity", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GreenMarket.DAL.Entities.UserEntity", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.ProductAttributeEntity", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.AttributeEntity", "Attribute")
                        .WithMany("Products")
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GreenMarket.DAL.Entities.ProductEntity", "Product")
                        .WithMany("Attributes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Attribute");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.ProductEntity", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreenMarket.DAL.Entities.UserEntity", "Creator")
                        .WithMany("CreatedProducts")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("UserHarvest", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.HarvestEntity", "Harvest")
                        .WithMany()
                        .HasForeignKey("HarvestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GreenMarket.DAL.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Harvest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.AttributeEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.ProductEntity", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("Harvests");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.UserEntity", b =>
                {
                    b.Navigation("CreatedProducts");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
