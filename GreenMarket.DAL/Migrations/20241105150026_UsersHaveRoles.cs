using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UsersHaveRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36b44d17-5068-4d81-be40-14b0887e48a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8974a081-674a-46a2-9a2c-216699afbc77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1032404-bb69-4884-9102-ef0c76f58ab1"));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("36b44d17-5068-4d81-be40-14b0887e48a2"), "Nastya", "1234", "NastyaMiro" },
                    { new Guid("8974a081-674a-46a2-9a2c-216699afbc77"), "Anton", "123456", "AntonHavl" },
                    { new Guid("c1032404-bb69-4884-9102-ef0c76f58ab1"), "Maksim", "123", "MaksimDubr" }
                });
        }
    }
}
