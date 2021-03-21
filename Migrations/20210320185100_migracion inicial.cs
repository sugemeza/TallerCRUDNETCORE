using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerCRUDNETCORE.Migrations
{
    public partial class migracioninicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    PersonaContacto = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", proveedor => proveedor.ProveedorId);
                }
           );

           migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    FechaIngreso = table.Column<double>(nullable: false),
                    Precio = table.Column<double>(nullable: false),
                    ProveedorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", producto => producto.ProductoId);
                    table.ForeignKey("FK_Productos_ProveedorId",
                                     producto => producto.ProveedorId,
                                     "Proveedores",
                                     "ProveedorId");
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
