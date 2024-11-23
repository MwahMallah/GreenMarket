using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductSalesType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Products");

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
        }
    }
}
