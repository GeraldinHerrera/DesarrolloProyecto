using System;
using System.Collections.Generic;

namespace DesarrolloProyecto.Models.peticiones
{
    public partial class Detalle
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string Precio { get; set; } = null!;
    }
}
