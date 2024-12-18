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
    [Migration("20241109172913_CategoriesHaveAttributes")]
    partial class CategoriesHaveAttributes
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
                            Id = new Guid("b66b0160-e13a-45a2-af13-7d0e748a8b4a"),
                            CategoryId = new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"),
                            Name = "Price/kg"
                        },
                        new
                        {
                            Id = new Guid("811e7648-d5eb-49e8-8113-19d95b94e21e"),
                            CategoryId = new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"),
                            Name = "Price/piece"
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
                            Id = new Guid("47efb8d9-7b70-4d59-892a-6c3249e73610"),
                            ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4",
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = new Guid("fcc9eb06-d6a5-487d-8948-7d4bd9322f2c"),
                            ImgUrl = "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg",
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = new Guid("280765e9-02ae-4d0e-aa30-0c7a37ce0ac0"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s",
                            Name = "Tomato",
                            ParentId = new Guid("fcc9eb06-d6a5-487d-8948-7d4bd9322f2c")
                        },
                        new
                        {
                            Id = new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"),
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg",
                            Name = "Potato",
                            ParentId = new Guid("fcc9eb06-d6a5-487d-8948-7d4bd9322f2c")
                        },
                        new
                        {
                            Id = new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"),
                            ImgUrl = "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg",
                            Name = "Watermelon",
                            ParentId = new Guid("47efb8d9-7b70-4d59-892a-6c3249e73610")
                        },
                        new
                        {
                            Id = new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"),
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s",
                            Name = "Avocado",
                            ParentId = new Guid("47efb8d9-7b70-4d59-892a-6c3249e73610")
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
                            Id = new Guid("7928cb94-dce4-473c-b73a-23870d152bd8"),
                            AttributeId = new Guid("811e7648-d5eb-49e8-8113-19d95b94e21e"),
                            ProductId = new Guid("1eeed1fa-0b5b-4b63-9b51-66b59e34c7df"),
                            Value = "25"
                        },
                        new
                        {
                            Id = new Guid("542661cd-dfa5-4cc2-9ccf-f180315724f0"),
                            AttributeId = new Guid("811e7648-d5eb-49e8-8113-19d95b94e21e"),
                            ProductId = new Guid("ce3caf1b-1ef8-441f-8156-4e02800ea623"),
                            Value = "35"
                        },
                        new
                        {
                            Id = new Guid("546ef8cb-1206-49c2-bd23-3fdc7d3db0e2"),
                            AttributeId = new Guid("b66b0160-e13a-45a2-af13-7d0e748a8b4a"),
                            ProductId = new Guid("6f22789e-fc72-4f71-ac51-85ca703a76dc"),
                            Value = "100"
                        },
                        new
                        {
                            Id = new Guid("886cdd52-5dbb-4433-b859-eed01e6801bf"),
                            AttributeId = new Guid("b66b0160-e13a-45a2-af13-7d0e748a8b4a"),
                            ProductId = new Guid("dd48a2cd-a11e-4b52-8e2d-61522ea7847f"),
                            Value = "80"
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
                            Id = new Guid("dd48a2cd-a11e-4b52-8e2d-61522ea7847f"),
                            CategoryId = new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"),
                            Name = "Orange sweet"
                        },
                        new
                        {
                            Id = new Guid("6f22789e-fc72-4f71-ac51-85ca703a76dc"),
                            CategoryId = new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"),
                            Name = "Russet"
                        },
                        new
                        {
                            Id = new Guid("c6c54c3c-c25d-421c-97ba-1fb19d178abe"),
                            CategoryId = new Guid("280765e9-02ae-4d0e-aa30-0c7a37ce0ac0"),
                            Name = "Tomino"
                        },
                        new
                        {
                            Id = new Guid("c779c813-aced-4691-a1ac-a10b70faac39"),
                            CategoryId = new Guid("280765e9-02ae-4d0e-aa30-0c7a37ce0ac0"),
                            Name = "Roma"
                        },
                        new
                        {
                            Id = new Guid("082734a9-50c6-44b3-9c18-c49afa6a40bc"),
                            CategoryId = new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"),
                            Name = "Augusta"
                        },
                        new
                        {
                            Id = new Guid("f758f733-4232-4f7c-9ca9-df6eb587ea43"),
                            CategoryId = new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"),
                            Name = "Dragon King"
                        },
                        new
                        {
                            Id = new Guid("b18c3fab-ea16-4d5b-83cd-e5c8bb05e6d1"),
                            CategoryId = new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"),
                            Name = "Happy family"
                        },
                        new
                        {
                            Id = new Guid("1eeed1fa-0b5b-4b63-9b51-66b59e34c7df"),
                            CategoryId = new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"),
                            Name = "Fuerte"
                        },
                        new
                        {
                            Id = new Guid("ce3caf1b-1ef8-441f-8156-4e02800ea623"),
                            CategoryId = new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"),
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
                            Id = new Guid("765b4018-4bf2-4ae3-a784-961216df9265"),
                            ImgUrl = "",
                            Name = "admin",
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("7a1ea4aa-94d0-481d-b615-a47f619adf89"),
                            ImgUrl = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg",
                            Name = "Maksim",
                            Password = "123",
                            Role = 1,
                            Username = "MaksimDubr"
                        },
                        new
                        {
                            Id = new Guid("caf1746e-4cb2-4c27-9c77-6c72e59dc6aa"),
                            ImgUrl = "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
                            Name = "Anton",
                            Password = "123456",
                            Role = 1,
                            Username = "AntonHavl"
                        },
                        new
                        {
                            Id = new Guid("e9015890-2667-425a-b43b-df958d8b5068"),
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
