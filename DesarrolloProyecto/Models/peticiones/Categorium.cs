using System;
using System.Collections.Generic;

namespace DesarrolloProyecto.Models.peticiones
{
    public partial class Categorium
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; } = null!;
        public string? DescripcionCategoria { get; set; }
    }
}
