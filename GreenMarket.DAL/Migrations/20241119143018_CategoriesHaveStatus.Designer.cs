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
    [Migration("20241119143018_CategoriesHaveStatus")]
    partial class CategoriesHaveStatus
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
                            Id = new Guid("b3d2b37e-a50f-4664-9895-0088a868c684"),
                            CategoryId = new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"),
                            Name = "Price/kg"
                        },
                        new
                        {
                            Id = new Guid("7a05b016-a5fc-4960-8949-075962679952"),
                            CategoryId = new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"),
                            Name = "Price/piece"
                        },
                        new
                        {
                            Id = new Guid("f81827c5-0420-4714-bbd9-7d4006aed677"),
                            CategoryId = new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"),
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
                            Id = new Guid("03202b08-ac6b-4079-9a44-ddf83f8d0ba8"),
                            Name = "Crops",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("f2e23539-f5ba-4660-8f15-ccdf912c8b74"),
                            ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                            Name = "Fruits",
                            ParentId = new Guid("03202b08-ac6b-4079-9a44-ddf83f8d0ba8"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("3b100021-8796-4494-9eda-ab8764b315e0"),
                            ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                            Name = "Vegetables",
                            ParentId = new Guid("03202b08-ac6b-4079-9a44-ddf83f8d0ba8"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("b711ee60-c3fc-4206-849d-329ee164a38c"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s",
                            Name = "Tomato",
                            ParentId = new Guid("3b100021-8796-4494-9eda-ab8764b315e0"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("902fcd4f-b276-406b-a2b7-3ab6d70adb17"),
                            ImgUrl = "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg",
                            Name = "Tomino",
                            ParentId = new Guid("b711ee60-c3fc-4206-849d-329ee164a38c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("adb9e92d-3fc7-4040-bf9e-334c6504ac17"),
                            ImgUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz",
                            Name = "Roma",
                            ParentId = new Guid("b711ee60-c3fc-4206-849d-329ee164a38c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"),
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg",
                            Name = "Potato",
                            ParentId = new Guid("3b100021-8796-4494-9eda-ab8764b315e0"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"),
                            ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg",
                            Name = "Watermelon",
                            ParentId = new Guid("f2e23539-f5ba-4660-8f15-ccdf912c8b74"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s",
                            Name = "Avocado",
                            ParentId = new Guid("f2e23539-f5ba-4660-8f15-ccdf912c8b74"),
                            Status = 0
                        });
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
                            Id = new Guid("42e39331-1121-4d25-948f-81e9fe086e88"),
                            AttributeId = new Guid("7a05b016-a5fc-4960-8949-075962679952"),
                            ProductId = new Guid("aee238b2-b977-45a3-908f-d85ce88543d9"),
                            Value = "25"
                        },
                        new
                        {
                            Id = new Guid("b882a508-6600-4f4d-98bc-76d37621d5f4"),
                            AttributeId = new Guid("7a05b016-a5fc-4960-8949-075962679952"),
                            ProductId = new Guid("9c9957cc-1cfb-41f9-9416-2c993aa2af01"),
                            Value = "35"
                        },
                        new
                        {
                            Id = new Guid("a6451b18-1e7a-4a2a-877d-4bd441556479"),
                            AttributeId = new Guid("b3d2b37e-a50f-4664-9895-0088a868c684"),
                            ProductId = new Guid("06e722df-fdb2-47e5-8808-3638c817c76f"),
                            Value = "100"
                        },
                        new
                        {
                            Id = new Guid("52151efd-ec57-4570-a425-49ee83d1d47a"),
                            AttributeId = new Guid("b3d2b37e-a50f-4664-9895-0088a868c684"),
                            ProductId = new Guid("7123be0b-2cd6-4690-a8ed-cd23de3f9366"),
                            Value = "80"
                        },
                        new
                        {
                            Id = new Guid("86193f27-9568-4fa3-b43e-a078aa8306f3"),
                            AttributeId = new Guid("f81827c5-0420-4714-bbd9-7d4006aed677"),
                            ProductId = new Guid("aee238b2-b977-45a3-908f-d85ce88543d9"),
                            Value = "Czechia"
                        },
                        new
                        {
                            Id = new Guid("ea2ef75f-cec6-447d-b639-8ad602cdfb4b"),
                            AttributeId = new Guid("f81827c5-0420-4714-bbd9-7d4006aed677"),
                            ProductId = new Guid("9c9957cc-1cfb-41f9-9416-2c993aa2af01"),
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
                            Id = new Guid("7123be0b-2cd6-4690-a8ed-cd23de3f9366"),
                            CategoryId = new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"),
                            CreatorId = new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"),
                            ImgUrl = "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg",
                            Name = "Orange sweet",
                            Stock = 3
                        },
                        new
                        {
                            Id = new Guid("06e722df-fdb2-47e5-8808-3638c817c76f"),
                            CategoryId = new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"),
                            CreatorId = new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"),
                            ImgUrl = "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter",
                            Name = "Russet",
                            Stock = 4
                        },
                        new
                        {
                            Id = new Guid("7109dab4-fc39-40b4-bf2e-ed549bb785b1"),
                            CategoryId = new Guid("902fcd4f-b276-406b-a2b7-3ab6d70adb17"),
                            CreatorId = new Guid("5fc12554-750d-460c-84fa-3745f804b79f"),
                            Description = "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.",
                            Name = "Anton's tasty tomino",
                            Stock = 5
                        },
                        new
                        {
                            Id = new Guid("f0d0a1aa-4d9b-4917-839d-a383d25ac5e2"),
                            CategoryId = new Guid("902fcd4f-b276-406b-a2b7-3ab6d70adb17"),
                            CreatorId = new Guid("5047e0dc-2285-4b08-afd6-99b53b759bfa"),
                            Description = "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!",
                            Name = "Ilya's sweet tomino",
                            Stock = 1
                        },
                        new
                        {
                            Id = new Guid("a0d395ac-aa4d-48ca-969a-ede024e731ed"),
                            CategoryId = new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"),
                            CreatorId = new Guid("5fc12554-750d-460c-84fa-3745f804b79f"),
                            Name = "Augusta",
                            Stock = 2
                        },
                        new
                        {
                            Id = new Guid("f0969bba-72ed-479a-9d21-936c2a33d0a3"),
                            CategoryId = new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"),
                            CreatorId = new Guid("5fc12554-750d-460c-84fa-3745f804b79f"),
                            Name = "Dragon King",
                            Stock = 3
                        },
                        new
                        {
                            Id = new Guid("70cf2796-ce6e-41c3-8a92-5ef6010e240a"),
                            CategoryId = new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"),
                            CreatorId = new Guid("5fc12554-750d-460c-84fa-3745f804b79f"),
                            Name = "Happy family",
                            Stock = 10
                        },
                        new
                        {
                            Id = new Guid("aee238b2-b977-45a3-908f-d85ce88543d9"),
                            CategoryId = new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"),
                            CreatorId = new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"),
                            Description = "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.",
                            ImgUrl = "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg",
                            Name = "Fuerte",
                            Stock = 11
                        },
                        new
                        {
                            Id = new Guid("9c9957cc-1cfb-41f9-9416-2c993aa2af01"),
                            CategoryId = new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"),
                            CreatorId = new Guid("e1c12bea-a9ea-47ca-8a02-8f787598b7bd"),
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
                            Id = new Guid("1eb979e8-9ccd-474d-97d4-a68bb0862258"),
                            Email = "admin@admin.com",
                            ImgUrl = "",
                            Name = "admin",
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"),
                            Email = "maksim@mail.com",
                            ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                            Name = "Maksim",
                            Password = "123",
                            Role = 1,
                            Username = "MaksimDubr"
                        },
                        new
                        {
                            Id = new Guid("5fc12554-750d-460c-84fa-3745f804b79f"),
                            Email = "anton@mail.com",
                            ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                            Name = "Anton",
                            Password = "123456",
                            Role = 1,
                            Username = "AntonHavl"
                        },
                        new
                        {
                            Id = new Guid("e1c12bea-a9ea-47ca-8a02-8f787598b7bd"),
                            Email = "nastya@mail.com",
                            ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                            Name = "Nastya",
                            Password = "1234",
                            Role = 1,
                            Username = "NastyaMiro"
                        },
                        new
                        {
                            Id = new Guid("5047e0dc-2285-4b08-afd6-99b53b759bfa"),
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