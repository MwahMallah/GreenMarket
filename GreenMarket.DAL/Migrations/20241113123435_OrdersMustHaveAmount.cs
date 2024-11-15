using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class OrdersMustHaveAmount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56b23361-63b4-4350-9d26-7b171d124fa1"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("329e413f-9ecc-4334-8ae0-e870bfc1b04d"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("40e79707-b593-49d4-b4b0-2b2e99db90c7"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("5404bcfe-524f-4a48-9094-d8f3d610d166"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("989da880-638d-4dc8-8702-736ec300deb4"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("a1359a43-5ccb-4817-a7b5-53a107601590"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("b296d7f2-462d-410b-b334-633fd9842370"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("111564bf-fb41-4cea-a4a6-57163b556bc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11de49d9-02e5-4579-954e-292886e8ef24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d052270-2acb-464e-9d3a-f15bf783dc42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("667e843d-55c6-4578-a256-fb9e13f840de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c074eb75-9001-4751-8243-474056bac4b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("123d820e-0370-46b3-bcbe-2533ae827f3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fd058b3-67fe-44ae-888e-bf5e61b9c56e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53326aa6-ac0d-4d0a-9dba-6d7b81f8afcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95b80d06-26ec-4548-b91b-0aab60fafdad"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("0860d0d6-ee3b-4d91-aef4-ea2196f064fb"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("0cc0e867-b665-451c-a936-9a0780a3a743"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("2689e37e-9e42-4a7e-a6ce-c75837656db3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe178c93-c4a1-4611-ada0-adee0b667774"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a0ae124-c596-4617-b6fe-0a256cca1299"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a46ce5f8-687d-4352-93d5-912054bbf5be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6429f65-f01f-4254-991f-5585b2ac0f3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea1841fd-f21e-4c81-9c56-6dec9e982ec7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3afff307-668b-41dc-93e0-b2e5cabc8e1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72e32323-a893-4523-8c67-855fb5db1f4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1d2afd0-3156-4477-ba4c-fc77e2b9a994"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("364c8816-277c-462d-a872-320aa47d20b2"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("bb034bf2-76be-4b77-a7d7-a215cdb533cd"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3a94c7d7-2460-46e2-a93b-530341af2ff3"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("58bc5fa6-b25a-4d29-a30d-e2ec59639dd3"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("e0ecb2cc-21f8-4229-be28-84477b39c384"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("f4a2bcee-845d-48f4-a6ca-3066ba33b15e"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("2c2fc6e6-eb91-47ec-a553-cc768f6508ff"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("bb034bf2-76be-4b77-a7d7-a215cdb533cd") },
                    { new Guid("c3f8d5cf-8c55-4e26-a890-5c6d6aa38d2d"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("bb034bf2-76be-4b77-a7d7-a215cdb533cd") },
                    { new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("c3f8d5cf-8c55-4e26-a890-5c6d6aa38d2d") },
                    { new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("2c2fc6e6-eb91-47ec-a553-cc768f6508ff") },
                    { new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("2c2fc6e6-eb91-47ec-a553-cc768f6508ff") },
                    { new Guid("bd2a0ab3-d940-4e82-83e0-1234b22c15e0"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("c3f8d5cf-8c55-4e26-a890-5c6d6aa38d2d") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("3ac5e66e-75a0-46da-8f4b-b82fd750c710"), new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"), "Price/kg" },
                    { new Guid("b06d1604-d958-46fe-beac-a7e63cd5243a"), new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "Place of origin" },
                    { new Guid("cd8c1701-c3ed-436e-be59-6e47f15358e2"), new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("6dd81d26-12e8-49bb-9be6-749593da15df"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("bd2a0ab3-d940-4e82-83e0-1234b22c15e0") },
                    { new Guid("8d009112-918d-479e-bec5-46bc08310b1c"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("bd2a0ab3-d940-4e82-83e0-1234b22c15e0") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("0aa15e4e-1ce5-44b0-b234-bf100e0ebcd5"), new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"), null, null, "Happy family" },
                    { new Guid("12b9aa1e-8d9a-49e3-ae0c-2f018378e882"), new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("27cec6b1-3584-48b5-b2d8-9c19c6d59673"), new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"), null, null, "Augusta" },
                    { new Guid("5d292fc0-d93b-44fd-b764-d2ca42ff30c0"), new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"), null, null, "Dragon King" },
                    { new Guid("621fb335-8cbf-4594-8b36-437981e8c8e2"), new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("74c7e97b-c13e-4136-a889-34b3f04485c3"), new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("891ec03e-4425-4207-9322-f4d71f017341"), new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("12c30319-5d71-4302-b129-dc4c90e0ce56"), new Guid("b06d1604-d958-46fe-beac-a7e63cd5243a"), new Guid("621fb335-8cbf-4594-8b36-437981e8c8e2"), "Puerto Rico" },
                    { new Guid("14dca921-49c6-423a-8f03-96c72463d793"), new Guid("b06d1604-d958-46fe-beac-a7e63cd5243a"), new Guid("74c7e97b-c13e-4136-a889-34b3f04485c3"), "Czechia" },
                    { new Guid("1ab9ccd9-7c68-40f6-bf7a-9f110d678c02"), new Guid("cd8c1701-c3ed-436e-be59-6e47f15358e2"), new Guid("74c7e97b-c13e-4136-a889-34b3f04485c3"), "25" },
                    { new Guid("3009c2de-a4f7-4bed-86c2-99a545437f30"), new Guid("3ac5e66e-75a0-46da-8f4b-b82fd750c710"), new Guid("891ec03e-4425-4207-9322-f4d71f017341"), "100" },
                    { new Guid("e771ce0b-8c02-49f2-8a4f-c42645ba0e84"), new Guid("cd8c1701-c3ed-436e-be59-6e47f15358e2"), new Guid("621fb335-8cbf-4594-8b36-437981e8c8e2"), "35" },
                    { new Guid("ff82e93d-c5cc-4493-b667-8253638111a4"), new Guid("3ac5e66e-75a0-46da-8f4b-b82fd750c710"), new Guid("12b9aa1e-8d9a-49e3-ae0c-2f018378e882"), "80" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("217f09bd-7ff3-47f2-b8e7-8afaa68ede05"), new Guid("6dd81d26-12e8-49bb-9be6-749593da15df"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" },
                    { new Guid("86e3f8c1-90b1-4abe-938b-8a1976d6e3bf"), new Guid("6dd81d26-12e8-49bb-9be6-749593da15df"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d009112-918d-479e-bec5-46bc08310b1c"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("12c30319-5d71-4302-b129-dc4c90e0ce56"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("14dca921-49c6-423a-8f03-96c72463d793"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("1ab9ccd9-7c68-40f6-bf7a-9f110d678c02"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3009c2de-a4f7-4bed-86c2-99a545437f30"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("e771ce0b-8c02-49f2-8a4f-c42645ba0e84"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("ff82e93d-c5cc-4493-b667-8253638111a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aa15e4e-1ce5-44b0-b234-bf100e0ebcd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("217f09bd-7ff3-47f2-b8e7-8afaa68ede05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27cec6b1-3584-48b5-b2d8-9c19c6d59673"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d292fc0-d93b-44fd-b764-d2ca42ff30c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86e3f8c1-90b1-4abe-938b-8a1976d6e3bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a94c7d7-2460-46e2-a93b-530341af2ff3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58bc5fa6-b25a-4d29-a30d-e2ec59639dd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0ecb2cc-21f8-4229-be28-84477b39c384"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4a2bcee-845d-48f4-a6ca-3066ba33b15e"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("3ac5e66e-75a0-46da-8f4b-b82fd750c710"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("b06d1604-d958-46fe-beac-a7e63cd5243a"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("cd8c1701-c3ed-436e-be59-6e47f15358e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6dd81d26-12e8-49bb-9be6-749593da15df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b9aa1e-8d9a-49e3-ae0c-2f018378e882"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("621fb335-8cbf-4594-8b36-437981e8c8e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74c7e97b-c13e-4136-a889-34b3f04485c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("891ec03e-4425-4207-9322-f4d71f017341"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd2a0ab3-d940-4e82-83e0-1234b22c15e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c2fc6e6-eb91-47ec-a553-cc768f6508ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3f8d5cf-8c55-4e26-a890-5c6d6aa38d2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb034bf2-76be-4b77-a7d7-a215cdb533cd"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("364c8816-277c-462d-a872-320aa47d20b2"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("123d820e-0370-46b3-bcbe-2533ae827f3f"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("4fd058b3-67fe-44ae-888e-bf5e61b9c56e"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("53326aa6-ac0d-4d0a-9dba-6d7b81f8afcd"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("95b80d06-26ec-4548-b91b-0aab60fafdad"), "admin@admin.com", "", "admin", "admin", 0, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("72e32323-a893-4523-8c67-855fb5db1f4b"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("364c8816-277c-462d-a872-320aa47d20b2") },
                    { new Guid("a1d2afd0-3156-4477-ba4c-fc77e2b9a994"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("364c8816-277c-462d-a872-320aa47d20b2") },
                    { new Guid("3afff307-668b-41dc-93e0-b2e5cabc8e1e"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("a1d2afd0-3156-4477-ba4c-fc77e2b9a994") },
                    { new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("72e32323-a893-4523-8c67-855fb5db1f4b") },
                    { new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("72e32323-a893-4523-8c67-855fb5db1f4b") },
                    { new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("a1d2afd0-3156-4477-ba4c-fc77e2b9a994") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("0860d0d6-ee3b-4d91-aef4-ea2196f064fb"), new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"), "Price/piece" },
                    { new Guid("0cc0e867-b665-451c-a936-9a0780a3a743"), new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"), "Price/kg" },
                    { new Guid("2689e37e-9e42-4a7e-a6ce-c75837656db3"), new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"), "Place of origin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("56b23361-63b4-4350-9d26-7b171d124fa1"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("3afff307-668b-41dc-93e0-b2e5cabc8e1e") },
                    { new Guid("fe178c93-c4a1-4611-ada0-adee0b667774"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("3afff307-668b-41dc-93e0-b2e5cabc8e1e") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("111564bf-fb41-4cea-a4a6-57163b556bc4"), new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"), null, null, "Happy family" },
                    { new Guid("11de49d9-02e5-4579-954e-292886e8ef24"), new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"), null, null, "Dragon King" },
                    { new Guid("2a0ae124-c596-4617-b6fe-0a256cca1299"), new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("a46ce5f8-687d-4352-93d5-912054bbf5be"), new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("b6429f65-f01f-4254-991f-5585b2ac0f3e"), new Guid("ea98e822-96a9-40fb-b4f5-e425745416a7"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("c074eb75-9001-4751-8243-474056bac4b1"), new Guid("e30276b4-bf2c-4703-9000-8de97d7d9651"), null, null, "Augusta" },
                    { new Guid("ea1841fd-f21e-4c81-9c56-6dec9e982ec7"), new Guid("6c4d2201-14ce-4fc9-9c64-9d42f7e43617"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("329e413f-9ecc-4334-8ae0-e870bfc1b04d"), new Guid("0860d0d6-ee3b-4d91-aef4-ea2196f064fb"), new Guid("a46ce5f8-687d-4352-93d5-912054bbf5be"), "25" },
                    { new Guid("40e79707-b593-49d4-b4b0-2b2e99db90c7"), new Guid("0cc0e867-b665-451c-a936-9a0780a3a743"), new Guid("2a0ae124-c596-4617-b6fe-0a256cca1299"), "80" },
                    { new Guid("5404bcfe-524f-4a48-9094-d8f3d610d166"), new Guid("2689e37e-9e42-4a7e-a6ce-c75837656db3"), new Guid("ea1841fd-f21e-4c81-9c56-6dec9e982ec7"), "Puerto Rico" },
                    { new Guid("989da880-638d-4dc8-8702-736ec300deb4"), new Guid("2689e37e-9e42-4a7e-a6ce-c75837656db3"), new Guid("a46ce5f8-687d-4352-93d5-912054bbf5be"), "Czechia" },
                    { new Guid("a1359a43-5ccb-4817-a7b5-53a107601590"), new Guid("0cc0e867-b665-451c-a936-9a0780a3a743"), new Guid("b6429f65-f01f-4254-991f-5585b2ac0f3e"), "100" },
                    { new Guid("b296d7f2-462d-410b-b334-633fd9842370"), new Guid("0860d0d6-ee3b-4d91-aef4-ea2196f064fb"), new Guid("ea1841fd-f21e-4c81-9c56-6dec9e982ec7"), "35" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("2d052270-2acb-464e-9d3a-f15bf783dc42"), new Guid("fe178c93-c4a1-4611-ada0-adee0b667774"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" },
                    { new Guid("667e843d-55c6-4578-a256-fb9e13f840de"), new Guid("fe178c93-c4a1-4611-ada0-adee0b667774"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" }
                });
        }
    }
}
