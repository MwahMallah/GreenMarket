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
    [Migration("20241105010206_SeedUsers")]
    partial class SeedUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenMarket.DAL.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3b7d763b-b070-47ce-8196-4bef5e81b498"),
                            Name = "Maksim"
                        },
                        new
                        {
                            Id = new Guid("5bf00c33-15a9-4bd1-91a0-fc0331a41416"),
                            Name = "Anton"
                        },
                        new
                        {
                            Id = new Guid("6768608d-9080-403c-9314-846327f6b06a"),
                            Name = "Nastya"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}