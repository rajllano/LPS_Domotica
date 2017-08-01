using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lps_domotica_modelo.Administracion
{
    public class Alarma: Dispositivo
    {
        public string IdAlarma { get; set; }

        public string NombreAlarma { get; set; }

        public DateTime FechaHora { get; set; }

        public Dispositivo Dispositivo { get; set; }

        public double Limite_Inferior { get; set; }

        public double Limite_Superior { get; set; }

        public DateTime Limite_Fecha { get; set; }

        public ETipoAlarma Tipificacion { get; set; }
    }
}
