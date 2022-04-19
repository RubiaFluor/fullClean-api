using Microsoft.EntityFrameworkCore.Migrations;

namespace fullClean.Migrations
{
    public partial class SalesAndProductsQuantityValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantityProduct",
                table: "SalesAndProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityProduct",
                table: "SalesAndProducts");
        }
    }
}
