using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserHasEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66af7baa-6236-49f3-b10f-279a307c42b0"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("4fe2d0db-6d93-4823-a3a2-482b63af49ad"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("5d22b041-c11a-4899-b86f-ee5e7399559a"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("9332d5d7-a068-407c-acf0-56069ff02bd2"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("96093249-374f-49b5-a9d7-9ccc507668a6"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("97ac0668-74f3-41b0-a644-de6bb2a9d671"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("af9b9317-9949-4486-94cf-c46b6c5a1e10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43f4b207-44da-4ad9-9280-5841cad94502"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bbbb864-f0cb-42ca-9f82-82f6d2cf144b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7fedb18-c5d0-417a-83c3-f1a6a3b21fc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbd31df9-3e72-4e13-baed-22bcfa40e516"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0eec32c-5a64-4e1d-b3c8-92020680a3fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e414630-2228-4faf-a11b-fc75fd2a344d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e86d34d-c7c8-4665-b816-b4878aa2c352"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a60820ba-4626-4e9c-9f17-f69f8bb371c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d073c88d-d465-4bb8-8a34-29167c61849d"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("395e9bc6-aafd-4f52-bbab-834803408b8b"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("51a0e0c6-e315-46ce-baf5-83105471c3ff"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("e6695d38-fda3-4b1b-bfd1-7a806785b699"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0744237a-7314-4ffc-ae56-1d16df46f398"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b1cd1ab-6241-4669-962c-594d37592ea8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b6e7684-fb43-45fd-84de-3592e17f1625"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("380c2e73-ddfb-4e43-8262-18e6897ed6c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40337c8c-ecd7-4233-b4fb-520633fea4a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47016abc-bd18-4cbd-9ae8-6e7b72bc4942"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4be7c950-de0a-4364-814a-06fef0a15394"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ea9a8a2-8aa4-4cf5-9231-8d02927be5d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c01364df-cb79-493d-8f7b-fc6c2d7021f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56a91102-8ba8-44d3-a50c-494e3b887a87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dce96ee5-acd2-4882-bd74-2c4dcafb08a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37190e52-d346-45c2-9802-d69afa0cbaaa"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("a2f01217-7613-4ea0-ab8a-99c7387e07eb"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("534ad097-4625-48e8-b282-318c28fc3659"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("62074683-bbec-4517-886d-b3f4d1309220"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("68302f22-48b3-43bd-8d24-e437a7ecefa2"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("e4ad09a4-2e33-4b42-9a17-7dc56b476f85"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("54dd6a4d-3a0b-4839-9d84-0ec448e51089"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("a2f01217-7613-4ea0-ab8a-99c7387e07eb") },
                    { new Guid("86a0bb8f-e8a7-4fa3-9cc0-32d9e3963692"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("a2f01217-7613-4ea0-ab8a-99c7387e07eb") },
                    { new Guid("1ae0821c-2e0f-4913-b8db-f588ff905440"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("86a0bb8f-e8a7-4fa3-9cc0-32d9e3963692") },
                    { new Guid("c3c112bb-3b50-450b-8f8a-da43ac5394f2"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("86a0bb8f-e8a7-4fa3-9cc0-32d9e3963692") },
                    { new Guid("d0985289-73fb-4bb5-b787-0c882aa7c22a"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("54dd6a4d-3a0b-4839-9d84-0ec448e51089") },
                    { new Guid("e3afbf08-0276-43d2-aa46-5f342dfd2192"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("54dd6a4d-3a0b-4839-9d84-0ec448e51089") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("0336287c-9b03-4746-9fa5-cf0702c59cde"), new Guid("c3c112bb-3b50-450b-8f8a-da43ac5394f2"), "Place of origin" },
                    { new Guid("a8c9ef1b-e432-4b00-9a28-bab9b760c419"), new Guid("e3afbf08-0276-43d2-aa46-5f342dfd2192"), "Price/kg" },
                    { new Guid("bb3252fd-4104-4c2d-b8cf-36a22eb5c716"), new Guid("c3c112bb-3b50-450b-8f8a-da43ac5394f2"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("6e01217d-dcc7-4752-b235-56765b2444f4"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("d0985289-73fb-4bb5-b787-0c882aa7c22a") },
                    { new Guid("dee4ac56-fe26-49b5-8fe1-6605d75ec796"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("d0985289-73fb-4bb5-b787-0c882aa7c22a") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("126bc378-565a-4ab0-8843-7566b3c543ad"), new Guid("c3c112bb-3b50-450b-8f8a-da43ac5394f2"), "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("83c9ece9-8313-41e8-ae90-ae19e5c5c0cf"), new Guid("c3c112bb-3b50-450b-8f8a-da43ac5394f2"), "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("a30dedd2-29ba-412a-ad21-87e3a1ec558e"), new Guid("1ae0821c-2e0f-4913-b8db-f588ff905440"), null, "Happy family" },
                    { new Guid("a8ab89ca-fcd0-43b7-9a11-1e0dfe0506ae"), new Guid("e3afbf08-0276-43d2-aa46-5f342dfd2192"), "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("c03ed4c1-6f90-4e5f-9ac2-8959c9b88e13"), new Guid("1ae0821c-2e0f-4913-b8db-f588ff905440"), null, "Dragon King" },
                    { new Guid("c24b432c-ef75-409e-aec4-abb6eef91aa4"), new Guid("e3afbf08-0276-43d2-aa46-5f342dfd2192"), "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("f6ade432-67d9-4bdb-a241-cf1382db0200"), new Guid("1ae0821c-2e0f-4913-b8db-f588ff905440"), null, "Augusta" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("0277ab13-ba0e-4e3e-9d7d-12e4f677b057"), new Guid("0336287c-9b03-4746-9fa5-cf0702c59cde"), new Guid("126bc378-565a-4ab0-8843-7566b3c543ad"), "Czechia" },
                    { new Guid("1a9c93c6-04ec-4034-bba3-1cbbdda02588"), new Guid("a8c9ef1b-e432-4b00-9a28-bab9b760c419"), new Guid("a8ab89ca-fcd0-43b7-9a11-1e0dfe0506ae"), "100" },
                    { new Guid("484ea012-0eeb-43cb-ac3e-4538ccc21934"), new Guid("0336287c-9b03-4746-9fa5-cf0702c59cde"), new Guid("83c9ece9-8313-41e8-ae90-ae19e5c5c0cf"), "Puerto Rico" },
                    { new Guid("8284f93e-44c6-41f8-a80c-48f7fb9e18cf"), new Guid("bb3252fd-4104-4c2d-b8cf-36a22eb5c716"), new Guid("126bc378-565a-4ab0-8843-7566b3c543ad"), "25" },
                    { new Guid("c7cf8279-ae84-40c8-836d-74bf88662c4d"), new Guid("a8c9ef1b-e432-4b00-9a28-bab9b760c419"), new Guid("c24b432c-ef75-409e-aec4-abb6eef91aa4"), "80" },
                    { new Guid("cbb8b1be-c74e-4859-9cc2-4c20cd63b6ab"), new Guid("bb3252fd-4104-4c2d-b8cf-36a22eb5c716"), new Guid("83c9ece9-8313-41e8-ae90-ae19e5c5c0cf"), "35" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("c285dd83-0da6-4452-9728-45d6fc713c55"), new Guid("6e01217d-dcc7-4752-b235-56765b2444f4"), null, "Ilya's sweet tomino" },
                    { new Guid("c96e9b4d-ed9c-4771-9068-16d2bc781a3c"), new Guid("6e01217d-dcc7-4752-b235-56765b2444f4"), null, "Anton's tasty tomino" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dee4ac56-fe26-49b5-8fe1-6605d75ec796"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("0277ab13-ba0e-4e3e-9d7d-12e4f677b057"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("1a9c93c6-04ec-4034-bba3-1cbbdda02588"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("484ea012-0eeb-43cb-ac3e-4538ccc21934"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("8284f93e-44c6-41f8-a80c-48f7fb9e18cf"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("c7cf8279-ae84-40c8-836d-74bf88662c4d"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("cbb8b1be-c74e-4859-9cc2-4c20cd63b6ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a30dedd2-29ba-412a-ad21-87e3a1ec558e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c03ed4c1-6f90-4e5f-9ac2-8959c9b88e13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c285dd83-0da6-4452-9728-45d6fc713c55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c96e9b4d-ed9c-4771-9068-16d2bc781a3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6ade432-67d9-4bdb-a241-cf1382db0200"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("534ad097-4625-48e8-b282-318c28fc3659"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62074683-bbec-4517-886d-b3f4d1309220"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68302f22-48b3-43bd-8d24-e437a7ecefa2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4ad09a4-2e33-4b42-9a17-7dc56b476f85"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("0336287c-9b03-4746-9fa5-cf0702c59cde"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("a8c9ef1b-e432-4b00-9a28-bab9b760c419"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("bb3252fd-4104-4c2d-b8cf-36a22eb5c716"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ae0821c-2e0f-4913-b8db-f588ff905440"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e01217d-dcc7-4752-b235-56765b2444f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("126bc378-565a-4ab0-8843-7566b3c543ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83c9ece9-8313-41e8-ae90-ae19e5c5c0cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8ab89ca-fcd0-43b7-9a11-1e0dfe0506ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c24b432c-ef75-409e-aec4-abb6eef91aa4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3c112bb-3b50-450b-8f8a-da43ac5394f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0985289-73fb-4bb5-b787-0c882aa7c22a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3afbf08-0276-43d2-aa46-5f342dfd2192"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54dd6a4d-3a0b-4839-9d84-0ec448e51089"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86a0bb8f-e8a7-4fa3-9cc0-32d9e3963692"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2f01217-7613-4ea0-ab8a-99c7387e07eb"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("37190e52-d346-45c2-9802-d69afa0cbaaa"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("1e414630-2228-4faf-a11b-fc75fd2a344d"), "", "admin", "admin", 0, "admin" },
                    { new Guid("7e86d34d-c7c8-4665-b816-b4878aa2c352"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("a60820ba-4626-4e9c-9f17-f69f8bb371c0"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("d073c88d-d465-4bb8-8a34-29167c61849d"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("56a91102-8ba8-44d3-a50c-494e3b887a87"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("37190e52-d346-45c2-9802-d69afa0cbaaa") },
                    { new Guid("dce96ee5-acd2-4882-bd74-2c4dcafb08a6"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("37190e52-d346-45c2-9802-d69afa0cbaaa") },
                    { new Guid("4be7c950-de0a-4364-814a-06fef0a15394"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("dce96ee5-acd2-4882-bd74-2c4dcafb08a6") },
                    { new Guid("5b1cd1ab-6241-4669-962c-594d37592ea8"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("56a91102-8ba8-44d3-a50c-494e3b887a87") },
                    { new Guid("5ea9a8a2-8aa4-4cf5-9231-8d02927be5d6"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("dce96ee5-acd2-4882-bd74-2c4dcafb08a6") },
                    { new Guid("c01364df-cb79-493d-8f7b-fc6c2d7021f6"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("56a91102-8ba8-44d3-a50c-494e3b887a87") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("395e9bc6-aafd-4f52-bbab-834803408b8b"), new Guid("c01364df-cb79-493d-8f7b-fc6c2d7021f6"), "Price/piece" },
                    { new Guid("51a0e0c6-e315-46ce-baf5-83105471c3ff"), new Guid("5ea9a8a2-8aa4-4cf5-9231-8d02927be5d6"), "Price/kg" },
                    { new Guid("e6695d38-fda3-4b1b-bfd1-7a806785b699"), new Guid("c01364df-cb79-493d-8f7b-fc6c2d7021f6"), "Place of origin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("0744237a-7314-4ffc-ae56-1d16df46f398"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("4be7c950-de0a-4364-814a-06fef0a15394") },
                    { new Guid("66af7baa-6236-49f3-b10f-279a307c42b0"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("4be7c950-de0a-4364-814a-06fef0a15394") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("1b6e7684-fb43-45fd-84de-3592e17f1625"), new Guid("5ea9a8a2-8aa4-4cf5-9231-8d02927be5d6"), "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("380c2e73-ddfb-4e43-8262-18e6897ed6c7"), new Guid("c01364df-cb79-493d-8f7b-fc6c2d7021f6"), "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("40337c8c-ecd7-4233-b4fb-520633fea4a3"), new Guid("5ea9a8a2-8aa4-4cf5-9231-8d02927be5d6"), "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("43f4b207-44da-4ad9-9280-5841cad94502"), new Guid("5b1cd1ab-6241-4669-962c-594d37592ea8"), null, "Augusta" },
                    { new Guid("47016abc-bd18-4cbd-9ae8-6e7b72bc4942"), new Guid("c01364df-cb79-493d-8f7b-fc6c2d7021f6"), "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("9bbbb864-f0cb-42ca-9f82-82f6d2cf144b"), new Guid("5b1cd1ab-6241-4669-962c-594d37592ea8"), null, "Dragon King" },
                    { new Guid("b7fedb18-c5d0-417a-83c3-f1a6a3b21fc0"), new Guid("5b1cd1ab-6241-4669-962c-594d37592ea8"), null, "Happy family" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("4fe2d0db-6d93-4823-a3a2-482b63af49ad"), new Guid("51a0e0c6-e315-46ce-baf5-83105471c3ff"), new Guid("40337c8c-ecd7-4233-b4fb-520633fea4a3"), "80" },
                    { new Guid("5d22b041-c11a-4899-b86f-ee5e7399559a"), new Guid("51a0e0c6-e315-46ce-baf5-83105471c3ff"), new Guid("1b6e7684-fb43-45fd-84de-3592e17f1625"), "100" },
                    { new Guid("9332d5d7-a068-407c-acf0-56069ff02bd2"), new Guid("395e9bc6-aafd-4f52-bbab-834803408b8b"), new Guid("380c2e73-ddfb-4e43-8262-18e6897ed6c7"), "25" },
                    { new Guid("96093249-374f-49b5-a9d7-9ccc507668a6"), new Guid("e6695d38-fda3-4b1b-bfd1-7a806785b699"), new Guid("380c2e73-ddfb-4e43-8262-18e6897ed6c7"), "Czechia" },
                    { new Guid("97ac0668-74f3-41b0-a644-de6bb2a9d671"), new Guid("e6695d38-fda3-4b1b-bfd1-7a806785b699"), new Guid("47016abc-bd18-4cbd-9ae8-6e7b72bc4942"), "Puerto Rico" },
                    { new Guid("af9b9317-9949-4486-94cf-c46b6c5a1e10"), new Guid("395e9bc6-aafd-4f52-bbab-834803408b8b"), new Guid("47016abc-bd18-4cbd-9ae8-6e7b72bc4942"), "35" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("bbd31df9-3e72-4e13-baed-22bcfa40e516"), new Guid("0744237a-7314-4ffc-ae56-1d16df46f398"), null, "Ilya's sweet tomino" },
                    { new Guid("d0eec32c-5a64-4e1d-b3c8-92020680a3fa"), new Guid("0744237a-7314-4ffc-ae56-1d16df46f398"), null, "Anton's tasty tomino" }
                });
        }
    }
}
