using domotica_admin.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domotica_seguridad.Modelo
{
    public class Intrusion
    {
        public string Id { get; set; }

        public DateTime FechaHora { get; set; }

        public int Hora { get; set; }

        public Dispositivo Dispositivo { get; set; }
    }
}