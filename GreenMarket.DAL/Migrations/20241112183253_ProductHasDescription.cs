using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductHasDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

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
    }
}
