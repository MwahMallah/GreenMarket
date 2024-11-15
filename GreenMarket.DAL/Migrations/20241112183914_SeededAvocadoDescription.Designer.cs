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
    [Migration("20241112183914_SeededAvocadoDescription")]
    partial class SeededAvocadoDescription
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
                            Id = new Guid("7f6d3e5a-cfc1-4d67-9a7e-6bb1570aad48"),
                            CategoryId = new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"),
                            Name = "Price/kg"
                        },
                        new
                        {
                            Id = new Guid("c1cf1478-e101-463d-be41-4e75f028134b"),
                            CategoryId = new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"),
                            Name = "Price/piece"
                        },
                        new
                        {
                            Id = new Guid("74730f37-7ba4-457e-9c44-b23ddd0b0d35"),
                            CategoryId = new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"),
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
                            Id = new Guid("1c9de80d-7703-4603-8aba-d8eb76cc3ce6"),
                            Name = "Crops"
                        },
                        new
                        {
                            Id = new Guid("6ca80e08-e21f-41eb-9046-4802a87a6803"),
                            ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                            Name = "Fruits",
                            ParentId = new Guid("1c9de80d-7703-4603-8aba-d8eb76cc3ce6")
                        },
                        new
                        {
                            Id = new Guid("80cb0360-3d74-49d8-a5cf-782536b54250"),
                            ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                            Name = "Vegetables",
                            ParentId = new Guid("1c9de80d-7703-4603-8aba-d8eb76cc3ce6")
                        },
                        new
                        {
                            Id = new Guid("1debe3aa-ad1a-48d8-9cdb-d6830c7bb4b0"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s",
                            Name = "Tomato",
                            ParentId = new Guid("80cb0360-3d74-49d8-a5cf-782536b54250")
                        },
                        new
                        {
                            Id = new Guid("dca89a1a-8695-42d1-9220-ecbacee8837a"),
                            ImgUrl = "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg",
                            Name = "Tomino",
                            ParentId = new Guid("1debe3aa-ad1a-48d8-9cdb-d6830c7bb4b0")
                        },
                        new
                        {
                            Id = new Guid("8ce8c316-adb9-48e9-ac28-51daeed44253"),
                            ImgUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz",
                            Name = "Roma",
                            ParentId = new Guid("1debe3aa-ad1a-48d8-9cdb-d6830c7bb4b0")
                        },
                        new
                        {
                            Id = new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"),
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg",
                            Name = "Potato",
                            ParentId = new Guid("80cb0360-3d74-49d8-a5cf-782536b54250")
                        },
                        new
                        {
                            Id = new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"),
                            ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg",
                            Name = "Watermelon",
                            ParentId = new Guid("6ca80e08-e21f-41eb-9046-4802a87a6803")
                        },
                        new
                        {
                            Id = new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s",
                            Name = "Avocado",
                            ParentId = new Guid("6ca80e08-e21f-41eb-9046-4802a87a6803")
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
                            Id = new Guid("18554e18-db73-47ab-bceb-c8d1baaa9e06"),
                            AttributeId = new Guid("c1cf1478-e101-463d-be41-4e75f028134b"),
                            ProductId = new Guid("7428e6c9-15a8-468d-8fb9-aae6b3e60308"),
                            Value = "25"
                        },
                        new
                        {
                            Id = new Guid("089937a4-ccd5-477a-afae-c6980087c924"),
                            AttributeId = new Guid("c1cf1478-e101-463d-be41-4e75f028134b"),
                            ProductId = new Guid("4f6b2171-fbdf-4f3f-8ebd-d2879b61a6cf"),
                            Value = "35"
                        },
                        new
                        {
                            Id = new Guid("00b2db4c-d50a-454a-8de8-a97fb762656d"),
                            AttributeId = new Guid("7f6d3e5a-cfc1-4d67-9a7e-6bb1570aad48"),
                            ProductId = new Guid("890b5920-1e6a-4e9c-b65e-b42f9c2dfd98"),
                            Value = "100"
                        },
                        new
                        {
                            Id = new Guid("417e37aa-df1e-4fc4-8e72-4a46185b11bf"),
                            AttributeId = new Guid("7f6d3e5a-cfc1-4d67-9a7e-6bb1570aad48"),
                            ProductId = new Guid("e4e7b476-d625-430c-8a52-b0eaa7e558c1"),
                            Value = "80"
                        },
                        new
                        {
                            Id = new Guid("482cf4f1-f9ee-46ae-a79d-a333bb866841"),
                            AttributeId = new Guid("74730f37-7ba4-457e-9c44-b23ddd0b0d35"),
                            ProductId = new Guid("7428e6c9-15a8-468d-8fb9-aae6b3e60308"),
                            Value = "Czechia"
                        },
                        new
                        {
                            Id = new Guid("3cd38356-aed3-4937-a112-32204eb66d59"),
                            AttributeId = new Guid("74730f37-7ba4-457e-9c44-b23ddd0b0d35"),
                            ProductId = new Guid("4f6b2171-fbdf-4f3f-8ebd-d2879b61a6cf"),
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
                            Id = new Guid("e4e7b476-d625-430c-8a52-b0eaa7e558c1"),
                            CategoryId = new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"),
                            ImgUrl = "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg",
                            Name = "Orange sweet"
                        },
                        new
                        {
                            Id = new Guid("890b5920-1e6a-4e9c-b65e-b42f9c2dfd98"),
                            CategoryId = new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"),
                            ImgUrl = "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter",
                            Name = "Russet"
                        },
                        new
                        {
                            Id = new Guid("72e4c807-4cce-4f72-9bb0-d9760aaf4734"),
                            CategoryId = new Guid("dca89a1a-8695-42d1-9220-ecbacee8837a"),
                            Description = "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.",
                            Name = "Anton's tasty tomino"
                        },
                        new
                        {
                            Id = new Guid("21ef26f5-5983-4e21-93e7-ee861ae8da20"),
                            CategoryId = new Guid("dca89a1a-8695-42d1-9220-ecbacee8837a"),
                            Description = "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!",
                            Name = "Ilya's sweet tomino"
                        },
                        new
                        {
                            Id = new Guid("2e3a771e-d25e-49a8-b997-aec252e779a3"),
                            CategoryId = new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"),
                            Name = "Augusta"
                        },
                        new
                        {
                            Id = new Guid("61cb9ac5-36ed-4d6a-b1db-585678e38c78"),
                            CategoryId = new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"),
                            Name = "Dragon King"
                        },
                        new
                        {
                            Id = new Guid("81a6e722-bd88-4101-b7fc-92db545a36f0"),
                            CategoryId = new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"),
                            Name = "Happy family"
                        },
                        new
                        {
                            Id = new Guid("7428e6c9-15a8-468d-8fb9-aae6b3e60308"),
                            CategoryId = new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"),
                            Description = "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.",
                            ImgUrl = "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg",
                            Name = "Fuerte"
                        },
                        new
                        {
                            Id = new Guid("4f6b2171-fbdf-4f3f-8ebd-d2879b61a6cf"),
                            CategoryId = new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"),
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
                            Id = new Guid("855580a7-1c5b-4317-8067-bc30065d6ef0"),
                            Email = "admin@admin.com",
                            ImgUrl = "",
                            Name = "admin",
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("3630bd8b-3917-43cd-8abf-0c6cef7efd85"),
                            Email = "maksim@mail.com",
                            ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                            Name = "Maksim",
                            Password = "123",
                            Role = 1,
                            Username = "MaksimDubr"
                        },
                        new
                        {
                            Id = new Guid("365d8ede-296d-4f33-b393-195f2fc52b21"),
                            Email = "anton@mail.com",
                            ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                            Name = "Anton",
                            Password = "123456",
                            Role = 1,
                            Username = "AntonHavl"
                        },
                        new
                        {
                            Id = new Guid("e469c212-800f-4678-9269-9d9eee9914cc"),
                            Email = "nastya@mail.com",
                            ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                            Name = "Nastya",
                            Password = "1234",
                            Role = 1,
                            Username = "NastyaMiro"
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
                });
#pragma warning restore 612, 618
        }
    }
}
