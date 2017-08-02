using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica_seguridad.Modelo
{
    public class Seguridad
    {
        private static Seguridad Instancia;

        public ColeccionIntrusion ColeccionIntrusion { get; set; }

        public static Seguridad getInstancia()
        {
            if (Instancia == null)
                Instancia = new Seguridad();

            return Instancia;
        }
    }
}
