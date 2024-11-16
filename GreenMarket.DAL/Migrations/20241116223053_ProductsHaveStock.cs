using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductsHaveStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("36a7ffc2-54a7-4e3e-8a49-93c9088c28aa"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("094b45c6-b3c9-4550-ab6c-f92ded816167"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" },
                    { new Guid("3eeba934-df32-4f1c-b01d-a9ef01c0f39d"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("7bd14dd6-4bff-401e-b29d-4bac0c9eb808"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("9732dc8c-b504-462c-8331-b5be8641d384"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("c6b0b352-2359-46a1-8f9f-137d11c6ceb6"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("4a359462-d15c-45b1-b063-fdea96d560e2"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("36a7ffc2-54a7-4e3e-8a49-93c9088c28aa") },
                    { new Guid("bac1ed53-a0b7-45f0-b7cd-0a02594c288e"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("36a7ffc2-54a7-4e3e-8a49-93c9088c28aa") },
                    { new Guid("01f1501c-3186-4daa-9619-0c5e85148f99"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("4a359462-d15c-45b1-b063-fdea96d560e2") },
                    { new Guid("0ea84195-b170-4950-8888-564da31bc806"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("4a359462-d15c-45b1-b063-fdea96d560e2") },
                    { new Guid("3e862a43-e19d-4aea-85b4-7db06f754476"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("bac1ed53-a0b7-45f0-b7cd-0a02594c288e") },
                    { new Guid("bf01faf6-1318-4bbd-804e-2a5ed763a66e"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("bac1ed53-a0b7-45f0-b7cd-0a02594c288e") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("5a53d730-c8e4-4c63-ae68-3f5461f883db"), new Guid("0ea84195-b170-4950-8888-564da31bc806"), "Place of origin" },
                    { new Guid("9bb70179-0832-4361-8f56-d01266499f6b"), new Guid("0ea84195-b170-4950-8888-564da31bc806"), "Price/piece" },
                    { new Guid("ea132e15-a0ec-4f59-b934-37a93ebd7913"), new Guid("bf01faf6-1318-4bbd-804e-2a5ed763a66e"), "Price/kg" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("238b1023-30bc-4354-9752-18bb831ec690"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("3e862a43-e19d-4aea-85b4-7db06f754476") },
                    { new Guid("801527a2-a5f2-4b1b-b8ce-d9d9da0b926d"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("3e862a43-e19d-4aea-85b4-7db06f754476") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("42fe9ecd-9405-40d2-ac6a-8ae4ecba7b2e"), new Guid("01f1501c-3186-4daa-9619-0c5e85148f99"), new Guid("c6b0b352-2359-46a1-8f9f-137d11c6ceb6"), null, null, "Dragon King", 3 },
                    { new Guid("54c3ddd3-b36a-4708-8915-5891ab95d73f"), new Guid("01f1501c-3186-4daa-9619-0c5e85148f99"), new Guid("c6b0b352-2359-46a1-8f9f-137d11c6ceb6"), null, null, "Augusta", 2 },
                    { new Guid("5b52eab1-f554-4123-b5fe-5b4b65f5d258"), new Guid("01f1501c-3186-4daa-9619-0c5e85148f99"), new Guid("c6b0b352-2359-46a1-8f9f-137d11c6ceb6"), null, null, "Happy family", 10 },
                    { new Guid("a000d9d3-f87c-4f85-9278-757a45024c1f"), new Guid("bf01faf6-1318-4bbd-804e-2a5ed763a66e"), new Guid("9732dc8c-b504-462c-8331-b5be8641d384"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet", 3 },
                    { new Guid("a0821916-1ed6-406d-825d-6795e46a52a1"), new Guid("bf01faf6-1318-4bbd-804e-2a5ed763a66e"), new Guid("9732dc8c-b504-462c-8331-b5be8641d384"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet", 4 },
                    { new Guid("adf04862-7013-4c75-bb53-5ae28b37940d"), new Guid("0ea84195-b170-4950-8888-564da31bc806"), new Guid("9732dc8c-b504-462c-8331-b5be8641d384"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte", 11 },
                    { new Guid("c1e9456d-e94d-4e2b-9359-0c79d8ea54fd"), new Guid("0ea84195-b170-4950-8888-564da31bc806"), new Guid("7bd14dd6-4bff-401e-b29d-4bac0c9eb808"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen", 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("0c4af471-c2f6-4c9d-aa7b-c40d51f7f6c6"), new Guid("9bb70179-0832-4361-8f56-d01266499f6b"), new Guid("c1e9456d-e94d-4e2b-9359-0c79d8ea54fd"), "35" },
                    { new Guid("2bbf898d-a584-49be-acf0-42e03426bc49"), new Guid("9bb70179-0832-4361-8f56-d01266499f6b"), new Guid("adf04862-7013-4c75-bb53-5ae28b37940d"), "25" },
                    { new Guid("810a8eff-20a5-4a6a-8600-be44841cb926"), new Guid("5a53d730-c8e4-4c63-ae68-3f5461f883db"), new Guid("c1e9456d-e94d-4e2b-9359-0c79d8ea54fd"), "Puerto Rico" },
                    { new Guid("a8ef55c3-296d-42ec-b544-46970c393320"), new Guid("ea132e15-a0ec-4f59-b934-37a93ebd7913"), new Guid("a0821916-1ed6-406d-825d-6795e46a52a1"), "100" },
                    { new Guid("bf0c450e-d225-47f8-bfe7-164b1315344b"), new Guid("5a53d730-c8e4-4c63-ae68-3f5461f883db"), new Guid("adf04862-7013-4c75-bb53-5ae28b37940d"), "Czechia" },
                    { new Guid("e8b4953e-14b3-4909-9b74-b73f73e508f5"), new Guid("ea132e15-a0ec-4f59-b934-37a93ebd7913"), new Guid("a000d9d3-f87c-4f85-9278-757a45024c1f"), "80" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("a3cb1ca5-8eb8-4366-b3f5-9a6038fe8861"), new Guid("238b1023-30bc-4354-9752-18bb831ec690"), new Guid("c6b0b352-2359-46a1-8f9f-137d11c6ceb6"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino", 5 },
                    { new Guid("eb3dedd5-7a8c-4d8a-9b65-435dc7654493"), new Guid("238b1023-30bc-4354-9752-18bb831ec690"), new Guid("094b45c6-b3c9-4550-ab6c-f92ded816167"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("801527a2-a5f2-4b1b-b8ce-d9d9da0b926d"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("0c4af471-c2f6-4c9d-aa7b-c40d51f7f6c6"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("2bbf898d-a584-49be-acf0-42e03426bc49"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("810a8eff-20a5-4a6a-8600-be44841cb926"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("a8ef55c3-296d-42ec-b544-46970c393320"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("bf0c450e-d225-47f8-bfe7-164b1315344b"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("e8b4953e-14b3-4909-9b74-b73f73e508f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42fe9ecd-9405-40d2-ac6a-8ae4ecba7b2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54c3ddd3-b36a-4708-8915-5891ab95d73f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b52eab1-f554-4123-b5fe-5b4b65f5d258"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3cb1ca5-8eb8-4366-b3f5-9a6038fe8861"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb3dedd5-7a8c-4d8a-9b65-435dc7654493"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3eeba934-df32-4f1c-b01d-a9ef01c0f39d"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("5a53d730-c8e4-4c63-ae68-3f5461f883db"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("9bb70179-0832-4361-8f56-d01266499f6b"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("ea132e15-a0ec-4f59-b934-37a93ebd7913"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01f1501c-3186-4daa-9619-0c5e85148f99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("238b1023-30bc-4354-9752-18bb831ec690"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a000d9d3-f87c-4f85-9278-757a45024c1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0821916-1ed6-406d-825d-6795e46a52a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adf04862-7013-4c75-bb53-5ae28b37940d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1e9456d-e94d-4e2b-9359-0c79d8ea54fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("094b45c6-b3c9-4550-ab6c-f92ded816167"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6b0b352-2359-46a1-8f9f-137d11c6ceb6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ea84195-b170-4950-8888-564da31bc806"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e862a43-e19d-4aea-85b4-7db06f754476"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf01faf6-1318-4bbd-804e-2a5ed763a66e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bd14dd6-4bff-401e-b29d-4bac0c9eb808"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9732dc8c-b504-462c-8331-b5be8641d384"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a359462-d15c-45b1-b063-fdea96d560e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bac1ed53-a0b7-45f0-b7cd-0a02594c288e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36a7ffc2-54a7-4e3e-8a49-93c9088c28aa"));

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

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
        }
    }
}
