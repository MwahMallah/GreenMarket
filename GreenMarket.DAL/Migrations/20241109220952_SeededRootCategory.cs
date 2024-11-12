using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeededRootCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7de0bead-7c07-424f-9b4c-e9ee635f286f"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("169d6b58-b2ba-4794-8bc8-b87d5d4e3996"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("284428e7-2722-4fa4-8eea-5c3f18637ad2"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("2b8f0ec2-85bc-483b-9b94-e0c0a40ce5fd"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("62893e41-ed5e-4336-8bf3-6c431e4fd087"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("77523386-71b2-4f53-9943-9595dfa705d8"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("aba7819d-9376-40ff-b1bd-375522fd6573"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27b08ca3-0f0f-4227-ac35-059bcbd0fa1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("344d3dac-c46e-4d5b-9d90-054313fd9ce4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d0878e3-c29e-4508-baa3-5f60a5c38c05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a21fa001-5e64-4068-8fb5-503b80c5b13a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e479bdab-fbb8-418e-ac8a-09853ff8d9b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bb33bd1-2115-4079-b6c1-846f8dda38f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c0fa408-8251-4af4-a44b-71d6c0f9d3af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58cb733e-09a0-4c0a-9ea0-d5454a0bd412"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a98078c-638a-459a-a655-883723aa86cc"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("3a31d67e-cc7d-4f8c-88c4-739ab207579a"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("67eea8a0-75d7-4bed-b315-3f2be54b064f"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("77846595-b425-4a0f-8ffb-c2b5cd801813"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce9dc4e8-a8ee-4108-98e3-cc0eeb3069d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bd5bf62-4c93-452c-b01b-cf1683d403d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("406cd876-95d1-4927-8dcf-3939c5c6e118"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("711c25d4-f26d-4c5f-8fb5-ed87a15649fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("845a5390-b34d-4976-ae48-cf47b5b03c13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24f0c013-af0f-4820-be11-c380c08c118a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f3b5de3-3cca-4745-a9bd-867916bbc5c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bfe124e-80da-4247-81ee-cf3bdd4b06c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f417d380-b235-441a-b866-8eff5718ca7a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("7bfe124e-80da-4247-81ee-cf3bdd4b06c2"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", null },
                    { new Guid("f417d380-b235-441a-b866-8eff5718ca7a"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("1bb33bd1-2115-4079-b6c1-846f8dda38f7"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("3c0fa408-8251-4af4-a44b-71d6c0f9d3af"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("58cb733e-09a0-4c0a-9ea0-d5454a0bd412"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("9a98078c-638a-459a-a655-883723aa86cc"), "", "admin", "admin", 0, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("24f0c013-af0f-4820-be11-c380c08c118a"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("f417d380-b235-441a-b866-8eff5718ca7a") },
                    { new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("7bfe124e-80da-4247-81ee-cf3bdd4b06c2") },
                    { new Guid("9f3b5de3-3cca-4745-a9bd-867916bbc5c3"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("f417d380-b235-441a-b866-8eff5718ca7a") },
                    { new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("7bfe124e-80da-4247-81ee-cf3bdd4b06c2") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("3a31d67e-cc7d-4f8c-88c4-739ab207579a"), new Guid("24f0c013-af0f-4820-be11-c380c08c118a"), "Price/kg" },
                    { new Guid("67eea8a0-75d7-4bed-b315-3f2be54b064f"), new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"), "Price/piece" },
                    { new Guid("77846595-b425-4a0f-8ffb-c2b5cd801813"), new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"), "Place of origin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("7de0bead-7c07-424f-9b4c-e9ee635f286f"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("9f3b5de3-3cca-4745-a9bd-867916bbc5c3") },
                    { new Guid("ce9dc4e8-a8ee-4108-98e3-cc0eeb3069d7"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("9f3b5de3-3cca-4745-a9bd-867916bbc5c3") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("27b08ca3-0f0f-4227-ac35-059bcbd0fa1e"), new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"), null, "Happy family" },
                    { new Guid("2bd5bf62-4c93-452c-b01b-cf1683d403d7"), new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"), "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("344d3dac-c46e-4d5b-9d90-054313fd9ce4"), new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"), null, "Augusta" },
                    { new Guid("406cd876-95d1-4927-8dcf-3939c5c6e118"), new Guid("24f0c013-af0f-4820-be11-c380c08c118a"), "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("6d0878e3-c29e-4508-baa3-5f60a5c38c05"), new Guid("59c67673-ecbc-4ea5-b20c-62997634df9a"), null, "Dragon King" },
                    { new Guid("711c25d4-f26d-4c5f-8fb5-ed87a15649fd"), new Guid("24f0c013-af0f-4820-be11-c380c08c118a"), "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("845a5390-b34d-4976-ae48-cf47b5b03c13"), new Guid("e6bdc612-6a95-467a-949a-745c6b972cf0"), "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("169d6b58-b2ba-4794-8bc8-b87d5d4e3996"), new Guid("3a31d67e-cc7d-4f8c-88c4-739ab207579a"), new Guid("406cd876-95d1-4927-8dcf-3939c5c6e118"), "100" },
                    { new Guid("284428e7-2722-4fa4-8eea-5c3f18637ad2"), new Guid("77846595-b425-4a0f-8ffb-c2b5cd801813"), new Guid("845a5390-b34d-4976-ae48-cf47b5b03c13"), "Czechia" },
                    { new Guid("2b8f0ec2-85bc-483b-9b94-e0c0a40ce5fd"), new Guid("77846595-b425-4a0f-8ffb-c2b5cd801813"), new Guid("2bd5bf62-4c93-452c-b01b-cf1683d403d7"), "Puerto Rico" },
                    { new Guid("62893e41-ed5e-4336-8bf3-6c431e4fd087"), new Guid("3a31d67e-cc7d-4f8c-88c4-739ab207579a"), new Guid("711c25d4-f26d-4c5f-8fb5-ed87a15649fd"), "80" },
                    { new Guid("77523386-71b2-4f53-9943-9595dfa705d8"), new Guid("67eea8a0-75d7-4bed-b315-3f2be54b064f"), new Guid("845a5390-b34d-4976-ae48-cf47b5b03c13"), "25" },
                    { new Guid("aba7819d-9376-40ff-b1bd-375522fd6573"), new Guid("67eea8a0-75d7-4bed-b315-3f2be54b064f"), new Guid("2bd5bf62-4c93-452c-b01b-cf1683d403d7"), "35" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("a21fa001-5e64-4068-8fb5-503b80c5b13a"), new Guid("ce9dc4e8-a8ee-4108-98e3-cc0eeb3069d7"), null, "Ilya's sweet tomino" },
                    { new Guid("e479bdab-fbb8-418e-ac8a-09853ff8d9b0"), new Guid("ce9dc4e8-a8ee-4108-98e3-cc0eeb3069d7"), null, "Anton's tasty tomino" }
                });
        }
    }
}
