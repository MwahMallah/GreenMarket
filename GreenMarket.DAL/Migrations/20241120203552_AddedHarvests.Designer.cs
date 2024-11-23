﻿// <auto-generated />
using System;
using GreenMarket.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenMarket.DAL.Migrations
{
    [DbContext(typeof(GreenMarketDbContext))]
    [Migration("20241120203552_AddedHarvests")]
    partial class AddedHarvests
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("5cdc1abf-9959-417a-b919-ee822ac7f733"),
                            CategoryId = new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"),
                            Name = "Price/kg"
                        },
                        new
                        {
                            Id = new Guid("588d5923-dab1-487c-a47d-055755d4bf6e"),
                            CategoryId = new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"),
                            Name = "Price/piece"
                        },
                        new
                        {
                            Id = new Guid("6d555d85-7dcf-49e4-a327-7e791a8b602e"),
                            CategoryId = new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"),
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
                            Id = new Guid("5bfa193f-6d88-40e3-94a5-c2dbfaa3fc5c"),
                            Name = "Crops",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("1e117874-e224-4480-8544-2564af267c9b"),
                            ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                            Name = "Fruits",
                            ParentId = new Guid("5bfa193f-6d88-40e3-94a5-c2dbfaa3fc5c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("c8dc4410-09e9-4f15-9fe2-745e2b63ccd6"),
                            ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                            Name = "Vegetables",
                            ParentId = new Guid("5bfa193f-6d88-40e3-94a5-c2dbfaa3fc5c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("cc73dc8d-4a9e-4119-8efd-5d22bcfa38da"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s",
                            Name = "Tomato",
                            ParentId = new Guid("c8dc4410-09e9-4f15-9fe2-745e2b63ccd6"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("f10a0c86-7252-4661-a528-a44b8119f17e"),
                            ImgUrl = "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg",
                            Name = "Tomino",
                            ParentId = new Guid("cc73dc8d-4a9e-4119-8efd-5d22bcfa38da"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("be047289-f129-4e01-8f34-2c658a98b5ce"),
                            ImgUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz",
                            Name = "Roma",
                            ParentId = new Guid("cc73dc8d-4a9e-4119-8efd-5d22bcfa38da"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"),
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg",
                            Name = "Potato",
                            ParentId = new Guid("c8dc4410-09e9-4f15-9fe2-745e2b63ccd6"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"),
                            ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg",
                            Name = "Watermelon",
                            ParentId = new Guid("1e117874-e224-4480-8544-2564af267c9b"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s",
                            Name = "Avocado",
                            ParentId = new Guid("1e117874-e224-4480-8544-2564af267c9b"),
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
                            Id = new Guid("a7a489f9-1f2d-49b2-9e6b-e2b13c99d48d"),
                            AttributeId = new Guid("588d5923-dab1-487c-a47d-055755d4bf6e"),
                            ProductId = new Guid("b270fb5d-c1af-4074-b16f-08e8e0603362"),
                            Value = "25"
                        },
                        new
                        {
                            Id = new Guid("ba6195af-f6ae-4887-8d9d-8995eb2927f9"),
                            AttributeId = new Guid("588d5923-dab1-487c-a47d-055755d4bf6e"),
                            ProductId = new Guid("1fb243be-a6d9-46d4-ab60-edab6f858021"),
                            Value = "35"
                        },
                        new
                        {
                            Id = new Guid("be212faf-6a8f-49cd-9e67-cc519ae7c09c"),
                            AttributeId = new Guid("5cdc1abf-9959-417a-b919-ee822ac7f733"),
                            ProductId = new Guid("9f322e5a-2c60-4087-ac97-cf7d73f39b23"),
                            Value = "100"
                        },
                        new
                        {
                            Id = new Guid("219a0ec9-15ca-43a8-b923-581ae8d5633e"),
                            AttributeId = new Guid("5cdc1abf-9959-417a-b919-ee822ac7f733"),
                            ProductId = new Guid("1a81e1d4-d2b3-4d54-b0d2-5c984446e7ab"),
                            Value = "80"
                        },
                        new
                        {
                            Id = new Guid("5d61e0a3-1a7c-4c6a-9850-c770c508661a"),
                            AttributeId = new Guid("6d555d85-7dcf-49e4-a327-7e791a8b602e"),
                            ProductId = new Guid("b270fb5d-c1af-4074-b16f-08e8e0603362"),
                            Value = "Czechia"
                        },
                        new
                        {
                            Id = new Guid("a350ee68-ecbe-4774-a96a-e299ca6d0f9b"),
                            AttributeId = new Guid("6d555d85-7dcf-49e4-a327-7e791a8b602e"),
                            ProductId = new Guid("1fb243be-a6d9-46d4-ab60-edab6f858021"),
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

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a81e1d4-d2b3-4d54-b0d2-5c984446e7ab"),
                            CategoryId = new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"),
                            CreatorId = new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"),
                            ImgUrl = "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg",
                            Name = "Orange sweet",
                            Stock = 3
                        },
                        new
                        {
                            Id = new Guid("9f322e5a-2c60-4087-ac97-cf7d73f39b23"),
                            CategoryId = new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"),
                            CreatorId = new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"),
                            ImgUrl = "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter",
                            Name = "Russet",
                            Stock = 4
                        },
                        new
                        {
                            Id = new Guid("1af8a77e-79b2-4a8c-9893-17fdb81f25f3"),
                            CategoryId = new Guid("f10a0c86-7252-4661-a528-a44b8119f17e"),
                            CreatorId = new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"),
                            Description = "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.",
                            Name = "Anton's tasty tomino",
                            Stock = 5
                        },
                        new
                        {
                            Id = new Guid("38ca5a00-7f3f-47d7-9c13-535bdc3d0330"),
                            CategoryId = new Guid("f10a0c86-7252-4661-a528-a44b8119f17e"),
                            CreatorId = new Guid("576491e6-94bb-42f9-92e3-77b5fc4fc8fd"),
                            Description = "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!",
                            Name = "Ilya's sweet tomino",
                            Stock = 1
                        },
                        new
                        {
                            Id = new Guid("12f6a90f-31b2-4127-af1f-3e399a055db0"),
                            CategoryId = new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"),
                            CreatorId = new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"),
                            Name = "Augusta",
                            Stock = 2
                        },
                        new
                        {
                            Id = new Guid("8465bffd-5a40-4d71-8b73-5f95561d6010"),
                            CategoryId = new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"),
                            CreatorId = new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"),
                            Name = "Dragon King",
                            Stock = 3
                        },
                        new
                        {
                            Id = new Guid("4ce5bbb5-292a-4ffc-8337-232858b1193e"),
                            CategoryId = new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"),
                            CreatorId = new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"),
                            Name = "Happy family",
                            Stock = 10
                        },
                        new
                        {
                            Id = new Guid("b270fb5d-c1af-4074-b16f-08e8e0603362"),
                            CategoryId = new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"),
                            CreatorId = new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"),
                            Description = "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.",
                            ImgUrl = "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg",
                            Name = "Fuerte",
                            Stock = 11
                        },
                        new
                        {
                            Id = new Guid("1fb243be-a6d9-46d4-ab60-edab6f858021"),
                            CategoryId = new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"),
                            CreatorId = new Guid("b4ab2398-005e-4f21-ad5e-f8ee81187009"),
                            Description = "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.",
                            ImgUrl = "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png",
                            Name = "Gwen",
                            Stock = 5
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
                            Id = new Guid("384bd3bf-ea88-4285-b7b5-fd620d7fa84b"),
                            Email = "admin@admin.com",
                            ImgUrl = "",
                            Name = "admin",
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"),
                            Email = "maksim@mail.com",
                            ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                            Name = "Maksim",
                            Password = "123",
                            Role = 1,
                            Username = "MaksimDubr"
                        },
                        new
                        {
                            Id = new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"),
                            Email = "anton@mail.com",
                            ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                            Name = "Anton",
                            Password = "123456",
                            Role = 1,
                            Username = "AntonHavl"
                        },
                        new
                        {
                            Id = new Guid("b4ab2398-005e-4f21-ad5e-f8ee81187009"),
                            Email = "nastya@mail.com",
                            ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                            Name = "Nastya",
                            Password = "1234",
                            Role = 1,
                            Username = "NastyaMiro"
                        },
                        new
                        {
                            Id = new Guid("576491e6-94bb-42f9-92e3-77b5fc4fc8fd"),
                            Email = "ilya@mail.com",
                            ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                            Name = "Ilya",
                            Password = "123456",
                            Role = 1,
                            Username = "IlyaVeryBad"
                        });
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
                        .WithMany()
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
