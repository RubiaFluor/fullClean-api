using Microsoft.EntityFrameworkCore.Migrations;

namespace fullClean.Migrations
{
    public partial class migracionSales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codproduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    detailproduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameproduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    stockstore = table.Column<int>(type: "int", nullable: false),
                    stockwarehouse = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    salesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codproduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    detailproduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameproduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.salesId);
                });

            migrationBuilder.CreateTable(
                name: "SalesAndProducts",
                columns: table => new
                {
                    Idproducts = table.Column<int>(type: "int", nullable: false),
                    Idsales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesAndProducts", x => new { x.Idproducts, x.Idsales });
                    table.ForeignKey(
                        name: "FK_SalesAndProducts_Products_Idproducts",
                        column: x => x.Idproducts,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesAndProducts_Sales_Idsales",
                        column: x => x.Idsales,
                        principalTable: "Sales",
                        principalColumn: "salesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesAndProducts_Idsales",
                table: "SalesAndProducts",
                column: "Idsales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesAndProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
