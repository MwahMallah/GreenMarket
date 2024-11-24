using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AttributesMightBeRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsRequired",
                table: "Attributes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[] { new Guid("bbc7e8fa-fd75-43e7-8368-75275aeb0fbf"), null, "Crops", null, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("03eee7bf-1484-4a03-bc0d-e4d8adad3347"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("35482da9-c651-4a7d-8e59-bcac4b324486"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" },
                    { new Guid("6da400c4-d733-454f-ba1c-98d63fe6d49c"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("ac9f0bbc-5866-4b03-b2cd-266423ca0924"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("bd9aa7a3-e5a0-4546-a629-912fa21fad9c"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("2568ec40-635f-4177-9ea3-a545a0694dc8"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("bbc7e8fa-fd75-43e7-8368-75275aeb0fbf"), 0 },
                    { new Guid("c1ebe657-6142-45d6-a6c0-6c1e8d8d74ef"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("bbc7e8fa-fd75-43e7-8368-75275aeb0fbf"), 0 },
                    { new Guid("4c759a41-5825-46df-8add-ed560dfed63d"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("2568ec40-635f-4177-9ea3-a545a0694dc8"), 0 },
                    { new Guid("84a91178-0b63-45b6-8dc6-43d763103ae5"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("c1ebe657-6142-45d6-a6c0-6c1e8d8d74ef"), 0 },
                    { new Guid("d6cf4c3e-3fef-4fe7-a296-2f101a7a14b8"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("2568ec40-635f-4177-9ea3-a545a0694dc8"), 0 },
                    { new Guid("fbf485af-580c-44f0-bf11-fdfc8e96fd4b"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("c1ebe657-6142-45d6-a6c0-6c1e8d8d74ef"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "IsRequired", "Name" },
                values: new object[,]
                {
                    { new Guid("57d051f6-1ef7-4913-914d-5482b9b79d00"), new Guid("fbf485af-580c-44f0-bf11-fdfc8e96fd4b"), false, "Price/kg" },
                    { new Guid("83869cb1-e2f1-4414-9ae8-c8e452864777"), new Guid("d6cf4c3e-3fef-4fe7-a296-2f101a7a14b8"), false, "Place of origin" },
                    { new Guid("a023a0ee-0f5a-48ca-b8d4-f4c794e70ef6"), new Guid("d6cf4c3e-3fef-4fe7-a296-2f101a7a14b8"), false, "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { new Guid("aac9f1ec-8960-4e7a-8b99-f7787dc78058"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("84a91178-0b63-45b6-8dc6-43d763103ae5"), 0 },
                    { new Guid("d4afea69-f402-40ca-bc67-7d48a78f866c"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("84a91178-0b63-45b6-8dc6-43d763103ae5"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock", "Type" },
                values: new object[,]
                {
                    { new Guid("02c3db96-0eb0-43ad-b4d5-51b20b041bad"), new Guid("fbf485af-580c-44f0-bf11-fdfc8e96fd4b"), new Guid("ac9f0bbc-5866-4b03-b2cd-266423ca0924"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet", 4, 0 },
                    { new Guid("06b6592a-1214-460c-8556-8902dd44b4df"), new Guid("4c759a41-5825-46df-8add-ed560dfed63d"), new Guid("bd9aa7a3-e5a0-4546-a629-912fa21fad9c"), null, null, "Augusta", 2, 0 },
                    { new Guid("1cedff0d-f76f-45d9-bf8e-636028c21dc5"), new Guid("4c759a41-5825-46df-8add-ed560dfed63d"), new Guid("bd9aa7a3-e5a0-4546-a629-912fa21fad9c"), null, null, "Happy family", 10, 0 },
                    { new Guid("3ddcf5ab-c095-42fa-b2dc-c818bbb9c30d"), new Guid("d6cf4c3e-3fef-4fe7-a296-2f101a7a14b8"), new Guid("03eee7bf-1484-4a03-bc0d-e4d8adad3347"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen", 5, 0 },
                    { new Guid("6479d51d-4fee-44e8-83f4-c8bb17efb8da"), new Guid("4c759a41-5825-46df-8add-ed560dfed63d"), new Guid("bd9aa7a3-e5a0-4546-a629-912fa21fad9c"), null, null, "Dragon King", 3, 0 },
                    { new Guid("88d865df-20d0-4d8a-a965-6db17abc96bd"), new Guid("fbf485af-580c-44f0-bf11-fdfc8e96fd4b"), new Guid("ac9f0bbc-5866-4b03-b2cd-266423ca0924"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet", 3, 0 },
                    { new Guid("9478d6fa-0a96-4c15-bf3c-a5a1651311bd"), new Guid("d6cf4c3e-3fef-4fe7-a296-2f101a7a14b8"), new Guid("ac9f0bbc-5866-4b03-b2cd-266423ca0924"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte", 11, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("1646a4f6-ca7d-42fe-93ce-ecd955a3febc"), new Guid("57d051f6-1ef7-4913-914d-5482b9b79d00"), new Guid("88d865df-20d0-4d8a-a965-6db17abc96bd"), "80" },
                    { new Guid("2b08d228-2ad8-4d02-be12-3363a5cf592d"), new Guid("a023a0ee-0f5a-48ca-b8d4-f4c794e70ef6"), new Guid("3ddcf5ab-c095-42fa-b2dc-c818bbb9c30d"), "35" },
                    { new Guid("3b86c80c-0b06-40c7-af39-219d953af86f"), new Guid("83869cb1-e2f1-4414-9ae8-c8e452864777"), new Guid("9478d6fa-0a96-4c15-bf3c-a5a1651311bd"), "Czechia" },
                    { new Guid("887a711c-53e1-4691-a7c5-5d9dafb18006"), new Guid("57d051f6-1ef7-4913-914d-5482b9b79d00"), new Guid("02c3db96-0eb0-43ad-b4d5-51b20b041bad"), "100" },
                    { new Guid("8a006f3d-45ad-4b1e-bbea-98b09fba0795"), new Guid("a023a0ee-0f5a-48ca-b8d4-f4c794e70ef6"), new Guid("9478d6fa-0a96-4c15-bf3c-a5a1651311bd"), "25" },
                    { new Guid("c05ef69c-f635-42f6-bbd8-e3936f1315fc"), new Guid("83869cb1-e2f1-4414-9ae8-c8e452864777"), new Guid("3ddcf5ab-c095-42fa-b2dc-c818bbb9c30d"), "Puerto Rico" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock", "Type" },
                values: new object[,]
                {
                    { new Guid("3d17c780-6059-4156-ae24-256a863decbd"), new Guid("aac9f1ec-8960-4e7a-8b99-f7787dc78058"), new Guid("35482da9-c651-4a7d-8e59-bcac4b324486"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino", 1, 0 },
                    { new Guid("9b9a27a2-4d2b-485f-a710-353f64171891"), new Guid("aac9f1ec-8960-4e7a-8b99-f7787dc78058"), new Guid("bd9aa7a3-e5a0-4546-a629-912fa21fad9c"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino", 5, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d4afea69-f402-40ca-bc67-7d48a78f866c"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("1646a4f6-ca7d-42fe-93ce-ecd955a3febc"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("2b08d228-2ad8-4d02-be12-3363a5cf592d"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3b86c80c-0b06-40c7-af39-219d953af86f"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("887a711c-53e1-4691-a7c5-5d9dafb18006"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("8a006f3d-45ad-4b1e-bbea-98b09fba0795"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("c05ef69c-f635-42f6-bbd8-e3936f1315fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06b6592a-1214-460c-8556-8902dd44b4df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cedff0d-f76f-45d9-bf8e-636028c21dc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d17c780-6059-4156-ae24-256a863decbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6479d51d-4fee-44e8-83f4-c8bb17efb8da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b9a27a2-4d2b-485f-a710-353f64171891"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6da400c4-d733-454f-ba1c-98d63fe6d49c"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("57d051f6-1ef7-4913-914d-5482b9b79d00"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("83869cb1-e2f1-4414-9ae8-c8e452864777"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("a023a0ee-0f5a-48ca-b8d4-f4c794e70ef6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c759a41-5825-46df-8add-ed560dfed63d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aac9f1ec-8960-4e7a-8b99-f7787dc78058"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02c3db96-0eb0-43ad-b4d5-51b20b041bad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ddcf5ab-c095-42fa-b2dc-c818bbb9c30d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88d865df-20d0-4d8a-a965-6db17abc96bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9478d6fa-0a96-4c15-bf3c-a5a1651311bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35482da9-c651-4a7d-8e59-bcac4b324486"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd9aa7a3-e5a0-4546-a629-912fa21fad9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84a91178-0b63-45b6-8dc6-43d763103ae5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6cf4c3e-3fef-4fe7-a296-2f101a7a14b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbf485af-580c-44f0-bf11-fdfc8e96fd4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03eee7bf-1484-4a03-bc0d-e4d8adad3347"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac9f0bbc-5866-4b03-b2cd-266423ca0924"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2568ec40-635f-4177-9ea3-a545a0694dc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1ebe657-6142-45d6-a6c0-6c1e8d8d74ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbc7e8fa-fd75-43e7-8368-75275aeb0fbf"));

            migrationBuilder.DropColumn(
                name: "IsRequired",
                table: "Attributes");

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
        }
    }
}
