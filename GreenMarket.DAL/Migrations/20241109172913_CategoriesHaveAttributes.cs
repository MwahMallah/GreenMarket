using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesHaveAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80261e76-71d6-4f85-baec-73dd48dd4419"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06ac1c7e-5316-4d97-8974-f6e992a28eed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("120cceda-ac17-4b70-94e0-02a0b8e02398"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("987a4be3-3de2-4b36-b745-1befa66b1d07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1c3f47e-0859-4925-bd42-d0dcb809ea71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a962d78c-02f4-4aeb-94a1-47d75201473c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0eabe5de-01c1-4fa5-a54a-e396f7091873"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58ddd58c-c219-4295-9130-3ee7926c87a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec0dbbdc-275a-4828-b25d-9dcf07fd94ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f293feec-09d9-4342-912a-57f69252b622"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a455230-4da9-4a10-975b-0f3592280dda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3"));

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attributes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttribute",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttribute_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductAttribute_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_CategoryId",
                table: "Attributes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttribute_AttributeId",
                table: "ProductAttribute",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttribute_ProductId",
                table: "ProductAttribute",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAttribute");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("082734a9-50c6-44b3-9c18-c49afa6a40bc"));

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
                keyValue: new Guid("ce3caf1b-1ef8-441f-8156-4e02800ea623"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd48a2cd-a11e-4b52-8e2d-61522ea7847f"));

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("232938c7-19b2-4699-9feb-742b16afa8d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("280765e9-02ae-4d0e-aa30-0c7a37ce0ac0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84e75880-9316-49d3-8e15-d3ee428d4ad1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec4bd7b8-0010-4cc3-bb94-b5f99c14e132"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47efb8d9-7b70-4d59-892a-6c3249e73610"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcc9eb06-d6a5-487d-8948-7d4bd9322f2c"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("3a455230-4da9-4a10-975b-0f3592280dda"), "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature_thumb.jpg?sfvrsn=7abe71fe_4", "Fruits", null },
                    { new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3"), "https://cdn.britannica.com/17/196817-159-9E487F15/vegetables.jpg", "Vegetables", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImgUrl", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("0eabe5de-01c1-4fa5-a54a-e396f7091873"), "", "admin", "admin", 0, "admin" },
                    { new Guid("58ddd58c-c219-4295-9130-3ee7926c87a6"), "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg", "Anton", "123456", 1, "AntonHavl" },
                    { new Guid("ec0dbbdc-275a-4828-b25d-9dcf07fd94ef"), "https://cdn.pixabay.com/photo/2021/09/20/09/17/dog-6640280_1280.jpg", "Nastya", "1234", 1, "NastyaMiro" },
                    { new Guid("f293feec-09d9-4342-912a-57f69252b622"), "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_3x4.jpg", "Maksim", "123", 1, "MaksimDubr" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&s", "Tomato", new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3") },
                    { new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"), "https://btiscience.org/wp-content/uploads/US-Watermelon-Varieties_600dpi.jpg", "Watermelon", new Guid("3a455230-4da9-4a10-975b-0f3592280dda") },
                    { new Guid("80261e76-71d6-4f85-baec-73dd48dd4419"), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1200px-Patates.jpg", "Potato", new Guid("ee4ddd7b-eb68-4782-9ea4-e825fdb1e0d3") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("06ac1c7e-5316-4d97-8974-f6e992a28eed"), new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"), "Augusta" },
                    { new Guid("120cceda-ac17-4b70-94e0-02a0b8e02398"), new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"), "Happy family" },
                    { new Guid("987a4be3-3de2-4b36-b745-1befa66b1d07"), new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"), "Roma" },
                    { new Guid("a1c3f47e-0859-4925-bd42-d0dcb809ea71"), new Guid("56987bd2-b5f2-432b-95f8-9cd4d6e4cf10"), "Tomino" },
                    { new Guid("a962d78c-02f4-4aeb-94a1-47d75201473c"), new Guid("637c997a-fafa-4691-bdfd-9b9a28f804ba"), "Dragon King" }
                });
        }
    }
}
