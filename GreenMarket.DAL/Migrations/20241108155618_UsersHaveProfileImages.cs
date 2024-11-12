using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UsersHaveProfileImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61146536-ca13-41ea-9b8c-2e5215db075a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73cc8df0-5e95-4e3b-bb02-78d35965fcb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8eae551c-1fc9-407a-8ab9-d2fa159658c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("944611e4-5701-4778-96df-7eee55684b9e"));

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Users",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("4b117560-2866-49bb-9ab4-4cdb7f702e8b"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("65b3ab25-39f4-4ec3-9d00-b672b32600be"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("ae6cdce7-ea0d-45bd-b4bc-baa106569403"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("c0c134cc-1d64-4cdf-89dc-54cb37d4ccd6"), "", "admin", "admin", 0, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b117560-2866-49bb-9ab4-4cdb7f702e8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65b3ab25-39f4-4ec3-9d00-b672b32600be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae6cdce7-ea0d-45bd-b4bc-baa106569403"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0c134cc-1d64-4cdf-89dc-54cb37d4ccd6"));

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("61146536-ca13-41ea-9b8c-2e5215db075a"), "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("73cc8df0-5e95-4e3b-bb02-78d35965fcb5"), "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("8eae551c-1fc9-407a-8ab9-d2fa159658c4"), "admin", "admin", 0, "admin" },
                    { new Guid("944611e4-5701-4778-96df-7eee55684b9e"), "Maksim", "123", 1, "MaksimDubr" }
                });
        }
    }
}
