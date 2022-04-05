using Microsoft.EntityFrameworkCore.Migrations;

namespace fullClean.Migrations
{
    public partial class nuevaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "nameproduct");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "detailproduct");

            migrationBuilder.AddColumn<string>(
                name: "codproduct",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stockstore",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stockwarehouse",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codproduct",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "stockstore",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "stockwarehouse",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "nameproduct",
                table: "Products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "detailproduct",
                table: "Products",
                newName: "description");
        }
    }
}
