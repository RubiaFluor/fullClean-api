using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fullClean.Migrations
{
    public partial class SalesAndProductsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesAndProducts",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    SalesId = table.Column<int>(type: "int", nullable: false),
                    dateSale = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesAndProducts", x => new { x.ProductsId, x.SalesId });
                    table.ForeignKey(
                        name: "FK_SalesAndProducts_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesAndProducts_Sale_SalesId",
                        column: x => x.SalesId,
                        principalTable: "Sale",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesAndProducts_SalesId",
                table: "SalesAndProducts",
                column: "SalesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesAndProducts");
        }
    }
}
