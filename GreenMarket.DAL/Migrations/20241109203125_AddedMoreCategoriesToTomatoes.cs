using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreCategoriesToTomatoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("1f85aa03-b7fe-4fd5-ab35-c25cd6772955"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("4c73c95f-8efc-49aa-b4b8-520a3879072e"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("51a93020-5ceb-49b9-ba25-e96b8fdd4970"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("a6bd6f2f-51da-4075-bd4b-9d545cb48f72"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("b5219cea-df72-463c-b644-40f2a4701954"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("f8b1b165-f080-4d68-864c-2bc284d7d4b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08d63d42-1032-41cd-81b5-66a97c0c66d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c3017ab-b43f-4bc8-a763-d2fcdaf60fd9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b0938e0-ec4e-447b-ac27-d829e2bdfab6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58bdfc07-4404-4f06-88c6-23cc17ed62f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("941ca9b6-5654-46de-820e-4f189838126f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1449438f-f8f2-4958-bb58-4c259de65f0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf1ce0b1-d882-47e0-9947-ffb77ed5838a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5cb2cd6-e06a-40ac-9cc2-6163c3416a1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbc32452-07c6-47c2-9914-c9dc2faafb82"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("032a4715-8260-4e22-bb03-c2a7bbb8e5b0"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("1aff430a-6614-4a91-b6ff-839ecbeac7b2"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("a102ba05-bee3-406c-b02f-b77e36af1987"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95fec787-8db3-4a8b-aee8-6bfec64311e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b793b452-2f03-46a4-b679-149c5249d07e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e548abe-d617-49b7-85fd-267dae7337ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e91383c-08c9-4a14-ad57-82c450df998c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7768ddc1-4caa-45ec-8374-7f158481c877"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9dda070-2b2c-4324-acbd-c9fa2f5b3596"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16c56f11-e1e7-4c53-9f2a-5b4c30c4e858"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fece3f8f-0c7d-49e7-ae20-ef021c6874b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0559fc6c-0fb4-49f1-8c6e-abf288d2d866"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6332a795-0be6-4da1-9d3a-e37235093697"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0559fc6c-0fb4-49f1-8c6e-abf288d2d866"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", null },
                    { new Guid("6332a795-0be6-4da1-9d3a-e37235093697"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("1449438f-f8f2-4958-bb58-4c259de65f0a"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("bf1ce0b1-d882-47e0-9947-ffb77ed5838a"), "", "admin", "admin", 0, "admin" },
                    { new Guid("c5cb2cd6-e06a-40ac-9cc2-6163c3416a1e"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("cbc32452-07c6-47c2-9914-c9dc2faafb82"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("16c56f11-e1e7-4c53-9f2a-5b4c30c4e858"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("0559fc6c-0fb4-49f1-8c6e-abf288d2d866") },
                    { new Guid("95fec787-8db3-4a8b-aee8-6bfec64311e5"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("0559fc6c-0fb4-49f1-8c6e-abf288d2d866") },
                    { new Guid("b793b452-2f03-46a4-b679-149c5249d07e"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("6332a795-0be6-4da1-9d3a-e37235093697") },
                    { new Guid("fece3f8f-0c7d-49e7-ae20-ef021c6874b1"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("6332a795-0be6-4da1-9d3a-e37235093697") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("032a4715-8260-4e22-bb03-c2a7bbb8e5b0"), new Guid("16c56f11-e1e7-4c53-9f2a-5b4c30c4e858"), "Price/piece" },
                    { new Guid("1aff430a-6614-4a91-b6ff-839ecbeac7b2"), new Guid("fece3f8f-0c7d-49e7-ae20-ef021c6874b1"), "Price/kg" },
                    { new Guid("a102ba05-bee3-406c-b02f-b77e36af1987"), new Guid("16c56f11-e1e7-4c53-9f2a-5b4c30c4e858"), "Place of origin" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("08d63d42-1032-41cd-81b5-66a97c0c66d3"), new Guid("95fec787-8db3-4a8b-aee8-6bfec64311e5"), null, "Augusta" },
                    { new Guid("0c3017ab-b43f-4bc8-a763-d2fcdaf60fd9"), new Guid("b793b452-2f03-46a4-b679-149c5249d07e"), null, "Roma" },
                    { new Guid("0e548abe-d617-49b7-85fd-267dae7337ae"), new Guid("16c56f11-e1e7-4c53-9f2a-5b4c30c4e858"), "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("2b0938e0-ec4e-447b-ac27-d829e2bdfab6"), new Guid("b793b452-2f03-46a4-b679-149c5249d07e"), null, "Tomino" },
                    { new Guid("58bdfc07-4404-4f06-88c6-23cc17ed62f3"), new Guid("95fec787-8db3-4a8b-aee8-6bfec64311e5"), null, "Dragon King" },
                    { new Guid("5e91383c-08c9-4a14-ad57-82c450df998c"), new Guid("fece3f8f-0c7d-49e7-ae20-ef021c6874b1"), "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("7768ddc1-4caa-45ec-8374-7f158481c877"), new Guid("16c56f11-e1e7-4c53-9f2a-5b4c30c4e858"), "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("941ca9b6-5654-46de-820e-4f189838126f"), new Guid("95fec787-8db3-4a8b-aee8-6bfec64311e5"), null, "Happy family" },
                    { new Guid("a9dda070-2b2c-4324-acbd-c9fa2f5b3596"), new Guid("fece3f8f-0c7d-49e7-ae20-ef021c6874b1"), "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("1f85aa03-b7fe-4fd5-ab35-c25cd6772955"), new Guid("1aff430a-6614-4a91-b6ff-839ecbeac7b2"), new Guid("a9dda070-2b2c-4324-acbd-c9fa2f5b3596"), "100" },
                    { new Guid("4c73c95f-8efc-49aa-b4b8-520a3879072e"), new Guid("032a4715-8260-4e22-bb03-c2a7bbb8e5b0"), new Guid("7768ddc1-4caa-45ec-8374-7f158481c877"), "25" },
                    { new Guid("51a93020-5ceb-49b9-ba25-e96b8fdd4970"), new Guid("a102ba05-bee3-406c-b02f-b77e36af1987"), new Guid("7768ddc1-4caa-45ec-8374-7f158481c877"), "Czechia" },
                    { new Guid("a6bd6f2f-51da-4075-bd4b-9d545cb48f72"), new Guid("a102ba05-bee3-406c-b02f-b77e36af1987"), new Guid("0e548abe-d617-49b7-85fd-267dae7337ae"), "Puerto Rico" },
                    { new Guid("b5219cea-df72-463c-b644-40f2a4701954"), new Guid("1aff430a-6614-4a91-b6ff-839ecbeac7b2"), new Guid("5e91383c-08c9-4a14-ad57-82c450df998c"), "80" },
                    { new Guid("f8b1b165-f080-4d68-864c-2bc284d7d4b1"), new Guid("032a4715-8260-4e22-bb03-c2a7bbb8e5b0"), new Guid("0e548abe-d617-49b7-85fd-267dae7337ae"), "35" }
                });
        }
    }
}
