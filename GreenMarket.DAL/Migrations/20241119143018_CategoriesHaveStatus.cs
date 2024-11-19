using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesHaveStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abb2c05e-ddf5-433a-b92c-7f19d5bf0b1b"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("7254bab6-a69e-4642-bc0e-c194ca919c45"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("9cc27315-9b42-424f-a6cd-3a94ec12d6b2"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("d8ec25ea-2ffe-408d-9eb3-fba0bce97bc3"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("dff56e69-de33-438a-99da-41b7340bcc9b"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("e20b0bef-aa87-44bd-b452-42ef6db720b6"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("f8b4a051-c06c-4ab7-9f0c-296f4b8af533"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32234a9a-228c-4b30-9587-723adf26effd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("457d8f40-00f7-42a6-b451-af0c11e36a1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50324501-3993-42eb-a6d1-6c00792f3742"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd833414-298c-41a7-b225-9a5b8d199926"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("edfa3025-e45f-41de-90a1-32233f0a59a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fd8596e-6d7f-4928-9614-5c32563d93b1"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("6c7995ed-96d9-4c77-bb00-e4091e431903"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("c5ad7cd8-55ff-4a83-a4e1-aa2c3dc9a797"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("ec8b8385-071e-4b5d-a63f-d2e69dbf787a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfe85c2d-92bf-4191-8000-1eee2ec4f700"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c580b352-f047-4331-a404-4cdc7c6b5135"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5041b425-ae79-4eae-b645-b6a24da1cf05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa6fe39f-9ed5-4c9b-bc27-2e537f02ad39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("beac6e66-715a-431f-8fd9-2e0fee87009d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e92a4076-c1bd-42dd-9772-da3e2a79e113"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65f33e11-6465-4cd0-bb4b-fa945995704c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bab0fb5f-b90e-4790-9cdf-fed3df5cae3f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70c6d3aa-38b8-43fa-89e3-6309a1facab5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96ca1175-1efe-4574-8d3c-71725871abe5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c13f3cc0-24ce-4453-98f8-cc814b7d6806"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28398fc8-c192-4461-bf6e-204c592e8c80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31fd6327-048f-44bd-be12-99911bb27240"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("088f01a4-7061-4158-bd3e-a56a461dd96b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56907d5f-2054-404b-999a-83f1c5ec8b54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e680d2d-dac6-42af-bb89-e693ba143b85"));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("4e680d2d-dac6-42af-bb89-e693ba143b85"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("28398fc8-c192-4461-bf6e-204c592e8c80"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("2fd8596e-6d7f-4928-9614-5c32563d93b1"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("31fd6327-048f-44bd-be12-99911bb27240"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("65f33e11-6465-4cd0-bb4b-fa945995704c"), "ilya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Ilya", "123456", 1, "IlyaVeryBad" },
                    { new Guid("bab0fb5f-b90e-4790-9cdf-fed3df5cae3f"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("088f01a4-7061-4158-bd3e-a56a461dd96b"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("4e680d2d-dac6-42af-bb89-e693ba143b85") },
                    { new Guid("56907d5f-2054-404b-999a-83f1c5ec8b54"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("4e680d2d-dac6-42af-bb89-e693ba143b85") },
                    { new Guid("70c6d3aa-38b8-43fa-89e3-6309a1facab5"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("088f01a4-7061-4158-bd3e-a56a461dd96b") },
                    { new Guid("96ca1175-1efe-4574-8d3c-71725871abe5"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("56907d5f-2054-404b-999a-83f1c5ec8b54") },
                    { new Guid("c13f3cc0-24ce-4453-98f8-cc814b7d6806"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("088f01a4-7061-4158-bd3e-a56a461dd96b") },
                    { new Guid("c580b352-f047-4331-a404-4cdc7c6b5135"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("56907d5f-2054-404b-999a-83f1c5ec8b54") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("6c7995ed-96d9-4c77-bb00-e4091e431903"), new Guid("70c6d3aa-38b8-43fa-89e3-6309a1facab5"), "Price/kg" },
                    { new Guid("c5ad7cd8-55ff-4a83-a4e1-aa2c3dc9a797"), new Guid("96ca1175-1efe-4574-8d3c-71725871abe5"), "Place of origin" },
                    { new Guid("ec8b8385-071e-4b5d-a63f-d2e69dbf787a"), new Guid("96ca1175-1efe-4574-8d3c-71725871abe5"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("abb2c05e-ddf5-433a-b92c-7f19d5bf0b1b"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("c13f3cc0-24ce-4453-98f8-cc814b7d6806") },
                    { new Guid("bfe85c2d-92bf-4191-8000-1eee2ec4f700"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("c13f3cc0-24ce-4453-98f8-cc814b7d6806") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("457d8f40-00f7-42a6-b451-af0c11e36a1b"), new Guid("c580b352-f047-4331-a404-4cdc7c6b5135"), new Guid("bab0fb5f-b90e-4790-9cdf-fed3df5cae3f"), null, null, "Dragon King", 3 },
                    { new Guid("50324501-3993-42eb-a6d1-6c00792f3742"), new Guid("c580b352-f047-4331-a404-4cdc7c6b5135"), new Guid("bab0fb5f-b90e-4790-9cdf-fed3df5cae3f"), null, null, "Augusta", 2 },
                    { new Guid("5041b425-ae79-4eae-b645-b6a24da1cf05"), new Guid("96ca1175-1efe-4574-8d3c-71725871abe5"), new Guid("31fd6327-048f-44bd-be12-99911bb27240"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte", 11 },
                    { new Guid("aa6fe39f-9ed5-4c9b-bc27-2e537f02ad39"), new Guid("70c6d3aa-38b8-43fa-89e3-6309a1facab5"), new Guid("31fd6327-048f-44bd-be12-99911bb27240"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet", 4 },
                    { new Guid("beac6e66-715a-431f-8fd9-2e0fee87009d"), new Guid("96ca1175-1efe-4574-8d3c-71725871abe5"), new Guid("28398fc8-c192-4461-bf6e-204c592e8c80"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen", 5 },
                    { new Guid("dd833414-298c-41a7-b225-9a5b8d199926"), new Guid("c580b352-f047-4331-a404-4cdc7c6b5135"), new Guid("bab0fb5f-b90e-4790-9cdf-fed3df5cae3f"), null, null, "Happy family", 10 },
                    { new Guid("e92a4076-c1bd-42dd-9772-da3e2a79e113"), new Guid("70c6d3aa-38b8-43fa-89e3-6309a1facab5"), new Guid("31fd6327-048f-44bd-be12-99911bb27240"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("7254bab6-a69e-4642-bc0e-c194ca919c45"), new Guid("c5ad7cd8-55ff-4a83-a4e1-aa2c3dc9a797"), new Guid("beac6e66-715a-431f-8fd9-2e0fee87009d"), "Puerto Rico" },
                    { new Guid("9cc27315-9b42-424f-a6cd-3a94ec12d6b2"), new Guid("ec8b8385-071e-4b5d-a63f-d2e69dbf787a"), new Guid("beac6e66-715a-431f-8fd9-2e0fee87009d"), "35" },
                    { new Guid("d8ec25ea-2ffe-408d-9eb3-fba0bce97bc3"), new Guid("ec8b8385-071e-4b5d-a63f-d2e69dbf787a"), new Guid("5041b425-ae79-4eae-b645-b6a24da1cf05"), "25" },
                    { new Guid("dff56e69-de33-438a-99da-41b7340bcc9b"), new Guid("6c7995ed-96d9-4c77-bb00-e4091e431903"), new Guid("e92a4076-c1bd-42dd-9772-da3e2a79e113"), "80" },
                    { new Guid("e20b0bef-aa87-44bd-b452-42ef6db720b6"), new Guid("c5ad7cd8-55ff-4a83-a4e1-aa2c3dc9a797"), new Guid("5041b425-ae79-4eae-b645-b6a24da1cf05"), "Czechia" },
                    { new Guid("f8b4a051-c06c-4ab7-9f0c-296f4b8af533"), new Guid("6c7995ed-96d9-4c77-bb00-e4091e431903"), new Guid("aa6fe39f-9ed5-4c9b-bc27-2e537f02ad39"), "100" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "ImgUrl", "Name", "Stock" },
                values: new object[,]
                {
                    { new Guid("32234a9a-228c-4b30-9587-723adf26effd"), new Guid("bfe85c2d-92bf-4191-8000-1eee2ec4f700"), new Guid("65f33e11-6465-4cd0-bb4b-fa945995704c"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino", 1 },
                    { new Guid("edfa3025-e45f-41de-90a1-32233f0a59a4"), new Guid("bfe85c2d-92bf-4191-8000-1eee2ec4f700"), new Guid("bab0fb5f-b90e-4790-9cdf-fed3df5cae3f"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino", 5 }
                });
        }
    }
}
