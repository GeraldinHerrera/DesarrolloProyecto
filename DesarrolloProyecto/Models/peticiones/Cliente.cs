﻿using System;
using System.Collections.Generic;

namespace DesarrolloProyecto.Models.peticiones
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
    }
}
