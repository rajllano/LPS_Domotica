using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lps_domotica_modelo
{
    public class Domotica
    {
        private static Domotica Instancia;

        public static Domotica getInstancia()
        {
            if (Instancia == null)
                Instancia = new Domotica();

            return Instancia;
        }

        public Domotica()
        {
            Administrativo = new Administrativo();
            Seguridad = new Seguridad();
        }

        public Seguridad Seguridad
        {
            get; set;
        }

        public Administrativo Administrativo
        {
            get; set;
        }
    }
}