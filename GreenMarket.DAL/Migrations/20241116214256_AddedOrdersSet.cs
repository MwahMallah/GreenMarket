using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrdersSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrderEntity_Products_ProductId",
                table: "UserOrderEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrderEntity_Users_UserId",
                table: "UserOrderEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrderEntity",
                table: "UserOrderEntity");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3a07953-70b9-484f-8a8b-8d2abb5a6b6c"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("1ec9a31a-d605-401a-8421-8816116da6a1"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("47608fbe-5ee7-4dfa-a235-9720d499db38"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("7e2dc0f5-8f21-4053-87c2-1cbc7395e1d7"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("aea3df9f-5a3c-41e9-9083-06b3b15492cf"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("d727f2df-9738-4b55-be5b-9dfce9b0422b"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("e69c9426-26fa-4495-94b6-f9ccfb99c643"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17d019c8-f843-4862-ac8d-4e8f0178c1d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5734964b-2795-44c4-9d50-9330021f01c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a8f4539-e8ad-42ad-a3b1-b4bc9a6158c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0fa522e-44e9-424e-96e3-6a122d3d37aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3772a0b-a9ea-4021-ac3d-ea5a8b89e633"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f38dc0a4-4bc7-4a51-bec9-081e93293d05"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("c9a8cfb4-ccf6-4a71-87cc-53d2c2aef02f"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("d3bf03ab-dde3-4589-b2fb-3fc03136ded3"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("e7d6e430-d0d2-4269-8f05-7343f00fe5a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca0e8baf-8fc3-409f-8a9d-8c1434d0346e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f671e1b2-8458-444a-8514-f57a3c6fe237"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06cae850-677b-4211-bd7b-b9a53c4f291d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39bae4fb-4815-4a82-8c4e-f07ead19b1dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a55c4fc5-c6be-4e3c-ba53-0ff363ade203"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af20f764-9b87-414d-a346-b22b547a9e71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5adfa8d2-b83e-484d-9e5b-d6a70c6e04db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc199879-bf28-41a8-b516-97474f4eba8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44af0235-3c40-406a-a272-f7d9f419ecbd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cee4a73-5211-421a-8883-6bffb0df989c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7415626c-4270-454d-9842-4110b05cb73d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ea9dd00-18e5-48ed-a9db-cfcc0b1ced9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e885a7a1-8669-496d-b4ea-db47f69289b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de8b5b41-f5c4-486c-b228-24cb864d77af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e89145d9-7c92-479f-bfb3-d8a649d61065"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7260bd9-0108-417a-94c4-cffe5805a3b1"));

            migrationBuilder.RenameTable(
                name: "UserOrderEntity",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrderEntity_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrderEntity_ProductId",
                table: "Orders",
                newName: "IX_Orders_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("8c40a2a3-4350-4457-b456-ecc646f3e088"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("4f26fc25-0ea0-4067-af5d-38e2b31b8014"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("97272cb4-5292-48bd-b202-7987b4f76005"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("c09b09bb-a0ce-4a46-a9cd-08a3e1589fc5"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" },
                    { new Guid("d0a3d8cc-97d0-487d-abfe-abeeb95a638b"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("e8ab32d0-fcc4-4f08-9965-ef85957c2923"), "admin@admin.com", "", "admin", "admin", 0, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("77822156-6714-4693-ad6c-7bbbde21f358"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("8c40a2a3-4350-4457-b456-ecc646f3e088") },
                    { new Guid("dbe28711-64d4-4872-8184-d85c3fd785ab"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("8c40a2a3-4350-4457-b456-ecc646f3e088") },
                    { new Guid("5c02fbf0-8ab3-4b79-a2a9-f18d4c73b173"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("77822156-6714-4693-ad6c-7bbbde21f358") },
                    { new Guid("6d014c14-d00e-45a4-8766-7c20a96aa3a1"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("dbe28711-64d4-4872-8184-d85c3fd785ab") },
                    { new Guid("6d38e761-7116-492e-8ce2-6669261db1ba"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("dbe28711-64d4-4872-8184-d85c3fd785ab") },
                    { new Guid("eaad7e5f-8885-4ba1-b14a-629f89d1fafc"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("77822156-6714-4693-ad6c-7bbbde21f358") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("78cc6698-463c-4a3b-9316-ec36075b70ed"), new Guid("5c02fbf0-8ab3-4b79-a2a9-f18d4c73b173"), "Price/piece" },
                    { new Guid("99578528-26ce-4530-b7ec-e6c60656727c"), new Guid("6d014c14-d00e-45a4-8766-7c20a96aa3a1"), "Price/kg" },
                    { new Guid("f10580c3-148d-47ae-8576-6cde4a7e7f0f"), new Guid("5c02fbf0-8ab3-4b79-a2a9-f18d4c73b173"), "Place of origin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("7cba2f77-146a-48f5-94ac-2fc0c2a71347"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("6d38e761-7116-492e-8ce2-6669261db1ba") },
                    { new Guid("cf61cc95-7ea2-49cc-a218-f4da921cef40"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("6d38e761-7116-492e-8ce2-6669261db1ba") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("248db32c-0e1e-4734-af69-e2b1df37e4b3"), new Guid("6d014c14-d00e-45a4-8766-7c20a96aa3a1"), new Guid("d0a3d8cc-97d0-487d-abfe-abeeb95a638b"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("2891d612-9725-4bbe-a9da-920ccda81d13"), new Guid("eaad7e5f-8885-4ba1-b14a-629f89d1fafc"), new Guid("4f26fc25-0ea0-4067-af5d-38e2b31b8014"), null, null, "Augusta" },
                    { new Guid("3f74ba99-b47c-43aa-a4d2-94c674c6831c"), new Guid("6d014c14-d00e-45a4-8766-7c20a96aa3a1"), new Guid("d0a3d8cc-97d0-487d-abfe-abeeb95a638b"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("408879eb-f5dc-4b6f-b674-3e725e7092cb"), new Guid("5c02fbf0-8ab3-4b79-a2a9-f18d4c73b173"), new Guid("97272cb4-5292-48bd-b202-7987b4f76005"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("a71a4e12-5b8f-43d2-bbf9-2d8e79b0ee31"), new Guid("eaad7e5f-8885-4ba1-b14a-629f89d1fafc"), new Guid("4f26fc25-0ea0-4067-af5d-38e2b31b8014"), null, null, "Dragon King" },
                    { new Guid("b1714ebc-7d16-4f9c-9c97-f5e9ef612813"), new Guid("eaad7e5f-8885-4ba1-b14a-629f89d1fafc"), new Guid("4f26fc25-0ea0-4067-af5d-38e2b31b8014"), null, null, "Happy family" },
                    { new Guid("f358465c-45d4-4aa2-86cb-2e963834dd51"), new Guid("5c02fbf0-8ab3-4b79-a2a9-f18d4c73b173"), new Guid("d0a3d8cc-97d0-487d-abfe-abeeb95a638b"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("3809c392-c3bb-4709-b4d8-e864c857e106"), new Guid("99578528-26ce-4530-b7ec-e6c60656727c"), new Guid("248db32c-0e1e-4734-af69-e2b1df37e4b3"), "80" },
                    { new Guid("3853b9d6-378c-4fcc-b715-4eecdc3439c4"), new Guid("f10580c3-148d-47ae-8576-6cde4a7e7f0f"), new Guid("f358465c-45d4-4aa2-86cb-2e963834dd51"), "Czechia" },
                    { new Guid("3b1608b4-ecc2-4aaa-a3fb-983b047a11e6"), new Guid("78cc6698-463c-4a3b-9316-ec36075b70ed"), new Guid("f358465c-45d4-4aa2-86cb-2e963834dd51"), "25" },
                    { new Guid("8836ab46-531b-4be2-adad-13dcc966b805"), new Guid("78cc6698-463c-4a3b-9316-ec36075b70ed"), new Guid("408879eb-f5dc-4b6f-b674-3e725e7092cb"), "35" },
                    { new Guid("973d83f1-3b14-48cf-a479-2f1d716e6010"), new Guid("f10580c3-148d-47ae-8576-6cde4a7e7f0f"), new Guid("408879eb-f5dc-4b6f-b674-3e725e7092cb"), "Puerto Rico" },
                    { new Guid("ebcff83d-ec54-45e1-b570-103e7c507173"), new Guid("99578528-26ce-4530-b7ec-e6c60656727c"), new Guid("3f74ba99-b47c-43aa-a4d2-94c674c6831c"), "100" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("8d3ceb9e-b2ca-43a4-b915-270f5cf625ae"), new Guid("7cba2f77-146a-48f5-94ac-2fc0c2a71347"), new Guid("c09b09bb-a0ce-4a46-a9cd-08a3e1589fc5"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" },
                    { new Guid("fee7357c-e472-4198-bdf6-7e066bc31e9d"), new Guid("7cba2f77-146a-48f5-94ac-2fc0c2a71347"), new Guid("4f26fc25-0ea0-4067-af5d-38e2b31b8014"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf61cc95-7ea2-49cc-a218-f4da921cef40"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3809c392-c3bb-4709-b4d8-e864c857e106"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3853b9d6-378c-4fcc-b715-4eecdc3439c4"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3b1608b4-ecc2-4aaa-a3fb-983b047a11e6"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("8836ab46-531b-4be2-adad-13dcc966b805"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("973d83f1-3b14-48cf-a479-2f1d716e6010"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("ebcff83d-ec54-45e1-b570-103e7c507173"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2891d612-9725-4bbe-a9da-920ccda81d13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d3ceb9e-b2ca-43a4-b915-270f5cf625ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a71a4e12-5b8f-43d2-bbf9-2d8e79b0ee31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1714ebc-7d16-4f9c-9c97-f5e9ef612813"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fee7357c-e472-4198-bdf6-7e066bc31e9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8ab32d0-fcc4-4f08-9965-ef85957c2923"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("78cc6698-463c-4a3b-9316-ec36075b70ed"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("99578528-26ce-4530-b7ec-e6c60656727c"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("f10580c3-148d-47ae-8576-6cde4a7e7f0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cba2f77-146a-48f5-94ac-2fc0c2a71347"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eaad7e5f-8885-4ba1-b14a-629f89d1fafc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("248db32c-0e1e-4734-af69-e2b1df37e4b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f74ba99-b47c-43aa-a4d2-94c674c6831c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("408879eb-f5dc-4b6f-b674-3e725e7092cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f358465c-45d4-4aa2-86cb-2e963834dd51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f26fc25-0ea0-4067-af5d-38e2b31b8014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c09b09bb-a0ce-4a46-a9cd-08a3e1589fc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c02fbf0-8ab3-4b79-a2a9-f18d4c73b173"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d014c14-d00e-45a4-8766-7c20a96aa3a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d38e761-7116-492e-8ce2-6669261db1ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97272cb4-5292-48bd-b202-7987b4f76005"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0a3d8cc-97d0-487d-abfe-abeeb95a638b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77822156-6714-4693-ad6c-7bbbde21f358"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dbe28711-64d4-4872-8184-d85c3fd785ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c40a2a3-4350-4457-b456-ecc646f3e088"));

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "UserOrderEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "UserOrderEntity",
                newName: "IX_UserOrderEntity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ProductId",
                table: "UserOrderEntity",
                newName: "IX_UserOrderEntity_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrderEntity",
                table: "UserOrderEntity",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("d7260bd9-0108-417a-94c4-cffe5805a3b1"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3ea9dd00-18e5-48ed-a9db-cfcc0b1ced9e"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("5adfa8d2-b83e-484d-9e5b-d6a70c6e04db"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("cc199879-bf28-41a8-b516-97474f4eba8e"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" },
                    { new Guid("e885a7a1-8669-496d-b4ea-db47f69289b7"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("f38dc0a4-4bc7-4a51-bec9-081e93293d05"), "admin@admin.com", "", "admin", "admin", 0, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("de8b5b41-f5c4-486c-b228-24cb864d77af"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("d7260bd9-0108-417a-94c4-cffe5805a3b1") },
                    { new Guid("e89145d9-7c92-479f-bfb3-d8a649d61065"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("d7260bd9-0108-417a-94c4-cffe5805a3b1") },
                    { new Guid("44af0235-3c40-406a-a272-f7d9f419ecbd"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("de8b5b41-f5c4-486c-b228-24cb864d77af") },
                    { new Guid("5cee4a73-5211-421a-8883-6bffb0df989c"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("e89145d9-7c92-479f-bfb3-d8a649d61065") },
                    { new Guid("7415626c-4270-454d-9842-4110b05cb73d"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("e89145d9-7c92-479f-bfb3-d8a649d61065") },
                    { new Guid("ca0e8baf-8fc3-409f-8a9d-8c1434d0346e"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("de8b5b41-f5c4-486c-b228-24cb864d77af") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("c9a8cfb4-ccf6-4a71-87cc-53d2c2aef02f"), new Guid("5cee4a73-5211-421a-8883-6bffb0df989c"), "Price/kg" },
                    { new Guid("d3bf03ab-dde3-4589-b2fb-3fc03136ded3"), new Guid("44af0235-3c40-406a-a272-f7d9f419ecbd"), "Price/piece" },
                    { new Guid("e7d6e430-d0d2-4269-8f05-7343f00fe5a3"), new Guid("44af0235-3c40-406a-a272-f7d9f419ecbd"), "Place of origin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("a3a07953-70b9-484f-8a8b-8d2abb5a6b6c"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("7415626c-4270-454d-9842-4110b05cb73d") },
                    { new Guid("f671e1b2-8458-444a-8514-f57a3c6fe237"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("7415626c-4270-454d-9842-4110b05cb73d") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("06cae850-677b-4211-bd7b-b9a53c4f291d"), new Guid("44af0235-3c40-406a-a272-f7d9f419ecbd"), new Guid("e885a7a1-8669-496d-b4ea-db47f69289b7"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("17d019c8-f843-4862-ac8d-4e8f0178c1d8"), new Guid("ca0e8baf-8fc3-409f-8a9d-8c1434d0346e"), new Guid("5adfa8d2-b83e-484d-9e5b-d6a70c6e04db"), null, null, "Dragon King" },
                    { new Guid("39bae4fb-4815-4a82-8c4e-f07ead19b1dd"), new Guid("5cee4a73-5211-421a-8883-6bffb0df989c"), new Guid("3ea9dd00-18e5-48ed-a9db-cfcc0b1ced9e"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("9a8f4539-e8ad-42ad-a3b1-b4bc9a6158c2"), new Guid("ca0e8baf-8fc3-409f-8a9d-8c1434d0346e"), new Guid("5adfa8d2-b83e-484d-9e5b-d6a70c6e04db"), null, null, "Augusta" },
                    { new Guid("a55c4fc5-c6be-4e3c-ba53-0ff363ade203"), new Guid("5cee4a73-5211-421a-8883-6bffb0df989c"), new Guid("3ea9dd00-18e5-48ed-a9db-cfcc0b1ced9e"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("af20f764-9b87-414d-a346-b22b547a9e71"), new Guid("44af0235-3c40-406a-a272-f7d9f419ecbd"), new Guid("3ea9dd00-18e5-48ed-a9db-cfcc0b1ced9e"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("c3772a0b-a9ea-4021-ac3d-ea5a8b89e633"), new Guid("ca0e8baf-8fc3-409f-8a9d-8c1434d0346e"), new Guid("5adfa8d2-b83e-484d-9e5b-d6a70c6e04db"), null, null, "Happy family" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("1ec9a31a-d605-401a-8421-8816116da6a1"), new Guid("e7d6e430-d0d2-4269-8f05-7343f00fe5a3"), new Guid("06cae850-677b-4211-bd7b-b9a53c4f291d"), "Puerto Rico" },
                    { new Guid("47608fbe-5ee7-4dfa-a235-9720d499db38"), new Guid("d3bf03ab-dde3-4589-b2fb-3fc03136ded3"), new Guid("af20f764-9b87-414d-a346-b22b547a9e71"), "25" },
                    { new Guid("7e2dc0f5-8f21-4053-87c2-1cbc7395e1d7"), new Guid("e7d6e430-d0d2-4269-8f05-7343f00fe5a3"), new Guid("af20f764-9b87-414d-a346-b22b547a9e71"), "Czechia" },
                    { new Guid("aea3df9f-5a3c-41e9-9083-06b3b15492cf"), new Guid("d3bf03ab-dde3-4589-b2fb-3fc03136ded3"), new Guid("06cae850-677b-4211-bd7b-b9a53c4f291d"), "35" },
                    { new Guid("d727f2df-9738-4b55-be5b-9dfce9b0422b"), new Guid("c9a8cfb4-ccf6-4a71-87cc-53d2c2aef02f"), new Guid("a55c4fc5-c6be-4e3c-ba53-0ff363ade203"), "80" },
                    { new Guid("e69c9426-26fa-4495-94b6-f9ccfb99c643"), new Guid("c9a8cfb4-ccf6-4a71-87cc-53d2c2aef02f"), new Guid("39bae4fb-4815-4a82-8c4e-f07ead19b1dd"), "100" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("5734964b-2795-44c4-9d50-9330021f01c8"), new Guid("f671e1b2-8458-444a-8514-f57a3c6fe237"), new Guid("cc199879-bf28-41a8-b516-97474f4eba8e"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" },
                    { new Guid("a0fa522e-44e9-424e-96e3-6a122d3d37aa"), new Guid("f671e1b2-8458-444a-8514-f57a3c6fe237"), new Guid("5adfa8d2-b83e-484d-9e5b-d6a70c6e04db"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrderEntity_Products_ProductId",
                table: "UserOrderEntity",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrderEntity_Users_UserId",
                table: "UserOrderEntity",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
