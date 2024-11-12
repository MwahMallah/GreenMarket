using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesHaveSubCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("525259a7-d04c-4c92-8c9e-82d078b4bb1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b956730-ae69-4d5b-a84d-bf72d9d18191"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9876364-715f-4de6-9d48-e8d13492d8d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b18e6a99-7d4e-4c9c-afb0-8b6075c9a23e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2d7a0aa-6ab5-4d92-bfcf-c7a6b972bac3"));

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33e8e7a0-89d6-4428-9223-d7cec7471cd6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed7ba24e-2e5d-4339-ae48-f8998cee6b7e"));

            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("5b3a9cec-5945-40e2-b419-1135963808f6"), "Vegetables", null },
                    { new Guid("b0e2e36b-baea-4c5c-98b2-df904865657d"), "Fruits", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("113f028a-1b15-4853-95b9-48c085716673"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("29beb381-8bb5-4b81-9c32-466e3277ee36"), "", "admin", "admin", 0, "admin" },
                    { new Guid("460299fc-b4bb-432b-95e7-913ea186c6eb"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("d43e7e4b-fd25-439a-90f2-e50e39aa5d20"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("4e5ec121-6883-460f-9072-219b7322b57c"), "Tomato", new Guid("5b3a9cec-5945-40e2-b419-1135963808f6") },
                    { new Guid("e71083da-5451-4833-875a-28d0e4580532"), "Watermelon", new Guid("b0e2e36b-baea-4c5c-98b2-df904865657d") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("3de07655-8539-450d-b2ac-3e2bd295c3d9"), new Guid("e71083da-5451-4833-875a-28d0e4580532"), "Happy family" },
                    { new Guid("4a1f1ffe-92c6-46be-ac35-6635fb41099d"), new Guid("4e5ec121-6883-460f-9072-219b7322b57c"), "Roma" },
                    { new Guid("77e99af3-5e28-4787-b64b-3e24029cee5a"), new Guid("e71083da-5451-4833-875a-28d0e4580532"), "Dragon King" },
                    { new Guid("b01b3ab8-400f-4584-a48b-5b47d51a4433"), new Guid("e71083da-5451-4833-875a-28d0e4580532"), "Augusta" },
                    { new Guid("c41f0066-2100-420f-bc17-3e8ea9f16bbe"), new Guid("4e5ec121-6883-460f-9072-219b7322b57c"), "Tomino" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories",
                column: "ParentId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3de07655-8539-450d-b2ac-3e2bd295c3d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a1f1ffe-92c6-46be-ac35-6635fb41099d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77e99af3-5e28-4787-b64b-3e24029cee5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b01b3ab8-400f-4584-a48b-5b47d51a4433"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c41f0066-2100-420f-bc17-3e8ea9f16bbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("113f028a-1b15-4853-95b9-48c085716673"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29beb381-8bb5-4b81-9c32-466e3277ee36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("460299fc-b4bb-432b-95e7-913ea186c6eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d43e7e4b-fd25-439a-90f2-e50e39aa5d20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e5ec121-6883-460f-9072-219b7322b57c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e71083da-5451-4833-875a-28d0e4580532"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b3a9cec-5945-40e2-b419-1135963808f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0e2e36b-baea-4c5c-98b2-df904865657d"));

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Categories");

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
        }
    }
}
