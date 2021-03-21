using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerCRUDNETCORE.Migrations
{
    public partial class SeagregaNITalaclaseproveedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nit",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "Nit",
                table: "Proveedores",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nit",
                table: "Proveedores");

            migrationBuilder.AddColumn<int>(
                name: "Nit",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
