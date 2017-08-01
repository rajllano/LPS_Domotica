using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lps_domotica_modelo.Administracion;

namespace lps_domotica_modelo.Energia
{
    public class Seguimiento: Dispositivo 
    {
        public string Id { get; set; }

        public DateTime FechaHora { get; set; }

        public int Hora { get; set; }

        public Double Potencia { get; set; }

        public Dispositivo Dispositivo { get; set; }

    }
}