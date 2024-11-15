using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class OrdersHaveRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d009112-918d-479e-bec5-46bc08310b1c"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("12c30319-5d71-4302-b129-dc4c90e0ce56"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("14dca921-49c6-423a-8f03-96c72463d793"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("1ab9ccd9-7c68-40f6-bf7a-9f110d678c02"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3009c2de-a4f7-4bed-86c2-99a545437f30"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("e771ce0b-8c02-49f2-8a4f-c42645ba0e84"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("ff82e93d-c5cc-4493-b667-8253638111a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aa15e4e-1ce5-44b0-b234-bf100e0ebcd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("217f09bd-7ff3-47f2-b8e7-8afaa68ede05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27cec6b1-3584-48b5-b2d8-9c19c6d59673"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d292fc0-d93b-44fd-b764-d2ca42ff30c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86e3f8c1-90b1-4abe-938b-8a1976d6e3bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a94c7d7-2460-46e2-a93b-530341af2ff3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58bc5fa6-b25a-4d29-a30d-e2ec59639dd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0ecb2cc-21f8-4229-be28-84477b39c384"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4a2bcee-845d-48f4-a6ca-3066ba33b15e"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("3ac5e66e-75a0-46da-8f4b-b82fd750c710"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("b06d1604-d958-46fe-beac-a7e63cd5243a"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("cd8c1701-c3ed-436e-be59-6e47f15358e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6dd81d26-12e8-49bb-9be6-749593da15df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b9aa1e-8d9a-49e3-ae0c-2f018378e882"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("621fb335-8cbf-4594-8b36-437981e8c8e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74c7e97b-c13e-4136-a889-34b3f04485c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("891ec03e-4425-4207-9322-f4d71f017341"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd2a0ab3-d940-4e82-83e0-1234b22c15e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c2fc6e6-eb91-47ec-a553-cc768f6508ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3f8d5cf-8c55-4e26-a890-5c6d6aa38d2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb034bf2-76be-4b77-a7d7-a215cdb533cd"));

            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "UserOrderEntity",
                type: "real",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("9183ee53-5efe-4851-a503-02e0132264c8"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("7e1cd981-efbc-4dbc-a959-a1bd49845f7b"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("cfa864cf-ff9e-47d7-9bdd-41ff87361b43"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("e6e28cdf-f7ec-419b-9f81-3df298df81fb"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("fbbde8e2-3599-475a-8f78-dbd3baa5ead1"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("2e22dd47-bf63-4464-aa0e-1b29798831c5"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("9183ee53-5efe-4851-a503-02e0132264c8") },
                    { new Guid("777060b8-90ac-4a95-ac86-07bd43814878"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("9183ee53-5efe-4851-a503-02e0132264c8") },
                    { new Guid("6ca8c993-360b-4a10-b24c-3123e5d174b0"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("2e22dd47-bf63-4464-aa0e-1b29798831c5") },
                    { new Guid("9ba7c5e4-710f-473f-ac52-f9609601c5b3"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("777060b8-90ac-4a95-ac86-07bd43814878") },
                    { new Guid("c5c1f602-dc98-4c3b-aec9-1f9f764adc46"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("777060b8-90ac-4a95-ac86-07bd43814878") },
                    { new Guid("cbb3ea06-aa61-4d87-9864-4442069d5efc"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("2e22dd47-bf63-4464-aa0e-1b29798831c5") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("4be39cfc-4317-4091-961a-cc314d54cecb"), new Guid("cbb3ea06-aa61-4d87-9864-4442069d5efc"), "Place of origin" },
                    { new Guid("4ea7c823-b57c-475e-9530-45c8e4032692"), new Guid("c5c1f602-dc98-4c3b-aec9-1f9f764adc46"), "Price/kg" },
                    { new Guid("9fd17449-bda7-433b-8005-19c8b597f287"), new Guid("cbb3ea06-aa61-4d87-9864-4442069d5efc"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("c3ab45d8-8281-4cb0-a934-6fc3bac1a66a"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("9ba7c5e4-710f-473f-ac52-f9609601c5b3") },
                    { new Guid("f6cb6bb2-08e3-475a-8284-4763e1c03169"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("9ba7c5e4-710f-473f-ac52-f9609601c5b3") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("448ed780-2af5-4831-b761-f09b8f847451"), new Guid("6ca8c993-360b-4a10-b24c-3123e5d174b0"), null, null, "Augusta" },
                    { new Guid("75fddc21-dafd-4166-82c0-46f4bc5fd494"), new Guid("cbb3ea06-aa61-4d87-9864-4442069d5efc"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("7d17c51c-bba7-4590-a556-f514e051d86d"), new Guid("6ca8c993-360b-4a10-b24c-3123e5d174b0"), null, null, "Happy family" },
                    { new Guid("92692599-876f-471f-815a-e925e3436905"), new Guid("c5c1f602-dc98-4c3b-aec9-1f9f764adc46"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" },
                    { new Guid("bd4d59cc-135b-44ce-bf15-60aabc4697da"), new Guid("6ca8c993-360b-4a10-b24c-3123e5d174b0"), null, null, "Dragon King" },
                    { new Guid("d16d4968-3909-4111-9caa-7e2fd04831b9"), new Guid("cbb3ea06-aa61-4d87-9864-4442069d5efc"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("fc510c4d-4503-4e16-bec0-a90785ec26ac"), new Guid("c5c1f602-dc98-4c3b-aec9-1f9f764adc46"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("07b39593-7aa9-4f4d-83a2-234f8b24afc6"), new Guid("4ea7c823-b57c-475e-9530-45c8e4032692"), new Guid("92692599-876f-471f-815a-e925e3436905"), "100" },
                    { new Guid("3afdd37a-3eb6-495e-9331-70eb1ceda30f"), new Guid("4ea7c823-b57c-475e-9530-45c8e4032692"), new Guid("fc510c4d-4503-4e16-bec0-a90785ec26ac"), "80" },
                    { new Guid("3ea1d554-d749-43e1-b24f-3941c5050adf"), new Guid("9fd17449-bda7-433b-8005-19c8b597f287"), new Guid("d16d4968-3909-4111-9caa-7e2fd04831b9"), "25" },
                    { new Guid("4b973f21-ecea-4975-8fb8-159d7b2eb454"), new Guid("9fd17449-bda7-433b-8005-19c8b597f287"), new Guid("75fddc21-dafd-4166-82c0-46f4bc5fd494"), "35" },
                    { new Guid("625a327b-f59b-4f07-af7b-75787cc55292"), new Guid("4be39cfc-4317-4091-961a-cc314d54cecb"), new Guid("d16d4968-3909-4111-9caa-7e2fd04831b9"), "Czechia" },
                    { new Guid("68287ad2-8b51-4b4e-86dc-e5b5ad8747e7"), new Guid("4be39cfc-4317-4091-961a-cc314d54cecb"), new Guid("75fddc21-dafd-4166-82c0-46f4bc5fd494"), "Puerto Rico" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("017d850f-81e9-400e-a372-737a393b5091"), new Guid("f6cb6bb2-08e3-475a-8284-4763e1c03169"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" },
                    { new Guid("a8f78292-128b-4585-9be1-a8bd8a9edc79"), new Guid("f6cb6bb2-08e3-475a-8284-4763e1c03169"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3ab45d8-8281-4cb0-a934-6fc3bac1a66a"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("07b39593-7aa9-4f4d-83a2-234f8b24afc6"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3afdd37a-3eb6-495e-9331-70eb1ceda30f"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("3ea1d554-d749-43e1-b24f-3941c5050adf"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("4b973f21-ecea-4975-8fb8-159d7b2eb454"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("625a327b-f59b-4f07-af7b-75787cc55292"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("68287ad2-8b51-4b4e-86dc-e5b5ad8747e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("017d850f-81e9-400e-a372-737a393b5091"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("448ed780-2af5-4831-b761-f09b8f847451"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d17c51c-bba7-4590-a556-f514e051d86d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8f78292-128b-4585-9be1-a8bd8a9edc79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd4d59cc-135b-44ce-bf15-60aabc4697da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e1cd981-efbc-4dbc-a959-a1bd49845f7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfa864cf-ff9e-47d7-9bdd-41ff87361b43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6e28cdf-f7ec-419b-9f81-3df298df81fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbbde8e2-3599-475a-8f78-dbd3baa5ead1"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("4be39cfc-4317-4091-961a-cc314d54cecb"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("4ea7c823-b57c-475e-9530-45c8e4032692"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("9fd17449-bda7-433b-8005-19c8b597f287"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ca8c993-360b-4a10-b24c-3123e5d174b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6cb6bb2-08e3-475a-8284-4763e1c03169"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75fddc21-dafd-4166-82c0-46f4bc5fd494"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92692599-876f-471f-815a-e925e3436905"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d16d4968-3909-4111-9caa-7e2fd04831b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc510c4d-4503-4e16-bec0-a90785ec26ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ba7c5e4-710f-473f-ac52-f9609601c5b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5c1f602-dc98-4c3b-aec9-1f9f764adc46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbb3ea06-aa61-4d87-9864-4442069d5efc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e22dd47-bf63-4464-aa0e-1b29798831c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("777060b8-90ac-4a95-ac86-07bd43814878"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9183ee53-5efe-4851-a503-02e0132264c8"));

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "UserOrderEntity");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[] { new Guid("bb034bf2-76be-4b77-a7d7-a215cdb533cd"), null, "Crops", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3a94c7d7-2460-46e2-a93b-530341af2ff3"), "admin@admin.com", "", "admin", "admin", 0, "admin" },
                    { new Guid("58bc5fa6-b25a-4d29-a30d-e2ec59639dd3"), "nastya@mail.com", "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("e0ecb2cc-21f8-4229-be28-84477b39c384"), "maksim@mail.com", "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("f4a2bcee-845d-48f4-a6ca-3066ba33b15e"), "anton@mail.com", "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("2c2fc6e6-eb91-47ec-a553-cc768f6508ff"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", new Guid("bb034bf2-76be-4b77-a7d7-a215cdb533cd") },
                    { new Guid("c3f8d5cf-8c55-4e26-a890-5c6d6aa38d2d"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", new Guid("bb034bf2-76be-4b77-a7d7-a215cdb533cd") },
                    { new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("c3f8d5cf-8c55-4e26-a890-5c6d6aa38d2d") },
                    { new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("2c2fc6e6-eb91-47ec-a553-cc768f6508ff") },
                    { new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("2c2fc6e6-eb91-47ec-a553-cc768f6508ff") },
                    { new Guid("bd2a0ab3-d940-4e82-83e0-1234b22c15e0"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("c3f8d5cf-8c55-4e26-a890-5c6d6aa38d2d") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("3ac5e66e-75a0-46da-8f4b-b82fd750c710"), new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"), "Price/kg" },
                    { new Guid("b06d1604-d958-46fe-beac-a7e63cd5243a"), new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "Place of origin" },
                    { new Guid("cd8c1701-c3ed-436e-be59-6e47f15358e2"), new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "Price/piece" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("6dd81d26-12e8-49bb-9be6-749593da15df"), "https://volyne.e-coop.cz/pub/media/catalog/product/cache/5e943ec86580054ec2fda73128d751b9/e/p/ep_2004800329.jpeg", "Tomino", new Guid("bd2a0ab3-d940-4e82-83e0-1234b22c15e0") },
                    { new Guid("8d009112-918d-479e-bec5-46bc08310b1c"), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSaogrbCqgly8ABLDeqzUKy3Q73FtM_p1XeKseySN5uIjauTVtz", "Roma", new Guid("bd2a0ab3-d940-4e82-83e0-1234b22c15e0") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("0aa15e4e-1ce5-44b0-b234-bf100e0ebcd5"), new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"), null, null, "Happy family" },
                    { new Guid("12b9aa1e-8d9a-49e3-ae0c-2f018378e882"), new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"), null, "https://seedlefarms.com/wp-content/uploads/2022/01/Orange-Sweet-Potatoe.jpg", "Orange sweet" },
                    { new Guid("27cec6b1-3584-48b5-b2d8-9c19c6d59673"), new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"), null, null, "Augusta" },
                    { new Guid("5d292fc0-d93b-44fd-b764-d2ca42ff30c0"), new Guid("7f4042f3-a369-44ab-9a47-42c6bf0a38ca"), null, null, "Dragon King" },
                    { new Guid("621fb335-8cbf-4594-8b36-437981e8c8e2"), new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "Gwen avocados are a variety known for their creamy texture and rich, nutty flavor. They are slightly smaller than Has avocados and have a smoother texture.", "https://www.producemarketguide.com/media/user_v1oz1Yz27j/584/gwen-avocado_variety-page.png", "Gwen" },
                    { new Guid("74c7e97b-c13e-4136-a889-34b3f04485c3"), new Guid("a4fd52d9-1792-4333-97c5-9616df5d5d23"), "Fuerte avocados are medium to large with smooth, thick skin and a mild, creamy flavor. Perfect for slicing and enjoying in salads, or on toast.", "https://www.tomorrowsharvest.com/store/pub/media/catalog/product/cache/49e19764d17a195b05fde2ec48914513/2/2/2210_fuerte_avocado_fruit-full.jpg", "Fuerte" },
                    { new Guid("891ec03e-4425-4207-9322-f4d71f017341"), new Guid("038a4032-be22-4bdd-8ae1-c0a60c7b8c6f"), null, "https://www.kroger.com/product/images/large/front/0000000004072?banner=harristeeter", "Russet" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("12c30319-5d71-4302-b129-dc4c90e0ce56"), new Guid("b06d1604-d958-46fe-beac-a7e63cd5243a"), new Guid("621fb335-8cbf-4594-8b36-437981e8c8e2"), "Puerto Rico" },
                    { new Guid("14dca921-49c6-423a-8f03-96c72463d793"), new Guid("b06d1604-d958-46fe-beac-a7e63cd5243a"), new Guid("74c7e97b-c13e-4136-a889-34b3f04485c3"), "Czechia" },
                    { new Guid("1ab9ccd9-7c68-40f6-bf7a-9f110d678c02"), new Guid("cd8c1701-c3ed-436e-be59-6e47f15358e2"), new Guid("74c7e97b-c13e-4136-a889-34b3f04485c3"), "25" },
                    { new Guid("3009c2de-a4f7-4bed-86c2-99a545437f30"), new Guid("3ac5e66e-75a0-46da-8f4b-b82fd750c710"), new Guid("891ec03e-4425-4207-9322-f4d71f017341"), "100" },
                    { new Guid("e771ce0b-8c02-49f2-8a4f-c42645ba0e84"), new Guid("cd8c1701-c3ed-436e-be59-6e47f15358e2"), new Guid("621fb335-8cbf-4594-8b36-437981e8c8e2"), "35" },
                    { new Guid("ff82e93d-c5cc-4493-b667-8253638111a4"), new Guid("3ac5e66e-75a0-46da-8f4b-b82fd750c710"), new Guid("12b9aa1e-8d9a-49e3-ae0c-2f018378e882"), "80" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("217f09bd-7ff3-47f2-b8e7-8afaa68ede05"), new Guid("6dd81d26-12e8-49bb-9be6-749593da15df"), "A sweet and smooth tomino, offering a unique balance of sweetness and creaminess.", null, "Anton's tasty tomino" },
                    { new Guid("86e3f8c1-90b1-4abe-938b-8a1976d6e3bf"), new Guid("6dd81d26-12e8-49bb-9be6-749593da15df"), "A delicious, creamy tomino with a rich, savory flavor. Perfect for any tomato lover!", null, "Ilya's sweet tomino" }
                });
        }
    }
}
