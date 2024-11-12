using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAndCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("33e8e7a0-89d6-4428-9223-d7cec7471cd6"), "Watermelon" },
                    { new Guid("ed7ba24e-2e5d-4339-ae48-f8998cee6b7e"), "Tomato" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("074a96dc-8c31-4e6d-8705-1f64086ef7ce"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("3af9a2ff-3484-4b06-a8c5-4d12a9e794de"), "", "admin", "admin", 0, "admin" },
                    { new Guid("654c60a5-8cf5-4b7c-a78f-0a0e30067814"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("89ba3b73-27af-4daa-934e-f9ef3ff887e1"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("525259a7-d04c-4c92-8c9e-82d078b4bb1e"), new Guid("33e8e7a0-89d6-4428-9223-d7cec7471cd6"), "Happy family" },
                    { new Guid("6b956730-ae69-4d5b-a84d-bf72d9d18191"), new Guid("33e8e7a0-89d6-4428-9223-d7cec7471cd6"), "Dragon King" },
                    { new Guid("a9876364-715f-4de6-9d48-e8d13492d8d6"), new Guid("ed7ba24e-2e5d-4339-ae48-f8998cee6b7e"), "Tomino" },
                    { new Guid("b18e6a99-7d4e-4c9c-afb0-8b6075c9a23e"), new Guid("ed7ba24e-2e5d-4339-ae48-f8998cee6b7e"), "Roma" },
                    { new Guid("b2d7a0aa-6ab5-4d92-bfcf-c7a6b972bac3"), new Guid("33e8e7a0-89d6-4428-9223-d7cec7471cd6"), "Augusta" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("074a96dc-8c31-4e6d-8705-1f64086ef7ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3af9a2ff-3484-4b06-a8c5-4d12a9e794de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("654c60a5-8cf5-4b7c-a78f-0a0e30067814"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89ba3b73-27af-4daa-934e-f9ef3ff887e1"));

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
    }
}
