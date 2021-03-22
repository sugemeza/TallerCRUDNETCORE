using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TallerCRUDNETCORE.Migrations
{
    public partial class Cambiar_Clumna_FechaIngreso_A_DateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Productos");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "Productos",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Productos");

            migrationBuilder.AddColumn<double>(
                name: "FechaIngreso",
                table: "Productos",
                nullable: false);
        }
    }
}
