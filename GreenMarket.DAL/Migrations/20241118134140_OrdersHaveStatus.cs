using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class OrdersHaveStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

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
    }
}
