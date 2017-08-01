using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica_admin.Modelo
{
    public class Notificacion: Dispositivo
    {
        public string IdNotificacion { get; set; }

        public DateTime FechaHora { get; set; }

        public Dispositivo Dispositivo { get; set; }

        public string Mensaje { get; set; }
        
    }
}
