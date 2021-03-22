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

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime FechaIngreso { get; set; }

        public double Precio { get; set; }

        [ForeignKey("ProveedorId")]
        public int ProveedorId { get; set; }

        public virtual Proveedor Proveedor { get; set; }

    }
}
