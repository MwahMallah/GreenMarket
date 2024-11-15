using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UsersHaveOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserOrderEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrderEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOrderEntity_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrderEntity_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserOrderEntity_ProductId",
                table: "UserOrderEntity",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrderEntity_UserId",
                table: "UserOrderEntity",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserOrderEntity");

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
    }
}
