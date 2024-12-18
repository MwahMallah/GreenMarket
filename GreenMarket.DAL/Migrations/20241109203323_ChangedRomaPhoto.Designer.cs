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
    [Migration("20241109203323_ChangedRomaPhoto")]
    partial class ChangedRomaPhoto
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
                            Id = new Guid("3a31d67e-cc7d-4f8c-88c4-739ab207579a"),
                            CategoryId = new Guid("24f0c013-af0f-4820-be11-c380c08c118a"),
                            Name = "Price/kg"
                        },
                        new
                        {
                            Id = new Guid("67eea8a0-75d7-4bed-b315-3f2be54b064f"),
                            CategoryId = new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"),
                            Name = "Price/piece"
                        },
                        new
                        {
                            Id = new Guid("77846595-b425-4a0f-8ffb-c2b5cd801813"),
                            CategoryId = new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"),
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
                            Id = new Guid("7bfe124e-80da-4247-81ee-cf3bdd4b06c2"),
                            ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = new Guid("f417d380-b235-441a-b866-8eff5718ca7a"),
                            ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = new Guid("9f3b5de3-3cca-4745-a9bd-867916bbc5c3"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s",
                            Name = "Tomato",
                            ParentId = new Guid("f417d380-b235-441a-b866-8eff5718ca7a")
                        },
                        new
                        {
                            Id = new Guid("ce9dc4e8-a8ee-4108-98e3-cc0eeb3069d7"),
                            ImgUrl = "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg",
                            Name = "Tomino",
                            ParentId = new Guid("9f3b5de3-3cca-4745-a9bd-867916bbc5c3")
                        },
                        new
                        {
                            Id = new Guid("7de0bead-7c07-424f-9b4c-e9ee635f286f"),
                            ImgUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz",
                            Name = "Roma",
                            ParentId = new Guid("9f3b5de3-3cca-4745-a9bd-867916bbc5c3")
                        },
                        new
                        {
                            Id = new Guid("24f0c013-af0f-4820-be11-c380c08c118a"),
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg",
                            Name = "Potato",
                            ParentId = new Guid("f417d380-b235-441a-b866-8eff5718ca7a")
                        },
                        new
                        {
                            Id = new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"),
                            ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg",
                            Name = "Watermelon",
                            ParentId = new Guid("7bfe124e-80da-4247-81ee-cf3bdd4b06c2")
                        },
                        new
                        {
                            Id = new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s",
                            Name = "Avocado",
                            ParentId = new Guid("7bfe124e-80da-4247-81ee-cf3bdd4b06c2")
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
                            Id = new Guid("77523386-71b2-4f53-9943-9595dfa705d8"),
                            AttributeId = new Guid("67eea8a0-75d7-4bed-b315-3f2be54b064f"),
                            ProductId = new Guid("845a5390-b34d-4976-ae48-cf47b5b03c13"),
                            Value = "25"
                        },
                        new
                        {
                            Id = new Guid("aba7819d-9376-40ff-b1bd-375522fd6573"),
                            AttributeId = new Guid("67eea8a0-75d7-4bed-b315-3f2be54b064f"),
                            ProductId = new Guid("2bd5bf62-4c93-452c-b01b-cf1683d403d7"),
                            Value = "35"
                        },
                        new
                        {
                            Id = new Guid("169d6b58-b2ba-4794-8bc8-b87d5d4e3996"),
                            AttributeId = new Guid("3a31d67e-cc7d-4f8c-88c4-739ab207579a"),
                            ProductId = new Guid("406cd876-95d1-4927-8dcf-3939c5c6e118"),
                            Value = "100"
                        },
                        new
                        {
                            Id = new Guid("62893e41-ed5e-4336-8bf3-6c431e4fd087"),
                            AttributeId = new Guid("3a31d67e-cc7d-4f8c-88c4-739ab207579a"),
                            ProductId = new Guid("711c25d4-f26d-4c5f-8fb5-ed87a15649fd"),
                            Value = "80"
                        },
                        new
                        {
                            Id = new Guid("284428e7-2722-4fa4-8eea-5c3f18637ad2"),
                            AttributeId = new Guid("77846595-b425-4a0f-8ffb-c2b5cd801813"),
                            ProductId = new Guid("845a5390-b34d-4976-ae48-cf47b5b03c13"),
                            Value = "Czechia"
                        },
                        new
                        {
                            Id = new Guid("2b8f0ec2-85bc-483b-9b94-e0c0a40ce5fd"),
                            AttributeId = new Guid("77846595-b425-4a0f-8ffb-c2b5cd801813"),
                            ProductId = new Guid("2bd5bf62-4c93-452c-b01b-cf1683d403d7"),
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
                            Id = new Guid("711c25d4-f26d-4c5f-8fb5-ed87a15649fd"),
                            CategoryId = new Guid("24f0c013-af0f-4820-be11-c380c08c118a"),
                            ImgUrl = "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg",
                            Name = "Orange sweet"
                        },
                        new
                        {
                            Id = new Guid("406cd876-95d1-4927-8dcf-3939c5c6e118"),
                            CategoryId = new Guid("24f0c013-af0f-4820-be11-c380c08c118a"),
                            ImgUrl = "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter",
                            Name = "Russet"
                        },
                        new
                        {
                            Id = new Guid("e479bdab-fbb8-418e-ac8a-09853ff8d9b0"),
                            CategoryId = new Guid("ce9dc4e8-a8ee-4108-98e3-cc0eeb3069d7"),
                            Name = "Anton's tasty tomino"
                        },
                        new
                        {
                            Id = new Guid("a21fa001-5e64-4068-8fb5-503b80c5b13a"),
                            CategoryId = new Guid("ce9dc4e8-a8ee-4108-98e3-cc0eeb3069d7"),
                            Name = "Ilya's sweet tomino"
                        },
                        new
                        {
                            Id = new Guid("344d3dac-c46e-4d5b-9d90-054313fd9ce4"),
                            CategoryId = new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"),
                            Name = "Augusta"
                        },
                        new
                        {
                            Id = new Guid("6d0878e3-c29e-4508-baa3-5f60a5c38c05"),
                            CategoryId = new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"),
                            Name = "Dragon King"
                        },
                        new
                        {
                            Id = new Guid("27b08ca3-0f0f-4227-ac35-059bcbd0fa1e"),
                            CategoryId = new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"),
                            Name = "Happy family"
                        },
                        new
                        {
                            Id = new Guid("845a5390-b34d-4976-ae48-cf47b5b03c13"),
                            CategoryId = new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"),
                            ImgUrl = "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg",
                            Name = "Fuerte"
                        },
                        new
                        {
                            Id = new Guid("2bd5bf62-4c93-452c-b01b-cf1683d403d7"),
                            CategoryId = new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"),
                            ImgUrl = "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png",
                            Name = "Gwen"
                        });
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("9a98078c-638a-459a-a655-883723aa86cc"),
                            ImgUrl = "",
                            Name = "admin",
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("3c0fa408-8251-4af4-a44b-71d6c0f9d3af"),
                            ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                            Name = "Maksim",
                            Password = "123",
                            Role = 1,
                            Username = "MaksimDubr"
                        },
                        new
                        {
                            Id = new Guid("58cb733e-09a0-4c0a-9ea0-d5454a0bd412"),
                            ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                            Name = "Anton",
                            Password = "123456",
                            Role = 1,
                            Username = "AntonHavl"
                        },
                        new
                        {
                            Id = new Guid("1bb33bd1-2115-4079-b6c1-846f8dda38f7"),
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
