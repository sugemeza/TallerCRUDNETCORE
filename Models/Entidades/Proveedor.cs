using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerCRUDNETCORE.Models.Entidades
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public String Nombre { get; set; }
        public String PersonaContacto { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
    }
}
