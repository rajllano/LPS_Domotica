﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lps_domotica_modelo.Administracion
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string Clave { get; set; }

        public string Correo { get; set; }

        public string Celular { get; set; }
    }
}