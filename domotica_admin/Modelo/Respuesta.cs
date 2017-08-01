using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica_admin.Modelo
{
    public class Respuesta
    {
        public Boolean Estado { get; set; }
        public string Mensaje { get; set; }
        public Dictionary<string, Object> Anexo { get; set; }

        public Respuesta(string Estado)
        {
            this.Mensaje = "[" + Estado + "] ";
            this.Estado = true;
            Anexo = new Dictionary<string, object>();
            this.Anexo.Add("Mensaje", null);
        }
    }
}
