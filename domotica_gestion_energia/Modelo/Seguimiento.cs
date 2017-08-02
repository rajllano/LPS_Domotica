using domotica_admin.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domotica_gestion_energia.Modelo
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