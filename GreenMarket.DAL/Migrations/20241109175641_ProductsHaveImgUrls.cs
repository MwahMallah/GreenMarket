using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductsHaveImgUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("542661cd-dfa5-4cc2-9ccf-f180315724f0"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("546ef8cb-1206-49c2-bd23-3fdc7d3db0e2"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("7928cb94-dce4-473c-b73a-23870d152bd8"));

            migrationBuilder.DeleteData(
                table: "ProductAttribute",
                keyColumn: "Id",
                keyValue: new Guid("886cdd52-5dbb-4433-b859-eed01e6801bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("082734a9-50c6-44b3-9c18-c49afa6a40bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b18c3fab-ea16-4d5b-83cd-e5c8bb05e6d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6c54c3c-c25d-421c-97ba-1fb19d178abe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c779c813-aced-4691-a1ac-a10b70faac39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f758f733-4232-4f7c-9ca9-df6eb587ea43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("765b4018-4bf2-4ae3-a784-961216df9265"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a1ea4aa-94d0-481d-b615-a47f619adf89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("caf1746e-4cb2-4c27-9c77-6c72e59dc6aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9015890-2667-425a-b43b-df958d8b5068"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("811e7648-d5eb-49e8-8113-19d95b94e21e"));

            migrationBuilder.DeleteData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: new Guid("b66b0160-e13a-45a2-af13-7d0e748a8b4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("280765e9-02ae-4d0e-aa30-0c7a37ce0ac0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1eeed1fa-0b5b-4b63-9b51-66b59e34c7df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f22789e-fc72-4f71-ac51-85ca703a76dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce3caf1b-1ef8-441f-8156-4e02800ea623"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd48a2cd-a11e-4b52-8e2d-61522ea7847f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47efb8d9-7b70-4d59-892a-6c3249e73610"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcc9eb06-d6a5-487d-8948-7d4bd9322f2c"));

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("47efb8d9-7b70-4d59-892a-6c3249e73610"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", null },
                    { new Guid("fcc9eb06-d6a5-487d-8948-7d4bd9322f2c"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("765b4018-4bf2-4ae3-a784-961216df9265"), "", "admin", "admin", 0, "admin" },
                    { new Guid("7a1ea4aa-94d0-481d-b615-a47f619adf89"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" },
                    { new Guid("caf1746e-4cb2-4c27-9c77-6c72e59dc6aa"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("e9015890-2667-425a-b43b-df958d8b5068"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("fcc9eb06-d6a5-487d-8948-7d4bd9322f2c") },
                    { new Guid("280765e9-02ae-4d0e-aa30-0c7a37ce0ac0"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("fcc9eb06-d6a5-487d-8948-7d4bd9322f2c") },
                    { new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s", "Avocado", new Guid("47efb8d9-7b70-4d59-892a-6c3249e73610") },
                    { new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("47efb8d9-7b70-4d59-892a-6c3249e73610") }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("811e7648-d5eb-49e8-8113-19d95b94e21e"), new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"), "Price/piece" },
                    { new Guid("b66b0160-e13a-45a2-af13-7d0e748a8b4a"), new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"), "Price/kg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("082734a9-50c6-44b3-9c18-c49afa6a40bc"), new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"), "Augusta" },
                    { new Guid("1eeed1fa-0b5b-4b63-9b51-66b59e34c7df"), new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"), "Fuerte" },
                    { new Guid("6f22789e-fc72-4f71-ac51-85ca703a76dc"), new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"), "Russet" },
                    { new Guid("b18c3fab-ea16-4d5b-83cd-e5c8bb05e6d1"), new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"), "Happy family" },
                    { new Guid("c6c54c3c-c25d-421c-97ba-1fb19d178abe"), new Guid("280765e9-02ae-4d0e-aa30-0c7a37ce0ac0"), "Tomino" },
                    { new Guid("c779c813-aced-4691-a1ac-a10b70faac39"), new Guid("280765e9-02ae-4d0e-aa30-0c7a37ce0ac0"), "Roma" },
                    { new Guid("ce3caf1b-1ef8-441f-8156-4e02800ea623"), new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"), "Gwen" },
                    { new Guid("dd48a2cd-a11e-4b52-8e2d-61522ea7847f"), new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"), "Orange sweet" },
                    { new Guid("f758f733-4232-4f7c-9ca9-df6eb587ea43"), new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"), "Dragon King" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttribute",
                columns: new[] { "Id", "AttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("542661cd-dfa5-4cc2-9ccf-f180315724f0"), new Guid("811e7648-d5eb-49e8-8113-19d95b94e21e"), new Guid("ce3caf1b-1ef8-441f-8156-4e02800ea623"), "35" },
                    { new Guid("546ef8cb-1206-49c2-bd23-3fdc7d3db0e2"), new Guid("b66b0160-e13a-45a2-af13-7d0e748a8b4a"), new Guid("6f22789e-fc72-4f71-ac51-85ca703a76dc"), "100" },
                    { new Guid("7928cb94-dce4-473c-b73a-23870d152bd8"), new Guid("811e7648-d5eb-49e8-8113-19d95b94e21e"), new Guid("1eeed1fa-0b5b-4b63-9b51-66b59e34c7df"), "25" },
                    { new Guid("886cdd52-5dbb-4433-b859-eed01e6801bf"), new Guid("b66b0160-e13a-45a2-af13-7d0e748a8b4a"), new Guid("dd48a2cd-a11e-4b52-8e2d-61522ea7847f"), "80" }
                });
        }
    }
}
