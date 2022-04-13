using Microsoft.EntityFrameworkCore.Migrations;

namespace fullClean.Migrations
{
    public partial class migracionSales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Cart_id",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Sales",
                newName: "salesId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cart",
                newName: "cartId");

            migrationBuilder.AlterColumn<int>(
                name: "salesId",
                table: "Sales",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "cartId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_cartId",
                table: "Sales",
                column: "cartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Cart_cartId",
                table: "Sales",
                column: "cartId",
                principalTable: "Cart",
                principalColumn: "cartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Cart_cartId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_cartId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "cartId",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "salesId",
                table: "Sales",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "cartId",
                table: "Cart",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Sales",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Cart_id",
                table: "Sales",
                column: "id",
                principalTable: "Cart",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
