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
                            Id = new Guid("3a455230-4da9-4a10-975b-0f3592280dda"),
                            ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3"),
                            ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s",
                            Name = "Tomato",
                            ParentId = new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3")
                        },
                        new
                        {
                            Id = new Guid("80261e76-71d6-4f85-baec-73dd48dd4419"),
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg",
                            Name = "Potato",
                            ParentId = new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3")
                        },
                        new
                        {
                            Id = new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"),
                            ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg",
                            Name = "Watermelon",
                            ParentId = new Guid("3a455230-4da9-4a10-975b-0f3592280dda")
                        });
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.ProductEntity", b =>
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

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1c3f47e-0859-4925-bd42-d0dcb809ea71"),
                            CategoryId = new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"),
                            Name = "Tomino"
                        },
                        new
                        {
                            Id = new Guid("987a4be3-3de2-4b36-b745-1befa66b1d07"),
                            CategoryId = new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"),
                            Name = "Roma"
                        },
                        new
                        {
                            Id = new Guid("06ac1c7e-5316-4d97-8974-f6e992a28eed"),
                            CategoryId = new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"),
                            Name = "Augusta"
                        },
                        new
                        {
                            Id = new Guid("a962d78c-02f4-4aeb-94a1-47d75201473c"),
                            CategoryId = new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"),
                            Name = "Dragon King"
                        },
                        new
                        {
                            Id = new Guid("120cceda-ac17-4b70-94e0-02a0b8e02398"),
                            CategoryId = new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"),
                            Name = "Happy family"
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
                            Id = new Guid("0eabe5de-01c1-4fa5-a54a-e396f7091873"),
                            ImgUrl = "",
                            Name = "admin",
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("f293feec-09d9-4342-912a-57f69252b622"),
                            ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                            Name = "Maksim",
                            Password = "123",
                            Role = 1,
                            Username = "MaksimDubr"
                        },
                        new
                        {
                            Id = new Guid("58ddd58c-c219-4295-9130-3ee7926c87a6"),
                            ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                            Name = "Anton",
                            Password = "123456",
                            Role = 1,
                            Username = "AntonHavl"
                        },
                        new
                        {
                            Id = new Guid("ec0dbbdc-275a-4828-b25d-9dcf07fd94ef"),
                            ImgUrl = "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg",
                            Name = "Nastya",
                            Password = "1234",
                            Role = 1,
                            Username = "NastyaMiro"
                        });
                });

            modelBuilder.Entity("GreenMarket.DAL.Entities.CategoryEntity", b =>
                {
                    b.HasOne("GreenMarket.DAL.Entities.CategoryEntity", "Parent")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
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

            modelBuilder.Entity("GreenMarket.DAL.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
