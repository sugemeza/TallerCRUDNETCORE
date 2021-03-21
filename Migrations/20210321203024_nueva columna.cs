using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerCRUDNETCORE.Migrations
{
    public partial class nuevacolumna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nit",
                table: "Productos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nit",
                table: "Productos");
        }
    }
}
