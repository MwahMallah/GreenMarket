using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedPlaceOfOriginAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("0ceef933-0458-470f-bc74-62da64fffadd"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("12729583-67c1-4a9f-8cbe-5ba16f06a11d"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("2713060b-0807-462b-978b-c3d3653800db"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3732c5a9-b2f2-4e18-828b-94725aae9093"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1240e823-8ee0-4809-9a10-64a723bdc8f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d10ee4e-4d3b-419b-a3c1-25a35121cb79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a720a29-b722-4cd6-9d69-aa47571b7d82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd81bc78-6b33-4a23-91ce-1e5fd46e0a04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de29f3ea-83c9-4b21-b431-434a7fb7d4bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27bcec7d-6261-4568-8bbf-09b815aad2e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7a8b30a-a1a9-4acf-ab92-f9b225a8bb72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a93a480c-a50e-4ad8-9b79-5884aba4f9bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bae1c300-271f-44ae-87a0-4743d9a345bd"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("45649f5b-e0e2-4606-a335-a6855c8b1218"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("8e7cb442-a5f3-46d4-b59f-6f3568a63a98"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30f24293-1a0c-422c-bb27-fb001bd508e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdd3cc74-7c12-4c6b-bf98-2d35df758695"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f183fe6-03c3-42ec-8d9c-081498ae9519"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c2ebf20-8857-4818-bc56-2f14e18c2ec5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("849aab23-8c3b-40ab-814d-657091d5416d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1e89f98-9745-4696-bf16-638bd9abdab3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bacc0e30-31d8-4567-adfb-5346f21e507f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d139c55f-f6f1-4bc6-ad49-acc0e40ef2aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32d53241-d232-4c56-9910-267f106a4c66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b67b76c-1cd7-4f4c-bd4d-c658bbb1d8d8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("32d53241-d232-4c56-9910-267f106a4c66"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", null },
                    { new Guid("6b67b76c-1cd7-4f4c-bd4d-c658bbb1d8d8"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("27bcec7d-6261-4568-8bbf-09b815aad2e3"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("a7a8b30a-a1a9-4acf-ab92-f9b225a8bb72"), "", "admin", "admin", 0, "admin" },
                    { new Guid("a93a480c-a50e-4ad8-9b79-5884aba4f9bf"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("bae1c300-271f-44ae-87a0-4743d9a345bd"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("30f24293-1a0c-422c-bb27-fb001bd508e4"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("32d53241-d232-4c56-9910-267f106a4c66") },
                    { new Guid("bacc0e30-31d8-4567-adfb-5346f21e507f"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("6b67b76c-1cd7-4f4c-bd4d-c658bbb1d8d8") },
                    { new Guid("cdd3cc74-7c12-4c6b-bf98-2d35df758695"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("6b67b76c-1cd7-4f4c-bd4d-c658bbb1d8d8") },
                    { new Guid("d139c55f-f6f1-4bc6-ad49-acc0e40ef2aa"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("32d53241-d232-4c56-9910-267f106a4c66") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("45649f5b-e0e2-4606-a335-a6855c8b1218"), new Guid("bacc0e30-31d8-4567-adfb-5346f21e507f"), "Price/kg" },
                    { new Guid("8e7cb442-a5f3-46d4-b59f-6f3568a63a98"), new Guid("d139c55f-f6f1-4bc6-ad49-acc0e40ef2aa"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("0f183fe6-03c3-42ec-8d9c-081498ae9519"), new Guid("d139c55f-f6f1-4bc6-ad49-acc0e40ef2aa"), "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("1240e823-8ee0-4809-9a10-64a723bdc8f5"), new Guid("30f24293-1a0c-422c-bb27-fb001bd508e4"), null, "Augusta" },
                    { new Guid("3c2ebf20-8857-4818-bc56-2f14e18c2ec5"), new Guid("bacc0e30-31d8-4567-adfb-5346f21e507f"), "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("4d10ee4e-4d3b-419b-a3c1-25a35121cb79"), new Guid("cdd3cc74-7c12-4c6b-bf98-2d35df758695"), null, "Tomino" },
                    { new Guid("849aab23-8c3b-40ab-814d-657091d5416d"), new Guid("d139c55f-f6f1-4bc6-ad49-acc0e40ef2aa"), "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("9a720a29-b722-4cd6-9d69-aa47571b7d82"), new Guid("30f24293-1a0c-422c-bb27-fb001bd508e4"), null, "Happy family" },
                    { new Guid("dd81bc78-6b33-4a23-91ce-1e5fd46e0a04"), new Guid("30f24293-1a0c-422c-bb27-fb001bd508e4"), null, "Dragon King" },
                    { new Guid("de29f3ea-83c9-4b21-b431-434a7fb7d4bd"), new Guid("cdd3cc74-7c12-4c6b-bf98-2d35df758695"), null, "Roma" },
                    { new Guid("f1e89f98-9745-4696-bf16-638bd9abdab3"), new Guid("bacc0e30-31d8-4567-adfb-5346f21e507f"), "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("0ceef933-0458-470f-bc74-62da64fffadd"), new Guid("45649f5b-e0e2-4606-a335-a6855c8b1218"), new Guid("3c2ebf20-8857-4818-bc56-2f14e18c2ec5"), "80" },
                    { new Guid("12729583-67c1-4a9f-8cbe-5ba16f06a11d"), new Guid("8e7cb442-a5f3-46d4-b59f-6f3568a63a98"), new Guid("849aab23-8c3b-40ab-814d-657091d5416d"), "25" },
                    { new Guid("2713060b-0807-462b-978b-c3d3653800db"), new Guid("8e7cb442-a5f3-46d4-b59f-6f3568a63a98"), new Guid("0f183fe6-03c3-42ec-8d9c-081498ae9519"), "35" },
                    { new Guid("3732c5a9-b2f2-4e18-828b-94725aae9093"), new Guid("45649f5b-e0e2-4606-a335-a6855c8b1218"), new Guid("f1e89f98-9745-4696-bf16-638bd9abdab3"), "100" }
                });
        }
    }
}
