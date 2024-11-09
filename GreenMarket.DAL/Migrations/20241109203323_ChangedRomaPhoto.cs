using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangedRomaPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e108b3b0-1ab1-4516-987a-8eec5b6b92d4"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("279d202a-e489-4b6f-97f5-bd1e9370b052"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("804f887c-6522-4ca2-87a9-5d5790b40e8b"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("8afcf32d-c326-4cf9-b822-e1c01b115223"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("d82e1ffa-e9bf-411e-9b03-ece862de73a0"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("da5773e7-5112-4648-9c65-3369d9a72672"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("efbc5430-a15c-4e95-a04d-873cb6d19ba0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dc27834-39d8-4dd8-9bb8-210d42e86a50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8020dcc9-66cf-4d74-b0d9-fe4964fac820"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("968c8134-a4ff-41a3-b2ef-71147fdaa9f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8839e57-93c9-4963-973d-2f5228d14de4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca7cd240-5ea4-4cb8-8887-83d85f17ee11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e12888f-ca31-43cc-96f3-ff4a061eabf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1728c34d-2c29-48d9-98a2-573ef6c9bf6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("438ffd2d-ec79-44ed-8431-ab7c4de1a044"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95b34bbb-81aa-46bd-93cf-f03f329f9d4b"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("45a0d587-bdef-4f98-b8dc-2be45ab57848"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("47ad562b-9306-423b-bca7-1c0edc27d0db"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("922ac2cd-4613-4951-825f-ed99bbbcda19"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("694d7e99-5509-477f-b5e3-46b356241166"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a499d06e-b7e7-4bcc-93a8-08f50b74dc17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("081e78e5-deab-4164-864d-8340d7ee2baf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("181fa3d0-085d-443c-97e2-9e3ccf6656a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36265fa7-710e-48a7-9f73-a34c84c48024"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c34cf07-1395-4c95-9cea-13f0be6691b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6af91c91-e410-41f8-9c7a-33560df06ecb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86bad8fc-00a2-4ad0-b431-862e66c2334f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc436980-0241-4503-b101-10f9d28da52f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8dbe0890-cbf5-432f-9b9f-0e96429ca68c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e672d70f-0e84-4c3e-9c46-1bcc6431603c"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("8dbe0890-cbf5-432f-9b9f-0e96429ca68c"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", null },
                    { new Guid("e672d70f-0e84-4c3e-9c46-1bcc6431603c"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("0e12888f-ca31-43cc-96f3-ff4a061eabf3"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("1728c34d-2c29-48d9-98a2-573ef6c9bf6a"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("438ffd2d-ec79-44ed-8431-ab7c4de1a044"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("95b34bbb-81aa-46bd-93cf-f03f329f9d4b"), "", "admin", "admin", 0, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("694d7e99-5509-477f-b5e3-46b356241166"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("e672d70f-0e84-4c3e-9c46-1bcc6431603c") },
                    { new Guid("6af91c91-e410-41f8-9c7a-33560df06ecb"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("e672d70f-0e84-4c3e-9c46-1bcc6431603c") },
                    { new Guid("86bad8fc-00a2-4ad0-b431-862e66c2334f"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("8dbe0890-cbf5-432f-9b9f-0e96429ca68c") },
                    { new Guid("fc436980-0241-4503-b101-10f9d28da52f"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("8dbe0890-cbf5-432f-9b9f-0e96429ca68c") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("45a0d587-bdef-4f98-b8dc-2be45ab57848"), new Guid("6af91c91-e410-41f8-9c7a-33560df06ecb"), "Price/piece" },
                    { new Guid("47ad562b-9306-423b-bca7-1c0edc27d0db"), new Guid("6af91c91-e410-41f8-9c7a-33560df06ecb"), "Place of origin" },
                    { new Guid("922ac2cd-4613-4951-825f-ed99bbbcda19"), new Guid("fc436980-0241-4503-b101-10f9d28da52f"), "Price/kg" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("a499d06e-b7e7-4bcc-93a8-08f50b74dc17"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("86bad8fc-00a2-4ad0-b431-862e66c2334f") },
                    { new Guid("e108b3b0-1ab1-4516-987a-8eec5b6b92d4"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Roma", new Guid("86bad8fc-00a2-4ad0-b431-862e66c2334f") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("081e78e5-deab-4164-864d-8340d7ee2baf"), new Guid("fc436980-0241-4503-b101-10f9d28da52f"), "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("0dc27834-39d8-4dd8-9bb8-210d42e86a50"), new Guid("694d7e99-5509-477f-b5e3-46b356241166"), null, "Augusta" },
                    { new Guid("181fa3d0-085d-443c-97e2-9e3ccf6656a9"), new Guid("6af91c91-e410-41f8-9c7a-33560df06ecb"), "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("36265fa7-710e-48a7-9f73-a34c84c48024"), new Guid("6af91c91-e410-41f8-9c7a-33560df06ecb"), "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("6c34cf07-1395-4c95-9cea-13f0be6691b1"), new Guid("fc436980-0241-4503-b101-10f9d28da52f"), "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("8020dcc9-66cf-4d74-b0d9-fe4964fac820"), new Guid("694d7e99-5509-477f-b5e3-46b356241166"), null, "Happy family" },
                    { new Guid("a8839e57-93c9-4963-973d-2f5228d14de4"), new Guid("694d7e99-5509-477f-b5e3-46b356241166"), null, "Dragon King" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("279d202a-e489-4b6f-97f5-bd1e9370b052"), new Guid("922ac2cd-4613-4951-825f-ed99bbbcda19"), new Guid("6c34cf07-1395-4c95-9cea-13f0be6691b1"), "100" },
                    { new Guid("804f887c-6522-4ca2-87a9-5d5790b40e8b"), new Guid("47ad562b-9306-423b-bca7-1c0edc27d0db"), new Guid("36265fa7-710e-48a7-9f73-a34c84c48024"), "Puerto Rico" },
                    { new Guid("8afcf32d-c326-4cf9-b822-e1c01b115223"), new Guid("45a0d587-bdef-4f98-b8dc-2be45ab57848"), new Guid("181fa3d0-085d-443c-97e2-9e3ccf6656a9"), "25" },
                    { new Guid("d82e1ffa-e9bf-411e-9b03-ece862de73a0"), new Guid("47ad562b-9306-423b-bca7-1c0edc27d0db"), new Guid("181fa3d0-085d-443c-97e2-9e3ccf6656a9"), "Czechia" },
                    { new Guid("da5773e7-5112-4648-9c65-3369d9a72672"), new Guid("922ac2cd-4613-4951-825f-ed99bbbcda19"), new Guid("081e78e5-deab-4164-864d-8340d7ee2baf"), "80" },
                    { new Guid("efbc5430-a15c-4e95-a04d-873cb6d19ba0"), new Guid("45a0d587-bdef-4f98-b8dc-2be45ab57848"), new Guid("36265fa7-710e-48a7-9f73-a34c84c48024"), "35" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("968c8134-a4ff-41a3-b2ef-71147fdaa9f6"), new Guid("a499d06e-b7e7-4bcc-93a8-08f50b74dc17"), null, "Ilya's sweet tomino" },
                    { new Guid("ca7cd240-5ea4-4cb8-8887-83d85f17ee11"), new Guid("a499d06e-b7e7-4bcc-93a8-08f50b74dc17"), null, "Anton's tasty tomino" }
                });
        }
    }
}
