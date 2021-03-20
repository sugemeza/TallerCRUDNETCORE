using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerCRUDNETCORE.Models.Entidades;

namespace TallerCRUDNETCORE.Models.DAL
{
    public class DbContextProducto: DbContext
    {
        public DbContextProducto(DbContextOptions<DbContextProducto> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set;  }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
