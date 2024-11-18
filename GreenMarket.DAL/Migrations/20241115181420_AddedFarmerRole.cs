using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedFarmerRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
