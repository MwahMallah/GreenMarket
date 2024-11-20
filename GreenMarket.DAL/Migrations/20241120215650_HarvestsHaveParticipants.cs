using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class HarvestsHaveParticipants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5285b2ec-3c92-4642-a17a-b899d8a49ed7"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("1859f1d1-567c-4295-8ed8-01ed24d017c1"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("1d333eda-d587-4b30-81db-fe38648775ca"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3f6d2d52-719a-4a74-8c52-49c6af7e4ecd"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("937631da-649f-4b71-8504-0dc661a71b9c"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("cb0e5e09-c144-41ad-b0ce-c5b8737ebc62"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("ce75b7c5-d24a-4651-a15d-c27f32e4c072"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a4a79d8-ebef-4dff-86b3-c44cbad12963"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f5371e3-0e92-4555-b06f-f787db199ef3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c77e0211-9d64-4e1d-b743-07b5b18a4011"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef900f1d-5a09-4bd4-8ace-5516cba9e014"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb16fe40-65de-447a-9766-708884d0d11a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9bb6a959-39b9-425b-b4da-949769588fd2"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("8c7c863a-698a-4fde-88ef-694bdc96888f"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("b11c52c0-de12-41f2-a4e7-6359c1153e1d"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("d0922abc-25f0-4212-8826-18e09d836031"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10ce5cb5-7daa-4837-af3a-53fec7fac087"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efe159cf-270e-49c0-958a-690cdbf7378e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f0c16b1-bd61-48dc-8a84-3ee880b92056"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8871a182-6d18-4771-b7c7-2e51a578dd63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cee94256-69c6-4807-8fec-390f93b576bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f856760d-adf9-4b4b-92e1-c1ae3bef024a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70fba05c-7346-4e55-bff0-0789f89421cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b74f93cd-3b63-4c64-b0e9-8d893f50a5c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d436a2bc-4c8f-47b3-826a-82c1075b1c68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6ad1d69-3c3c-4c03-aee8-06edf023a4db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6f7d01f-c3eb-4c8f-8fbc-92410a7a9411"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f45cbb80-a86f-459b-a9ff-fca48bfdfc29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc1f8b3b-fc48-40f1-a497-81b67db2d8ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34d453ec-eb59-4bba-a2fb-cc6cdd70b1bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47a2e167-9b1a-4db4-97bc-091eb469b215"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d677593d-9849-4e3d-9d84-6ff87516e62c"));

            migrationBuilder.CreateTable(
                name: "UserHarvest",
                columns: table => new
                {
                    HarvestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHarvest", x => new { x.HarvestId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserHarvest_Harvests_HarvestId",
                        column: x => x.HarvestId,
                        principalTable: "Harvests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserHarvest_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[] { new Guid("0e24516b-65dc-4579-960a-7c35b07f8a60"), null, "Crops", null, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("2801e25e-1851-4a67-91b4-b79764768c93"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("4233b31a-0ccf-41d5-8524-fda1cd59896d"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("473c0b7b-0253-4abf-bc1d-8d539de26a56"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("7443f593-e895-44f6-b8b0-08faf7710e6b"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("0eeff68f-287e-4ab0-b7fd-78daea33d991"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("0e24516b-65dc-4579-960a-7c35b07f8a60"), 0 },
                    { new Guid("7cdf1a1d-6225-405f-bc35-7550b6c26c0d"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("0e24516b-65dc-4579-960a-7c35b07f8a60"), 0 },
                    { new Guid("389e0ab7-12c1-49ab-ab90-30603aa5c0ad"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("0eeff68f-287e-4ab0-b7fd-78daea33d991"), 0 },
                    { new Guid("58c13104-1288-47cb-afff-b7419b2130c0"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("7cdf1a1d-6225-405f-bc35-7550b6c26c0d"), 0 },
                    { new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("0eeff68f-287e-4ab0-b7fd-78daea33d991"), 0 },
                    { new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("7cdf1a1d-6225-405f-bc35-7550b6c26c0d"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("32de2d64-595a-4a01-83cc-d51d7b0cb07b"), new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"), "Price/kg" },
                    { new Guid("3b217371-438f-4270-babb-c733219a9ce7"), new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"), "Place of origin" },
                    { new Guid("586b0156-bb25-49ae-802a-d46a702aaa10"), new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("6587d65a-3f4e-4acf-8373-febe3db9b112"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("389e0ab7-12c1-49ab-ab90-30603aa5c0ad"), 0 },
                    { new Guid("dcf4fe5e-3837-4b9a-a0a3-7e1a89cfa9f9"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("389e0ab7-12c1-49ab-ab90-30603aa5c0ad"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock", "Type" },
                values: new object[,]
                {
                    { new Guid("27135dc4-ce49-423f-a650-ae85bd1b4811"), new Guid("58c13104-1288-47cb-afff-b7419b2130c0"), new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"), null, null, "Happy family", 10, 0 },
                    { new Guid("285a41a6-59ae-4170-acd3-cccfa7a1b09e"), new Guid("58c13104-1288-47cb-afff-b7419b2130c0"), new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"), null, null, "Dragon King", 3, 0 },
                    { new Guid("5be52c42-3370-4b55-bff5-6eb879e126f8"), new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"), new Guid("473c0b7b-0253-4abf-bc1d-8d539de26a56"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen", 5, 0 },
                    { new Guid("a0bbe0f5-d840-461b-8919-2aa23878963c"), new Guid("58c13104-1288-47cb-afff-b7419b2130c0"), new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"), null, null, "Augusta", 2, 0 },
                    { new Guid("cc49e65c-4ee8-48f4-a874-2a18b60758d6"), new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"), new Guid("2801e25e-1851-4a67-91b4-b79764768c93"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet", 4, 0 },
                    { new Guid("f6104dd5-5500-4e69-82b2-141d410d4951"), new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"), new Guid("2801e25e-1851-4a67-91b4-b79764768c93"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte", 11, 0 },
                    { new Guid("f905e84d-f60e-4d76-9875-865ac02da4f5"), new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"), new Guid("2801e25e-1851-4a67-91b4-b79764768c93"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet", 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("42dcfd43-e9e1-481c-bbee-507f7d3c4625"), new Guid("3b217371-438f-4270-babb-c733219a9ce7"), new Guid("5be52c42-3370-4b55-bff5-6eb879e126f8"), "Puerto Rico" },
                    { new Guid("4b8af20d-8e15-4773-98a4-9cbbbc8d1f24"), new Guid("32de2d64-595a-4a01-83cc-d51d7b0cb07b"), new Guid("cc49e65c-4ee8-48f4-a874-2a18b60758d6"), "100" },
                    { new Guid("60519d34-fb27-47ce-9c6c-ff7fc670a1c1"), new Guid("586b0156-bb25-49ae-802a-d46a702aaa10"), new Guid("5be52c42-3370-4b55-bff5-6eb879e126f8"), "35" },
                    { new Guid("97081f01-db27-4591-99c0-305614ae3167"), new Guid("586b0156-bb25-49ae-802a-d46a702aaa10"), new Guid("f6104dd5-5500-4e69-82b2-141d410d4951"), "25" },
                    { new Guid("f0ca3f69-dcf8-411f-b973-d55c57ee91d2"), new Guid("32de2d64-595a-4a01-83cc-d51d7b0cb07b"), new Guid("f905e84d-f60e-4d76-9875-865ac02da4f5"), "80" },
                    { new Guid("f64972ea-2482-4a31-b28d-1e9491706c1b"), new Guid("3b217371-438f-4270-babb-c733219a9ce7"), new Guid("f6104dd5-5500-4e69-82b2-141d410d4951"), "Czechia" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock", "Type" },
                values: new object[,]
                {
                    { new Guid("9909bfd9-bcc4-4e5d-bca6-bbe27467df33"), new Guid("dcf4fe5e-3837-4b9a-a0a3-7e1a89cfa9f9"), new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino", 5, 0 },
                    { new Guid("f843683c-18fc-4a45-8787-91e8f9e50ca6"), new Guid("dcf4fe5e-3837-4b9a-a0a3-7e1a89cfa9f9"), new Guid("7443f593-e895-44f6-b8b0-08faf7710e6b"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino", 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserHarvest_UserId",
                table: "UserHarvest",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHarvest");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6587d65a-3f4e-4acf-8373-febe3db9b112"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("42dcfd43-e9e1-481c-bbee-507f7d3c4625"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("4b8af20d-8e15-4773-98a4-9cbbbc8d1f24"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("60519d34-fb27-47ce-9c6c-ff7fc670a1c1"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("97081f01-db27-4591-99c0-305614ae3167"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("f0ca3f69-dcf8-411f-b973-d55c57ee91d2"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("f64972ea-2482-4a31-b28d-1e9491706c1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27135dc4-ce49-423f-a650-ae85bd1b4811"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("285a41a6-59ae-4170-acd3-cccfa7a1b09e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9909bfd9-bcc4-4e5d-bca6-bbe27467df33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0bbe0f5-d840-461b-8919-2aa23878963c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f843683c-18fc-4a45-8787-91e8f9e50ca6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4233b31a-0ccf-41d5-8524-fda1cd59896d"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("32de2d64-595a-4a01-83cc-d51d7b0cb07b"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("3b217371-438f-4270-babb-c733219a9ce7"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("586b0156-bb25-49ae-802a-d46a702aaa10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c13104-1288-47cb-afff-b7419b2130c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcf4fe5e-3837-4b9a-a0a3-7e1a89cfa9f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5be52c42-3370-4b55-bff5-6eb879e126f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc49e65c-4ee8-48f4-a874-2a18b60758d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6104dd5-5500-4e69-82b2-141d410d4951"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f905e84d-f60e-4d76-9875-865ac02da4f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12191a73-c3ad-4e2d-bc0f-c9d47f974f71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7443f593-e895-44f6-b8b0-08faf7710e6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("389e0ab7-12c1-49ab-ab90-30603aa5c0ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa16fc82-e955-460f-a5fe-aa94ca9a60c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd3f5a38-81ad-43fd-8db1-ac717a98d7a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2801e25e-1851-4a67-91b4-b79764768c93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("473c0b7b-0253-4abf-bc1d-8d539de26a56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0eeff68f-287e-4ab0-b7fd-78daea33d991"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cdf1a1d-6225-405f-bc35-7550b6c26c0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e24516b-65dc-4579-960a-7c35b07f8a60"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[] { new Guid("d677593d-9849-4e3d-9d84-6ff87516e62c"), null, "Crops", null, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("70fba05c-7346-4e55-bff0-0789f89421cc"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" },
                    { new Guid("9bb6a959-39b9-425b-b4da-949769588fd2"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("b74f93cd-3b63-4c64-b0e9-8d893f50a5c8"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("f45cbb80-a86f-459b-a9ff-fca48bfdfc29"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("fc1f8b3b-fc48-40f1-a497-81b67db2d8ee"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("34d453ec-eb59-4bba-a2fb-cc6cdd70b1bb"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("d677593d-9849-4e3d-9d84-6ff87516e62c"), 0 },
                    { new Guid("47a2e167-9b1a-4db4-97bc-091eb469b215"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("d677593d-9849-4e3d-9d84-6ff87516e62c"), 0 },
                    { new Guid("10ce5cb5-7daa-4837-af3a-53fec7fac087"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("47a2e167-9b1a-4db4-97bc-091eb469b215"), 0 },
                    { new Guid("d436a2bc-4c8f-47b3-826a-82c1075b1c68"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("34d453ec-eb59-4bba-a2fb-cc6cdd70b1bb"), 0 },
                    { new Guid("e6ad1d69-3c3c-4c03-aee8-06edf023a4db"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("34d453ec-eb59-4bba-a2fb-cc6cdd70b1bb"), 0 },
                    { new Guid("f6f7d01f-c3eb-4c8f-8fbc-92410a7a9411"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("47a2e167-9b1a-4db4-97bc-091eb469b215"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("8c7c863a-698a-4fde-88ef-694bdc96888f"), new Guid("f6f7d01f-c3eb-4c8f-8fbc-92410a7a9411"), "Place of origin" },
                    { new Guid("b11c52c0-de12-41f2-a4e7-6359c1153e1d"), new Guid("d436a2bc-4c8f-47b3-826a-82c1075b1c68"), "Price/kg" },
                    { new Guid("d0922abc-25f0-4212-8826-18e09d836031"), new Guid("f6f7d01f-c3eb-4c8f-8fbc-92410a7a9411"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("5285b2ec-3c92-4642-a17a-b899d8a49ed7"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("e6ad1d69-3c3c-4c03-aee8-06edf023a4db"), 0 },
                    { new Guid("efe159cf-270e-49c0-958a-690cdbf7378e"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("e6ad1d69-3c3c-4c03-aee8-06edf023a4db"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock", "Type" },
                values: new object[,]
                {
                    { new Guid("6f0c16b1-bd61-48dc-8a84-3ee880b92056"), new Guid("d436a2bc-4c8f-47b3-826a-82c1075b1c68"), new Guid("fc1f8b3b-fc48-40f1-a497-81b67db2d8ee"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet", 4, 0 },
                    { new Guid("8871a182-6d18-4771-b7c7-2e51a578dd63"), new Guid("f6f7d01f-c3eb-4c8f-8fbc-92410a7a9411"), new Guid("f45cbb80-a86f-459b-a9ff-fca48bfdfc29"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen", 5, 0 },
                    { new Guid("9f5371e3-0e92-4555-b06f-f787db199ef3"), new Guid("10ce5cb5-7daa-4837-af3a-53fec7fac087"), new Guid("b74f93cd-3b63-4c64-b0e9-8d893f50a5c8"), null, null, "Augusta", 2, 0 },
                    { new Guid("c77e0211-9d64-4e1d-b743-07b5b18a4011"), new Guid("10ce5cb5-7daa-4837-af3a-53fec7fac087"), new Guid("b74f93cd-3b63-4c64-b0e9-8d893f50a5c8"), null, null, "Happy family", 10, 0 },
                    { new Guid("cee94256-69c6-4807-8fec-390f93b576bd"), new Guid("d436a2bc-4c8f-47b3-826a-82c1075b1c68"), new Guid("fc1f8b3b-fc48-40f1-a497-81b67db2d8ee"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet", 3, 0 },
                    { new Guid("ef900f1d-5a09-4bd4-8ace-5516cba9e014"), new Guid("10ce5cb5-7daa-4837-af3a-53fec7fac087"), new Guid("b74f93cd-3b63-4c64-b0e9-8d893f50a5c8"), null, null, "Dragon King", 3, 0 },
                    { new Guid("f856760d-adf9-4b4b-92e1-c1ae3bef024a"), new Guid("f6f7d01f-c3eb-4c8f-8fbc-92410a7a9411"), new Guid("fc1f8b3b-fc48-40f1-a497-81b67db2d8ee"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte", 11, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("1859f1d1-567c-4295-8ed8-01ed24d017c1"), new Guid("b11c52c0-de12-41f2-a4e7-6359c1153e1d"), new Guid("cee94256-69c6-4807-8fec-390f93b576bd"), "80" },
                    { new Guid("1d333eda-d587-4b30-81db-fe38648775ca"), new Guid("8c7c863a-698a-4fde-88ef-694bdc96888f"), new Guid("f856760d-adf9-4b4b-92e1-c1ae3bef024a"), "Czechia" },
                    { new Guid("3f6d2d52-719a-4a74-8c52-49c6af7e4ecd"), new Guid("d0922abc-25f0-4212-8826-18e09d836031"), new Guid("8871a182-6d18-4771-b7c7-2e51a578dd63"), "35" },
                    { new Guid("937631da-649f-4b71-8504-0dc661a71b9c"), new Guid("8c7c863a-698a-4fde-88ef-694bdc96888f"), new Guid("8871a182-6d18-4771-b7c7-2e51a578dd63"), "Puerto Rico" },
                    { new Guid("cb0e5e09-c144-41ad-b0ce-c5b8737ebc62"), new Guid("b11c52c0-de12-41f2-a4e7-6359c1153e1d"), new Guid("6f0c16b1-bd61-48dc-8a84-3ee880b92056"), "100" },
                    { new Guid("ce75b7c5-d24a-4651-a15d-c27f32e4c072"), new Guid("d0922abc-25f0-4212-8826-18e09d836031"), new Guid("f856760d-adf9-4b4b-92e1-c1ae3bef024a"), "25" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock", "Type" },
                values: new object[,]
                {
                    { new Guid("5a4a79d8-ebef-4dff-86b3-c44cbad12963"), new Guid("efe159cf-270e-49c0-958a-690cdbf7378e"), new Guid("b74f93cd-3b63-4c64-b0e9-8d893f50a5c8"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino", 5, 0 },
                    { new Guid("fb16fe40-65de-447a-9766-708884d0d11a"), new Guid("efe159cf-270e-49c0-958a-690cdbf7378e"), new Guid("70fba05c-7346-4e55-bff0-0789f89421cc"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino", 1, 0 }
                });
        }
    }
}
