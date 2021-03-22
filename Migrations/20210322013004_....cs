using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerCRUDNETCORE.Migrations
{
    public partial class _ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "FechaIngreso",
                table: "Productos",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaIngreso",
                table: "Productos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
