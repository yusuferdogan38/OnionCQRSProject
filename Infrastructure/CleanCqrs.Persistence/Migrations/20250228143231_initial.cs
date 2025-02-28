using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanCqrs.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Priorty = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(4902), false, "Garden" },
                    { 2, new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(4909), true, "Games" },
                    { 3, new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(4948), false, "Kids & Jewelery" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(6578), false, "Elektrik", 0, 1 },
                    { 2, new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(6580), false, "Moda", 0, 2 },
                    { 3, new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(6581), false, "Bilgisayar", 1, 1 },
                    { 4, new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(6582), false, "Kadın", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 28, 17, 32, 31, 687, DateTimeKind.Local).AddTicks(7038), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", false, "Sıfat masaya ut quia ab patlıcan hesap aut mi ipsam." },
                    { 2, 2, new DateTime(2025, 2, 28, 17, 32, 31, 687, DateTimeKind.Local).AddTicks(7070), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", false, "Odit dağılımı velit incidunt voluptas dolayı." },
                    { 3, 3, new DateTime(2025, 2, 28, 17, 32, 31, 687, DateTimeKind.Local).AddTicks(7094), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Sıfat enim domates dolore sıfat ipsum." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedDate", "Description", "Discount", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 2, 28, 17, 32, 31, 688, DateTimeKind.Local).AddTicks(7032), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 88.583263934813218m, false, "Practical Metal Fish", 22.7781631722230416m },
                    { 2, 2, null, new DateTime(2025, 2, 28, 17, 32, 31, 688, DateTimeKind.Local).AddTicks(7054), "The Football Is Good For Training And Recreational Purposes", 88.668658005556375m, false, "Intelligent Granite Pants", 94.3957668242620576m },
                    { 3, 3, null, new DateTime(2025, 2, 28, 17, 32, 31, 688, DateTimeKind.Local).AddTicks(7071), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 37.075960931437504m, false, "Handcrafted Granite Bacon", 197.273668276912672m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
