using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesHaveImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Categories",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("3a455230-4da9-4a10-975b-0f3592280dda"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", null },
                    { new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("0eabe5de-01c1-4fa5-a54a-e396f7091873"), "", "admin", "admin", 0, "admin" },
                    { new Guid("58ddd58c-c219-4295-9130-3ee7926c87a6"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("ec0dbbdc-275a-4828-b25d-9dcf07fd94ef"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("f293feec-09d9-4342-912a-57f69252b622"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3") },
                    { new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("3a455230-4da9-4a10-975b-0f3592280dda") },
                    { new Guid("80261e76-71d6-4f85-baec-73dd48dd4419"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("06ac1c7e-5316-4d97-8974-f6e992a28eed"), new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"), "Augusta" },
                    { new Guid("120cceda-ac17-4b70-94e0-02a0b8e02398"), new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"), "Happy family" },
                    { new Guid("987a4be3-3de2-4b36-b745-1befa66b1d07"), new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"), "Roma" },
                    { new Guid("a1c3f47e-0859-4925-bd42-d0dcb809ea71"), new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"), "Tomino" },
                    { new Guid("a962d78c-02f4-4aeb-94a1-47d75201473c"), new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"), "Dragon King" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80261e76-71d6-4f85-baec-73dd48dd4419"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06ac1c7e-5316-4d97-8974-f6e992a28eed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("120cceda-ac17-4b70-94e0-02a0b8e02398"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("987a4be3-3de2-4b36-b745-1befa66b1d07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1c3f47e-0859-4925-bd42-d0dcb809ea71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a962d78c-02f4-4aeb-94a1-47d75201473c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0eabe5de-01c1-4fa5-a54a-e396f7091873"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58ddd58c-c219-4295-9130-3ee7926c87a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec0dbbdc-275a-4828-b25d-9dcf07fd94ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f293feec-09d9-4342-912a-57f69252b622"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a455230-4da9-4a10-975b-0f3592280dda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3"));

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Categories");

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
        }
    }
}
