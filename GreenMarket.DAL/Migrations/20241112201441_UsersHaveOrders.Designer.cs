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
    [Migration("20241112201441_UsersHaveOrders")]
    partial class UsersHaveOrders
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
                            Id = new Guid("0cc0e867-b665-451c-a936-9a0780a3a743"),
                            CategoryId = new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"),
                            Name = "Price/kg"
                        },
                        new
                        {
                            Id = new Guid("0860d0d6-ee3b-4d91-aef4-ea2196f064fb"),
                            CategoryId = new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"),
                            Name = "Price/piece"
                        },
                        new
                        {
                            Id = new Guid("2689e37e-9e42-4a7e-a6ce-c75837656db3"),
                            CategoryId = new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"),
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

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("364c8816-277c-462d-a872-320aa47d20b2"),
                            Name = "Crops"
                        },
                        new
                        {
                            Id = new Guid("72e32323-a893-4523-8c67-855fb5db1f4b"),
                            ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                            Name = "Fruits",
                            ParentId = new Guid("364c8816-277c-462d-a872-320aa47d20b2")
                        },
                        new
                        {
                            Id = new Guid("a1d2afd0-3156-4477-ba4c-fc77e2b9a994"),
                            ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                            Name = "Vegetables",
                            ParentId = new Guid("364c8816-277c-462d-a872-320aa47d20b2")
                        },
                        new
                        {
                            Id = new Guid("3afff307-668b-41dc-93e0-b2e5cabc8e1e"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s",
                            Name = "Tomato",
                            ParentId = new Guid("a1d2afd0-3156-4477-ba4c-fc77e2b9a994")
                        },
                        new
                        {
                            Id = new Guid("fe178c93-c4a1-4611-ada0-adee0b667774"),
                            ImgUrl = "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg",
                            Name = "Tomino",
                            ParentId = new Guid("3afff307-668b-41dc-93e0-b2e5cabc8e1e")
                        },
                        new
                        {
                            Id = new Guid("56b23361-63b4-4350-9d26-7b171d124fa1"),
                            ImgUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz",
                            Name = "Roma",
                            ParentId = new Guid("3afff307-668b-41dc-93e0-b2e5cabc8e1e")
                        },
                        new
                        {
                            Id = new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"),
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg",
                            Name = "Potato",
                            ParentId = new Guid("a1d2afd0-3156-4477-ba4c-fc77e2b9a994")
                        },
                        new
                        {
                            Id = new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"),
                            ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg",
                            Name = "Watermelon",
                            ParentId = new Guid("72e32323-a893-4523-8c67-855fb5db1f4b")
                        },
                        new
                        {
                            Id = new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s",
                            Name = "Avocado",
                            ParentId = new Guid("72e32323-a893-4523-8c67-855fb5db1f4b")
                        });
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
                            Id = new Guid("329e413f-9ecc-4334-8ae0-e870bfc1b04d"),
                            AttributeId = new Guid("0860d0d6-ee3b-4d91-aef4-ea2196f064fb"),
                            ProductId = new Guid("a46ce5f8-687d-4352-93d5-912054bbf5be"),
                            Value = "25"
                        },
                        new
                        {
                            Id = new Guid("b296d7f2-462d-410b-b334-633fd9842370"),
                            AttributeId = new Guid("0860d0d6-ee3b-4d91-aef4-ea2196f064fb"),
                            ProductId = new Guid("ea1841fd-f21e-4c81-9c56-6dec9e982ec7"),
                            Value = "35"
                        },
                        new
                        {
                            Id = new Guid("a1359a43-5ccb-4817-a7b5-53a107601590"),
                            AttributeId = new Guid("0cc0e867-b665-451c-a936-9a0780a3a743"),
                            ProductId = new Guid("b6429f65-f01f-4254-991f-5585b2ac0f3e"),
                            Value = "100"
                        },
                        new
                        {
                            Id = new Guid("40e79707-b593-49d4-b4b0-2b2e99db90c7"),
                            AttributeId = new Guid("0cc0e867-b665-451c-a936-9a0780a3a743"),
                            ProductId = new Guid("2a0ae124-c596-4617-b6fe-0a256cca1299"),
                            Value = "80"
                        },
                        new
                        {
                            Id = new Guid("989da880-638d-4dc8-8702-736ec300deb4"),
                            AttributeId = new Guid("2689e37e-9e42-4a7e-a6ce-c75837656db3"),
                            ProductId = new Guid("a46ce5f8-687d-4352-93d5-912054bbf5be"),
                            Value = "Czechia"
                        },
                        new
                        {
                            Id = new Guid("5404bcfe-524f-4a48-9094-d8f3d610d166"),
                            AttributeId = new Guid("2689e37e-9e42-4a7e-a6ce-c75837656db3"),
                            ProductId = new Guid("ea1841fd-f21e-4c81-9c56-6dec9e982ec7"),
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

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2a0ae124-c596-4617-b6fe-0a256cca1299"),
                            CategoryId = new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"),
                            ImgUrl = "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg",
                            Name = "Orange sweet"
                        },
                        new
                        {
                            Id = new Guid("b6429f65-f01f-4254-991f-5585b2ac0f3e"),
                            CategoryId = new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"),
                            ImgUrl = "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter",
                            Name = "Russet"
                        },
                        new
                        {
                            Id = new Guid("2d052270-2acb-464e-9d3a-f15bf783dc42"),
                            CategoryId = new Guid("fe178c93-c4a1-4611-ada0-adee0b667774"),
                            Description = "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.",
                            Name = "Anton's tasty tomino"
                        },
                        new
                        {
                            Id = new Guid("667e843d-55c6-4578-a256-fb9e13f840de"),
                            CategoryId = new Guid("fe178c93-c4a1-4611-ada0-adee0b667774"),
                            Description = "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!",
                            Name = "Ilya's sweet tomino"
                        },
                        new
                        {
                            Id = new Guid("c074eb75-9001-4751-8243-474056bac4b1"),
                            CategoryId = new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"),
                            Name = "Augusta"
                        },
                        new
                        {
                            Id = new Guid("11de49d9-02e5-4579-954e-292886e8ef24"),
                            CategoryId = new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"),
                            Name = "Dragon King"
                        },
                        new
                        {
                            Id = new Guid("111564bf-fb41-4cea-a4a6-57163b556bc4"),
                            CategoryId = new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"),
                            Name = "Happy family"
                        },
                        new
                        {
                            Id = new Guid("a46ce5f8-687d-4352-93d5-912054bbf5be"),
                            CategoryId = new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"),
                            Description = "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.",
                            ImgUrl = "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg",
                            Name = "Fuerte"
                        },
                        new
                        {
                            Id = new Guid("ea1841fd-f21e-4c81-9c56-6dec9e982ec7"),
                            CategoryId = new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"),
                            Description = "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.",
                            ImgUrl = "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png",
                            Name = "Gwen"
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
                            Id = new Guid("95b80d06-26ec-4548-b91b-0aab60fafdad"),
                            Email = "admin@admin.com",
                            ImgUrl = "",
                            Name = "admin",
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("4fd058b3-67fe-44ae-888e-bf5e61b9c56e"),
                            Email = "maksim@mail.com",
                            ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                            Name = "Maksim",
                            Password = "123",
                            Role = 1,
                            Username = "MaksimDubr"
                        },
                        new
                        {
                            Id = new Guid("53326aa6-ac0d-4d0a-9dba-6d7b81f8afcd"),
                            Email = "anton@mail.com",
                            ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                            Name = "Anton",
                            Password = "123456",
                            Role = 1,
                            Username = "AntonHavl"
                        },
                        new
                        {
                            Id = new Guid("123d820e-0370-46b3-bcbe-2533ae827f3f"),
                            Email = "nastya@mail.com",
                            ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                            Name = "Nastya",
                            Password = "1234",
                            Role = 1,
                            Username = "NastyaMiro"
                        });
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.UserOrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOrderEntity");
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

                    b.Navigation("Category");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.UserOrderEntity", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.ProductEntity", "Product")
                        .WithMany("Customers")
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

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.UserEntity", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
