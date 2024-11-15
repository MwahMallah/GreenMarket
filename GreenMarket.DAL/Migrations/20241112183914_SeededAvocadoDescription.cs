using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeededAvocadoDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0722dace-19c5-446b-b376-a7af8d722725"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("01882c83-8080-44a3-aa0d-d071979f21f4"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("20a1dcd1-2fb4-454e-ae84-5c3be9f3e4fb"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("2c039027-480a-440b-a33e-745b02be0525"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("7a529a87-dea7-416e-9189-390df4e2dbbc"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("d3658569-b9bd-4a61-a656-fe7116023276"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("f4367fcd-d57a-4cde-9ddf-ebff76f9d1d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49ac3814-acaf-4c33-8e08-90641051d0a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90a4730e-fe43-4131-8e85-65029343d1b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6f5252c-2fe4-4fa3-95fa-e449d2bd63e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df7bfc0f-4b9d-4e26-ad1a-6f842586bd75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e21cdd69-690c-4c4c-a611-39e5c9c6c44c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("526ec896-3e78-4f11-8dea-5bf5b5dda1b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4b15a7d-4659-4377-9cb4-10d21d710e67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d864ef7f-57fe-4e23-b1fd-729e23a7d71d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f78eb7dc-2a76-4dca-b93a-540cb42c6cfc"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("515c7051-43c6-4042-9125-7ab151782857"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("aae5d513-8bbc-4f65-aaee-02aabe266738"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("bcd71969-3c51-49a6-a3cd-b2c0e58b4d55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("942f350a-f475-4968-997d-7b9f9eeee7d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9bbb7e1-2cfe-4296-8cfa-5a32b5e1efc6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c85b2e8-efc2-492c-96f1-f1c10ea5d280"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4702c55a-a7a5-48f9-ab2b-a17602afcfa5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8de117ca-fb9e-42d3-a2bb-025e6896d2f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c12780b8-2b68-4a15-a10d-79cd3a495712"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00d6bde2-266b-456a-87d6-158fed084ec8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1aac9865-4c04-4521-a03b-889bfd76c726"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f200e3d-74ee-49d8-a388-1dbfd633987f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a787439-866f-486f-90b8-69e297834f40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e55b309-f081-4f26-910e-d9e3b39d043f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b3716ce-569a-4817-9efd-3f79fc0d4ba0"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("1c9de80d-7703-4603-8aba-d8eb76cc3ce6"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3630bd8b-3917-43cd-8abf-0c6cef7efd85"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("365d8ede-296d-4f33-b393-195f2fc52b21"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("855580a7-1c5b-4317-8067-bc30065d6ef0"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("e469c212-800f-4678-9269-9d9eee9914cc"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("6ca80e08-e21f-41eb-9046-4802a87a6803"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("1c9de80d-7703-4603-8aba-d8eb76cc3ce6") },
                    { new Guid("80cb0360-3d74-49d8-a5cf-782536b54250"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("1c9de80d-7703-4603-8aba-d8eb76cc3ce6") },
                    { new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("6ca80e08-e21f-41eb-9046-4802a87a6803") },
                    { new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("80cb0360-3d74-49d8-a5cf-782536b54250") },
                    { new Guid("1debe3aa-ad1a-48d8-9cdb-d6830c7bb4b0"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("80cb0360-3d74-49d8-a5cf-782536b54250") },
                    { new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("6ca80e08-e21f-41eb-9046-4802a87a6803") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("74730f37-7ba4-457e-9c44-b23ddd0b0d35"), new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"), "Place of origin" },
                    { new Guid("7f6d3e5a-cfc1-4d67-9a7e-6bb1570aad48"), new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"), "Price/kg" },
                    { new Guid("c1cf1478-e101-463d-be41-4e75f028134b"), new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("8ce8c316-adb9-48e9-ac28-51daeed44253"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("1debe3aa-ad1a-48d8-9cdb-d6830c7bb4b0") },
                    { new Guid("dca89a1a-8695-42d1-9220-ecbacee8837a"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("1debe3aa-ad1a-48d8-9cdb-d6830c7bb4b0") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("2e3a771e-d25e-49a8-b997-aec252e779a3"), new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"), null, null, "Augusta" },
                    { new Guid("4f6b2171-fbdf-4f3f-8ebd-d2879b61a6cf"), new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("61cb9ac5-36ed-4d6a-b1db-585678e38c78"), new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"), null, null, "Dragon King" },
                    { new Guid("7428e6c9-15a8-468d-8fb9-aae6b3e60308"), new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("81a6e722-bd88-4101-b7fc-92db545a36f0"), new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"), null, null, "Happy family" },
                    { new Guid("890b5920-1e6a-4e9c-b65e-b42f9c2dfd98"), new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("e4e7b476-d625-430c-8a52-b0eaa7e558c1"), new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("00b2db4c-d50a-454a-8de8-a97fb762656d"), new Guid("7f6d3e5a-cfc1-4d67-9a7e-6bb1570aad48"), new Guid("890b5920-1e6a-4e9c-b65e-b42f9c2dfd98"), "100" },
                    { new Guid("089937a4-ccd5-477a-afae-c6980087c924"), new Guid("c1cf1478-e101-463d-be41-4e75f028134b"), new Guid("4f6b2171-fbdf-4f3f-8ebd-d2879b61a6cf"), "35" },
                    { new Guid("18554e18-db73-47ab-bceb-c8d1baaa9e06"), new Guid("c1cf1478-e101-463d-be41-4e75f028134b"), new Guid("7428e6c9-15a8-468d-8fb9-aae6b3e60308"), "25" },
                    { new Guid("3cd38356-aed3-4937-a112-32204eb66d59"), new Guid("74730f37-7ba4-457e-9c44-b23ddd0b0d35"), new Guid("4f6b2171-fbdf-4f3f-8ebd-d2879b61a6cf"), "Puerto Rico" },
                    { new Guid("417e37aa-df1e-4fc4-8e72-4a46185b11bf"), new Guid("7f6d3e5a-cfc1-4d67-9a7e-6bb1570aad48"), new Guid("e4e7b476-d625-430c-8a52-b0eaa7e558c1"), "80" },
                    { new Guid("482cf4f1-f9ee-46ae-a79d-a333bb866841"), new Guid("74730f37-7ba4-457e-9c44-b23ddd0b0d35"), new Guid("7428e6c9-15a8-468d-8fb9-aae6b3e60308"), "Czechia" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("21ef26f5-5983-4e21-93e7-ee861ae8da20"), new Guid("dca89a1a-8695-42d1-9220-ecbacee8837a"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" },
                    { new Guid("72e4c807-4cce-4f72-9bb0-d9760aaf4734"), new Guid("dca89a1a-8695-42d1-9220-ecbacee8837a"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ce8c316-adb9-48e9-ac28-51daeed44253"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("00b2db4c-d50a-454a-8de8-a97fb762656d"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("089937a4-ccd5-477a-afae-c6980087c924"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("18554e18-db73-47ab-bceb-c8d1baaa9e06"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3cd38356-aed3-4937-a112-32204eb66d59"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("417e37aa-df1e-4fc4-8e72-4a46185b11bf"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("482cf4f1-f9ee-46ae-a79d-a333bb866841"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21ef26f5-5983-4e21-93e7-ee861ae8da20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e3a771e-d25e-49a8-b997-aec252e779a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61cb9ac5-36ed-4d6a-b1db-585678e38c78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72e4c807-4cce-4f72-9bb0-d9760aaf4734"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81a6e722-bd88-4101-b7fc-92db545a36f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3630bd8b-3917-43cd-8abf-0c6cef7efd85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("365d8ede-296d-4f33-b393-195f2fc52b21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("855580a7-1c5b-4317-8067-bc30065d6ef0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e469c212-800f-4678-9269-9d9eee9914cc"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("74730f37-7ba4-457e-9c44-b23ddd0b0d35"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("7f6d3e5a-cfc1-4d67-9a7e-6bb1570aad48"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("c1cf1478-e101-463d-be41-4e75f028134b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a69ca0b-9413-411f-a3e6-68ec9d1e5643"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dca89a1a-8695-42d1-9220-ecbacee8837a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f6b2171-fbdf-4f3f-8ebd-d2879b61a6cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7428e6c9-15a8-468d-8fb9-aae6b3e60308"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("890b5920-1e6a-4e9c-b65e-b42f9c2dfd98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4e7b476-d625-430c-8a52-b0eaa7e558c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d33e689-6018-4b1d-ba45-36a3456e6b2c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1debe3aa-ad1a-48d8-9cdb-d6830c7bb4b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3737d24-28d6-4ec3-9039-fa782151f11b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ca80e08-e21f-41eb-9046-4802a87a6803"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80cb0360-3d74-49d8-a5cf-782536b54250"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c9de80d-7703-4603-8aba-d8eb76cc3ce6"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("0b3716ce-569a-4817-9efd-3f79fc0d4ba0"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("526ec896-3e78-4f11-8dea-5bf5b5dda1b3"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("c4b15a7d-4659-4377-9cb4-10d21d710e67"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("d864ef7f-57fe-4e23-b1fd-729e23a7d71d"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("f78eb7dc-2a76-4dca-b93a-540cb42c6cfc"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("7a787439-866f-486f-90b8-69e297834f40"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("0b3716ce-569a-4817-9efd-3f79fc0d4ba0") },
                    { new Guid("7e55b309-f081-4f26-910e-d9e3b39d043f"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("0b3716ce-569a-4817-9efd-3f79fc0d4ba0") },
                    { new Guid("00d6bde2-266b-456a-87d6-158fed084ec8"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("7e55b309-f081-4f26-910e-d9e3b39d043f") },
                    { new Guid("1aac9865-4c04-4521-a03b-889bfd76c726"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("7a787439-866f-486f-90b8-69e297834f40") },
                    { new Guid("9f200e3d-74ee-49d8-a388-1dbfd633987f"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("7e55b309-f081-4f26-910e-d9e3b39d043f") },
                    { new Guid("b9bbb7e1-2cfe-4296-8cfa-5a32b5e1efc6"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("7a787439-866f-486f-90b8-69e297834f40") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("515c7051-43c6-4042-9125-7ab151782857"), new Guid("9f200e3d-74ee-49d8-a388-1dbfd633987f"), "Price/kg" },
                    { new Guid("aae5d513-8bbc-4f65-aaee-02aabe266738"), new Guid("1aac9865-4c04-4521-a03b-889bfd76c726"), "Place of origin" },
                    { new Guid("bcd71969-3c51-49a6-a3cd-b2c0e58b4d55"), new Guid("1aac9865-4c04-4521-a03b-889bfd76c726"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("0722dace-19c5-446b-b376-a7af8d722725"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("00d6bde2-266b-456a-87d6-158fed084ec8") },
                    { new Guid("942f350a-f475-4968-997d-7b9f9eeee7d4"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("00d6bde2-266b-456a-87d6-158fed084ec8") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("0c85b2e8-efc2-492c-96f1-f1c10ea5d280"), new Guid("1aac9865-4c04-4521-a03b-889bfd76c726"), null, "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("4702c55a-a7a5-48f9-ab2b-a17602afcfa5"), new Guid("9f200e3d-74ee-49d8-a388-1dbfd633987f"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("8de117ca-fb9e-42d3-a2bb-025e6896d2f3"), new Guid("1aac9865-4c04-4521-a03b-889bfd76c726"), null, "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("b6f5252c-2fe4-4fa3-95fa-e449d2bd63e3"), new Guid("b9bbb7e1-2cfe-4296-8cfa-5a32b5e1efc6"), null, null, "Dragon King" },
                    { new Guid("c12780b8-2b68-4a15-a10d-79cd3a495712"), new Guid("9f200e3d-74ee-49d8-a388-1dbfd633987f"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("df7bfc0f-4b9d-4e26-ad1a-6f842586bd75"), new Guid("b9bbb7e1-2cfe-4296-8cfa-5a32b5e1efc6"), null, null, "Augusta" },
                    { new Guid("e21cdd69-690c-4c4c-a611-39e5c9c6c44c"), new Guid("b9bbb7e1-2cfe-4296-8cfa-5a32b5e1efc6"), null, null, "Happy family" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("01882c83-8080-44a3-aa0d-d071979f21f4"), new Guid("515c7051-43c6-4042-9125-7ab151782857"), new Guid("c12780b8-2b68-4a15-a10d-79cd3a495712"), "80" },
                    { new Guid("20a1dcd1-2fb4-454e-ae84-5c3be9f3e4fb"), new Guid("515c7051-43c6-4042-9125-7ab151782857"), new Guid("4702c55a-a7a5-48f9-ab2b-a17602afcfa5"), "100" },
                    { new Guid("2c039027-480a-440b-a33e-745b02be0525"), new Guid("bcd71969-3c51-49a6-a3cd-b2c0e58b4d55"), new Guid("8de117ca-fb9e-42d3-a2bb-025e6896d2f3"), "25" },
                    { new Guid("7a529a87-dea7-416e-9189-390df4e2dbbc"), new Guid("bcd71969-3c51-49a6-a3cd-b2c0e58b4d55"), new Guid("0c85b2e8-efc2-492c-96f1-f1c10ea5d280"), "35" },
                    { new Guid("d3658569-b9bd-4a61-a656-fe7116023276"), new Guid("aae5d513-8bbc-4f65-aaee-02aabe266738"), new Guid("0c85b2e8-efc2-492c-96f1-f1c10ea5d280"), "Puerto Rico" },
                    { new Guid("f4367fcd-d57a-4cde-9ddf-ebff76f9d1d7"), new Guid("aae5d513-8bbc-4f65-aaee-02aabe266738"), new Guid("8de117ca-fb9e-42d3-a2bb-025e6896d2f3"), "Czechia" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("49ac3814-acaf-4c33-8e08-90641051d0a8"), new Guid("942f350a-f475-4968-997d-7b9f9eeee7d4"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" },
                    { new Guid("90a4730e-fe43-4131-8e85-65029343d1b9"), new Guid("942f350a-f475-4968-997d-7b9f9eeee7d4"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" }
                });
        }
    }
}
