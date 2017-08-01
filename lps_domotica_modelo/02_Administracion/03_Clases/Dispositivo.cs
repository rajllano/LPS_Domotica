﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lps_domotica_modelo.Administracion
{
    public class Dispositivo
    {
        public string IdDispositivo { get; set; }

        public string IdUsuario { get; set; }

        public string Nombre { get; set; }

        public ETipoDispositivo Tipo { get; set; }

        public EEstadoDispositivo Estado { get; set; }

        public Double Valor { get; set; }
                
    }
}
