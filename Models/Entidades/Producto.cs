using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TallerCRUDNETCORE.Models.Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Column("nombre", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Nombre { get; set; }
        

        public int Existencia { get; set; }
        public double FechaIngreso { get; set; }
        public double Precio { get; set; }
        public int ProveedorId { get; set; }
        [ForeignKey("ProveedorId")]
        public virtual Proveedor Proveedor { get; set; }

    }
}
