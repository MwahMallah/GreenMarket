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
    [Migration("20241105021933_AddedUserPasswords")]
    partial class AddedUserPasswords
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenMarket.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a751a174-d892-462d-b0b1-244057920553"),
                            Name = "Maksim",
                            Password = "123"
                        },
                        new
                        {
                            Id = new Guid("4b9b55ac-ce43-4672-8f45-b77be61ae03c"),
                            Name = "Anton",
                            Password = "123456"
                        },
                        new
                        {
                            Id = new Guid("73c6eb52-f1d0-415e-a96d-615686175d22"),
                            Name = "Nastya",
                            Password = "1234"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
