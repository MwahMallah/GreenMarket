using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedHarvests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("adb9e92d-3fc7-4040-bf9e-334c6504ac17"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("42e39331-1121-4d25-948f-81e9fe086e88"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("52151efd-ec57-4570-a425-49ee83d1d47a"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("86193f27-9568-4fa3-b43e-a078aa8306f3"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("a6451b18-1e7a-4a2a-877d-4bd441556479"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("b882a508-6600-4f4d-98bc-76d37621d5f4"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("ea2ef75f-cec6-447d-b639-8ad602cdfb4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70cf2796-ce6e-41c3-8a92-5ef6010e240a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7109dab4-fc39-40b4-bf2e-ed549bb785b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0d395ac-aa4d-48ca-969a-ede024e731ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0969bba-72ed-479a-9d21-936c2a33d0a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0d0a1aa-4d9b-4917-839d-a383d25ac5e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eb979e8-9ccd-474d-97d4-a68bb0862258"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("7a05b016-a5fc-4960-8949-075962679952"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("b3d2b37e-a50f-4664-9895-0088a868c684"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("f81827c5-0420-4714-bbd9-7d4006aed677"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("902fcd4f-b276-406b-a2b7-3ab6d70adb17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06e722df-fdb2-47e5-8808-3638c817c76f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7123be0b-2cd6-4690-a8ed-cd23de3f9366"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c9957cc-1cfb-41f9-9416-2c993aa2af01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aee238b2-b977-45a3-908f-d85ce88543d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5047e0dc-2285-4b08-afd6-99b53b759bfa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fc12554-750d-460c-84fa-3745f804b79f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b711ee60-c3fc-4206-849d-329ee164a38c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1c12bea-a9ea-47ca-8a02-8f787598b7bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3b100021-8796-4494-9eda-ab8764b315e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2e23539-f5ba-4660-8f15-ccdf912c8b74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03202b08-ac6b-4079-9a44-ddf83f8d0ba8"));

            migrationBuilder.CreateTable(
                name: "Harvests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harvests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harvests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[] { new Guid("5bfa193f-6d88-40e3-94a5-c2dbfaa3fc5c"), null, "Crops", null, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("384bd3bf-ea88-4285-b7b5-fd620d7fa84b"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("576491e6-94bb-42f9-92e3-77b5fc4fc8fd"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" },
                    { new Guid("b4ab2398-005e-4f21-ad5e-f8ee81187009"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("1e117874-e224-4480-8544-2564af267c9b"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("5bfa193f-6d88-40e3-94a5-c2dbfaa3fc5c"), 0 },
                    { new Guid("c8dc4410-09e9-4f15-9fe2-745e2b63ccd6"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("5bfa193f-6d88-40e3-94a5-c2dbfaa3fc5c"), 0 },
                    { new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("c8dc4410-09e9-4f15-9fe2-745e2b63ccd6"), 0 },
                    { new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("1e117874-e224-4480-8544-2564af267c9b"), 0 },
                    { new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("1e117874-e224-4480-8544-2564af267c9b"), 0 },
                    { new Guid("cc73dc8d-4a9e-4119-8efd-5d22bcfa38da"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("c8dc4410-09e9-4f15-9fe2-745e2b63ccd6"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("588d5923-dab1-487c-a47d-055755d4bf6e"), new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"), "Price/piece" },
                    { new Guid("5cdc1abf-9959-417a-b919-ee822ac7f733"), new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"), "Price/kg" },
                    { new Guid("6d555d85-7dcf-49e4-a327-7e791a8b602e"), new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"), "Place of origin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("be047289-f129-4e01-8f34-2c658a98b5ce"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("cc73dc8d-4a9e-4119-8efd-5d22bcfa38da"), 0 },
                    { new Guid("f10a0c86-7252-4661-a528-a44b8119f17e"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("cc73dc8d-4a9e-4119-8efd-5d22bcfa38da"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("12f6a90f-31b2-4127-af1f-3e399a055db0"), new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"), new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"), null, null, "Augusta", 2 },
                    { new Guid("1a81e1d4-d2b3-4d54-b0d2-5c984446e7ab"), new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"), new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet", 3 },
                    { new Guid("1fb243be-a6d9-46d4-ab60-edab6f858021"), new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"), new Guid("b4ab2398-005e-4f21-ad5e-f8ee81187009"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen", 5 },
                    { new Guid("4ce5bbb5-292a-4ffc-8337-232858b1193e"), new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"), new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"), null, null, "Happy family", 10 },
                    { new Guid("8465bffd-5a40-4d71-8b73-5f95561d6010"), new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"), new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"), null, null, "Dragon King", 3 },
                    { new Guid("9f322e5a-2c60-4087-ac97-cf7d73f39b23"), new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"), new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet", 4 },
                    { new Guid("b270fb5d-c1af-4074-b16f-08e8e0603362"), new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"), new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte", 11 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("219a0ec9-15ca-43a8-b923-581ae8d5633e"), new Guid("5cdc1abf-9959-417a-b919-ee822ac7f733"), new Guid("1a81e1d4-d2b3-4d54-b0d2-5c984446e7ab"), "80" },
                    { new Guid("5d61e0a3-1a7c-4c6a-9850-c770c508661a"), new Guid("6d555d85-7dcf-49e4-a327-7e791a8b602e"), new Guid("b270fb5d-c1af-4074-b16f-08e8e0603362"), "Czechia" },
                    { new Guid("a350ee68-ecbe-4774-a96a-e299ca6d0f9b"), new Guid("6d555d85-7dcf-49e4-a327-7e791a8b602e"), new Guid("1fb243be-a6d9-46d4-ab60-edab6f858021"), "Puerto Rico" },
                    { new Guid("a7a489f9-1f2d-49b2-9e6b-e2b13c99d48d"), new Guid("588d5923-dab1-487c-a47d-055755d4bf6e"), new Guid("b270fb5d-c1af-4074-b16f-08e8e0603362"), "25" },
                    { new Guid("ba6195af-f6ae-4887-8d9d-8995eb2927f9"), new Guid("588d5923-dab1-487c-a47d-055755d4bf6e"), new Guid("1fb243be-a6d9-46d4-ab60-edab6f858021"), "35" },
                    { new Guid("be212faf-6a8f-49cd-9e67-cc519ae7c09c"), new Guid("5cdc1abf-9959-417a-b919-ee822ac7f733"), new Guid("9f322e5a-2c60-4087-ac97-cf7d73f39b23"), "100" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("1af8a77e-79b2-4a8c-9893-17fdb81f25f3"), new Guid("f10a0c86-7252-4661-a528-a44b8119f17e"), new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino", 5 },
                    { new Guid("38ca5a00-7f3f-47d7-9c13-535bdc3d0330"), new Guid("f10a0c86-7252-4661-a528-a44b8119f17e"), new Guid("576491e6-94bb-42f9-92e3-77b5fc4fc8fd"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Harvests_ProductId",
                table: "Harvests",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Harvests");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be047289-f129-4e01-8f34-2c658a98b5ce"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("219a0ec9-15ca-43a8-b923-581ae8d5633e"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("5d61e0a3-1a7c-4c6a-9850-c770c508661a"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("a350ee68-ecbe-4774-a96a-e299ca6d0f9b"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("a7a489f9-1f2d-49b2-9e6b-e2b13c99d48d"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("ba6195af-f6ae-4887-8d9d-8995eb2927f9"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("be212faf-6a8f-49cd-9e67-cc519ae7c09c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12f6a90f-31b2-4127-af1f-3e399a055db0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1af8a77e-79b2-4a8c-9893-17fdb81f25f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38ca5a00-7f3f-47d7-9c13-535bdc3d0330"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ce5bbb5-292a-4ffc-8337-232858b1193e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8465bffd-5a40-4d71-8b73-5f95561d6010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("384bd3bf-ea88-4285-b7b5-fd620d7fa84b"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("588d5923-dab1-487c-a47d-055755d4bf6e"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("5cdc1abf-9959-417a-b919-ee822ac7f733"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("6d555d85-7dcf-49e4-a327-7e791a8b602e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b98eb05b-4165-420f-b65c-b4f9302e999e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f10a0c86-7252-4661-a528-a44b8119f17e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a81e1d4-d2b3-4d54-b0d2-5c984446e7ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1fb243be-a6d9-46d4-ab60-edab6f858021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f322e5a-2c60-4087-ac97-cf7d73f39b23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b270fb5d-c1af-4074-b16f-08e8e0603362"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43810a23-b4c3-479d-90ec-5a5fcdcdb051"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("576491e6-94bb-42f9-92e3-77b5fc4fc8fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ffeb88a-73d6-4af6-9a0d-e7f5bdc9b2ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f8395ac-e43a-48fc-9605-6309ea5f4fe2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc73dc8d-4a9e-4119-8efd-5d22bcfa38da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27e926e7-cf4b-4769-8ad7-bb59d8f73e3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4ab2398-005e-4f21-ad5e-f8ee81187009"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e117874-e224-4480-8544-2564af267c9b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8dc4410-09e9-4f15-9fe2-745e2b63ccd6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bfa193f-6d88-40e3-94a5-c2dbfaa3fc5c"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[] { new Guid("03202b08-ac6b-4079-9a44-ddf83f8d0ba8"), null, "Crops", null, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("1eb979e8-9ccd-474d-97d4-a68bb0862258"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("5047e0dc-2285-4b08-afd6-99b53b759bfa"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" },
                    { new Guid("5fc12554-750d-460c-84fa-3745f804b79f"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("e1c12bea-a9ea-47ca-8a02-8f787598b7bd"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("3b100021-8796-4494-9eda-ab8764b315e0"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("03202b08-ac6b-4079-9a44-ddf83f8d0ba8"), 0 },
                    { new Guid("f2e23539-f5ba-4660-8f15-ccdf912c8b74"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("03202b08-ac6b-4079-9a44-ddf83f8d0ba8"), 0 },
                    { new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("f2e23539-f5ba-4660-8f15-ccdf912c8b74"), 0 },
                    { new Guid("b711ee60-c3fc-4206-849d-329ee164a38c"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("3b100021-8796-4494-9eda-ab8764b315e0"), 0 },
                    { new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("3b100021-8796-4494-9eda-ab8764b315e0"), 0 },
                    { new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("f2e23539-f5ba-4660-8f15-ccdf912c8b74"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("7a05b016-a5fc-4960-8949-075962679952"), new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"), "Price/piece" },
                    { new Guid("b3d2b37e-a50f-4664-9895-0088a868c684"), new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"), "Price/kg" },
                    { new Guid("f81827c5-0420-4714-bbd9-7d4006aed677"), new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"), "Place of origin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("902fcd4f-b276-406b-a2b7-3ab6d70adb17"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("b711ee60-c3fc-4206-849d-329ee164a38c"), 0 },
                    { new Guid("adb9e92d-3fc7-4040-bf9e-334c6504ac17"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("b711ee60-c3fc-4206-849d-329ee164a38c"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("06e722df-fdb2-47e5-8808-3638c817c76f"), new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"), new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet", 4 },
                    { new Guid("70cf2796-ce6e-41c3-8a92-5ef6010e240a"), new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"), new Guid("5fc12554-750d-460c-84fa-3745f804b79f"), null, null, "Happy family", 10 },
                    { new Guid("7123be0b-2cd6-4690-a8ed-cd23de3f9366"), new Guid("bfd219db-1f66-4989-8435-f259d21fb7f5"), new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet", 3 },
                    { new Guid("9c9957cc-1cfb-41f9-9416-2c993aa2af01"), new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"), new Guid("e1c12bea-a9ea-47ca-8a02-8f787598b7bd"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen", 5 },
                    { new Guid("a0d395ac-aa4d-48ca-969a-ede024e731ed"), new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"), new Guid("5fc12554-750d-460c-84fa-3745f804b79f"), null, null, "Augusta", 2 },
                    { new Guid("aee238b2-b977-45a3-908f-d85ce88543d9"), new Guid("ee4050ac-89e3-488c-a393-b3c2d4f74fef"), new Guid("7342d67e-bd04-430a-aa23-c28d4a896376"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte", 11 },
                    { new Guid("f0969bba-72ed-479a-9d21-936c2a33d0a3"), new Guid("b0b86f2f-cbc7-449b-b7d8-c2f5ad868b4d"), new Guid("5fc12554-750d-460c-84fa-3745f804b79f"), null, null, "Dragon King", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("42e39331-1121-4d25-948f-81e9fe086e88"), new Guid("7a05b016-a5fc-4960-8949-075962679952"), new Guid("aee238b2-b977-45a3-908f-d85ce88543d9"), "25" },
                    { new Guid("52151efd-ec57-4570-a425-49ee83d1d47a"), new Guid("b3d2b37e-a50f-4664-9895-0088a868c684"), new Guid("7123be0b-2cd6-4690-a8ed-cd23de3f9366"), "80" },
                    { new Guid("86193f27-9568-4fa3-b43e-a078aa8306f3"), new Guid("f81827c5-0420-4714-bbd9-7d4006aed677"), new Guid("aee238b2-b977-45a3-908f-d85ce88543d9"), "Czechia" },
                    { new Guid("a6451b18-1e7a-4a2a-877d-4bd441556479"), new Guid("b3d2b37e-a50f-4664-9895-0088a868c684"), new Guid("06e722df-fdb2-47e5-8808-3638c817c76f"), "100" },
                    { new Guid("b882a508-6600-4f4d-98bc-76d37621d5f4"), new Guid("7a05b016-a5fc-4960-8949-075962679952"), new Guid("9c9957cc-1cfb-41f9-9416-2c993aa2af01"), "35" },
                    { new Guid("ea2ef75f-cec6-447d-b639-8ad602cdfb4b"), new Guid("f81827c5-0420-4714-bbd9-7d4006aed677"), new Guid("9c9957cc-1cfb-41f9-9416-2c993aa2af01"), "Puerto Rico" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("7109dab4-fc39-40b4-bf2e-ed549bb785b1"), new Guid("902fcd4f-b276-406b-a2b7-3ab6d70adb17"), new Guid("5fc12554-750d-460c-84fa-3745f804b79f"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino", 5 },
                    { new Guid("f0d0a1aa-4d9b-4917-839d-a383d25ac5e2"), new Guid("902fcd4f-b276-406b-a2b7-3ab6d70adb17"), new Guid("5047e0dc-2285-4b08-afd6-99b53b759bfa"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino", 1 }
                });
        }
    }
}
