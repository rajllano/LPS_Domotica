using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lps_domotica_modelo.Administracion
{
    public class Administrativo
    {
        private static Administrativo Instancia;

        public ColeccionUsuario ColeccionUsuario
        {
            get => default(ColeccionUsuario);
            set
            {
            }
        }

        public static Administrativo getInstancia()
        {
            if (Instancia == null)
                Instancia = new Administrativo();

            return Instancia;
        }


    }
}