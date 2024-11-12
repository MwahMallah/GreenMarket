using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UsersHaveUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b9b55ac-ce43-4672-8f45-b77be61ae03c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73c6eb52-f1d0-415e-a96d-615686175d22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a751a174-d892-462d-b0b1-244057920553"));

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("36b44d17-5068-4d81-be40-14b0887e48a2"), "Nastya", "1234", "NastyaMiro" },
                    { new Guid("8974a081-674a-46a2-9a2c-216699afbc77"), "Anton", "123456", "AntonHavl" },
                    { new Guid("c1032404-bb69-4884-9102-ef0c76f58ab1"), "Maksim", "123", "MaksimDubr" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

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

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("4b9b55ac-ce43-4672-8f45-b77be61ae03c"), "Anton", "123456" },
                    { new Guid("73c6eb52-f1d0-415e-a96d-615686175d22"), "Nastya", "1234" },
                    { new Guid("a751a174-d892-462d-b0b1-244057920553"), "Maksim", "123" }
                });
        }
    }
}
