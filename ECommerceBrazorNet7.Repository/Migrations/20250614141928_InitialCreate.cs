using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceBrazorNet7.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    IdCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameCategory = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Category__CBD7470656E4333D", x => x.IdCategory);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__B7C926388D2AF984", x => x.IdUser);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameProduct = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCategory = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    OfferPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Picture = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product__2E8946D4A9CE6714", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK__Product__IdCateg__4CA06362",
                        column: x => x.IdCategory,
                        principalTable: "Category",
                        principalColumn: "IdCategory");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    IdSale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idUser = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sale__A04F9B379C9168FF", x => x.IdSale);
                    table.ForeignKey(
                        name: "FK__Sale__idUser__534D60F1",
                        column: x => x.idUser,
                        principalTable: "Users",
                        principalColumn: "IdUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SalesDetail",
                columns: table => new
                {
                    IdSalesDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdSale = table.Column<int>(type: "int", nullable: true),
                    IdProduct = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SalesDet__3388DAF143CA7770", x => x.IdSalesDetail);
                    table.ForeignKey(
                        name: "FK__SalesDeta__IdPro__5812160E",
                        column: x => x.IdProduct,
                        principalTable: "Product",
                        principalColumn: "IdProduct");
                    table.ForeignKey(
                        name: "FK__SalesDeta__IdSal__571DF1D5",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "IdSale");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IdCategory",
                table: "Product",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_idUser",
                table: "Sale",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetail_IdProduct",
                table: "SalesDetail",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetail_IdSale",
                table: "SalesDetail",
                column: "IdSale");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesDetail");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
