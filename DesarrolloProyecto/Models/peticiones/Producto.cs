using System;
using System.Collections.Generic;

namespace DesarrolloProyecto.Models.peticiones
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = null!;
        public string Precio { get; set; } = null!;
        public int Stock { get; set; }
        public int IdCategoria { get; set; }
    }
}
