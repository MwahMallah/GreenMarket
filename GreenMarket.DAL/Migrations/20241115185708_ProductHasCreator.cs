using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductHasCreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a93dfb9-ce8c-4762-85f3-f80311bd623a"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("2a181756-7faf-437b-9178-23b5617b8ac7"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("462d8043-e9a0-468e-8ded-0daaf065d388"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("485435d2-395d-4de4-b6c3-0659998c64e7"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("5be18a08-29ad-4610-b1fc-7a76ae6e9836"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("a34587fe-b7b1-4af1-95f0-b9ee6f28ca8d"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("dd518cb7-747b-4cfb-a702-905519afe4bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1abc58dc-0062-4830-942d-692cb66e01b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96107e57-6644-4efb-ad98-c245298c52cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a846a308-6197-4b58-9601-1f235a8c2d46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d968e190-7fef-43cc-a8cd-6cd4b2c527d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbdf79bb-97cf-4634-aff0-85abe7e9cd83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68ef8e8b-36f8-44dc-816a-296234b27dc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91c99720-f88f-4159-b6b3-4e1033c535e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7cfff66-39c4-4afe-ae93-75be380c23ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea6216a2-1b7e-4413-9c25-121c75318477"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("15934a20-50de-4687-8e5e-795d3bdca53f"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("4f5ef285-2ea0-42ba-bfce-8665a68129f1"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("e1514f97-d1cc-4448-a056-d8f91a4a2dfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05b93b19-15e2-4c7d-99a0-a07aa978c043"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c0bb4fe-55ac-4ad5-a743-af5a49645400"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c652ade-e64b-49b7-99f3-6caee45738b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b02d4baa-d725-47aa-8085-4ed196b7b890"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8b673b5-d193-45c0-9ef0-15273c96e198"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd20730f-fb32-401f-90f7-5630c240b42a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bf91e74-593b-493a-8510-e2fd83076338"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63c32b8a-e3bb-417a-908c-7bfd68ef79ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba17940e-faf2-4478-90ef-93069199c134"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0dc0482d-3698-4ef9-8ea1-9a0d47980cd6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0bfa7f4-bf7f-4e1b-9965-f39ff5cc74b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c97f2c98-fdea-43ea-a7fc-e1cd9a07b3d0"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatorId",
                table: "Products",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_CreatorId",
                table: "Products",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_CreatorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CreatorId",
                table: "Products");

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

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("c97f2c98-fdea-43ea-a7fc-e1cd9a07b3d0"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("68ef8e8b-36f8-44dc-816a-296234b27dc3"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("91c99720-f88f-4159-b6b3-4e1033c535e9"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("a7cfff66-39c4-4afe-ae93-75be380c23ae"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("ea6216a2-1b7e-4413-9c25-121c75318477"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("0dc0482d-3698-4ef9-8ea1-9a0d47980cd6"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("c97f2c98-fdea-43ea-a7fc-e1cd9a07b3d0") },
                    { new Guid("b0bfa7f4-bf7f-4e1b-9965-f39ff5cc74b2"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("c97f2c98-fdea-43ea-a7fc-e1cd9a07b3d0") },
                    { new Guid("05b93b19-15e2-4c7d-99a0-a07aa978c043"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("b0bfa7f4-bf7f-4e1b-9965-f39ff5cc74b2") },
                    { new Guid("1bf91e74-593b-493a-8510-e2fd83076338"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("0dc0482d-3698-4ef9-8ea1-9a0d47980cd6") },
                    { new Guid("63c32b8a-e3bb-417a-908c-7bfd68ef79ca"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("0dc0482d-3698-4ef9-8ea1-9a0d47980cd6") },
                    { new Guid("ba17940e-faf2-4478-90ef-93069199c134"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("b0bfa7f4-bf7f-4e1b-9965-f39ff5cc74b2") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("15934a20-50de-4687-8e5e-795d3bdca53f"), new Guid("1bf91e74-593b-493a-8510-e2fd83076338"), "Price/kg" },
                    { new Guid("4f5ef285-2ea0-42ba-bfce-8665a68129f1"), new Guid("ba17940e-faf2-4478-90ef-93069199c134"), "Place of origin" },
                    { new Guid("e1514f97-d1cc-4448-a056-d8f91a4a2dfd"), new Guid("ba17940e-faf2-4478-90ef-93069199c134"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("1c0bb4fe-55ac-4ad5-a743-af5a49645400"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("63c32b8a-e3bb-417a-908c-7bfd68ef79ca") },
                    { new Guid("5a93dfb9-ce8c-4762-85f3-f80311bd623a"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("63c32b8a-e3bb-417a-908c-7bfd68ef79ca") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("1abc58dc-0062-4830-942d-692cb66e01b8"), new Guid("05b93b19-15e2-4c7d-99a0-a07aa978c043"), null, null, "Dragon King" },
                    { new Guid("6c652ade-e64b-49b7-99f3-6caee45738b4"), new Guid("1bf91e74-593b-493a-8510-e2fd83076338"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("96107e57-6644-4efb-ad98-c245298c52cf"), new Guid("05b93b19-15e2-4c7d-99a0-a07aa978c043"), null, null, "Happy family" },
                    { new Guid("b02d4baa-d725-47aa-8085-4ed196b7b890"), new Guid("ba17940e-faf2-4478-90ef-93069199c134"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("c8b673b5-d193-45c0-9ef0-15273c96e198"), new Guid("ba17940e-faf2-4478-90ef-93069199c134"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("cd20730f-fb32-401f-90f7-5630c240b42a"), new Guid("1bf91e74-593b-493a-8510-e2fd83076338"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("d968e190-7fef-43cc-a8cd-6cd4b2c527d8"), new Guid("05b93b19-15e2-4c7d-99a0-a07aa978c043"), null, null, "Augusta" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("2a181756-7faf-437b-9178-23b5617b8ac7"), new Guid("e1514f97-d1cc-4448-a056-d8f91a4a2dfd"), new Guid("c8b673b5-d193-45c0-9ef0-15273c96e198"), "35" },
                    { new Guid("462d8043-e9a0-468e-8ded-0daaf065d388"), new Guid("4f5ef285-2ea0-42ba-bfce-8665a68129f1"), new Guid("b02d4baa-d725-47aa-8085-4ed196b7b890"), "Czechia" },
                    { new Guid("485435d2-395d-4de4-b6c3-0659998c64e7"), new Guid("e1514f97-d1cc-4448-a056-d8f91a4a2dfd"), new Guid("b02d4baa-d725-47aa-8085-4ed196b7b890"), "25" },
                    { new Guid("5be18a08-29ad-4610-b1fc-7a76ae6e9836"), new Guid("15934a20-50de-4687-8e5e-795d3bdca53f"), new Guid("cd20730f-fb32-401f-90f7-5630c240b42a"), "100" },
                    { new Guid("a34587fe-b7b1-4af1-95f0-b9ee6f28ca8d"), new Guid("4f5ef285-2ea0-42ba-bfce-8665a68129f1"), new Guid("c8b673b5-d193-45c0-9ef0-15273c96e198"), "Puerto Rico" },
                    { new Guid("dd518cb7-747b-4cfb-a702-905519afe4bf"), new Guid("15934a20-50de-4687-8e5e-795d3bdca53f"), new Guid("6c652ade-e64b-49b7-99f3-6caee45738b4"), "80" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("a846a308-6197-4b58-9601-1f235a8c2d46"), new Guid("1c0bb4fe-55ac-4ad5-a743-af5a49645400"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" },
                    { new Guid("fbdf79bb-97cf-4634-aff0-85abe7e9cd83"), new Guid("1c0bb4fe-55ac-4ad5-a743-af5a49645400"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" }
                });
        }
    }
}
