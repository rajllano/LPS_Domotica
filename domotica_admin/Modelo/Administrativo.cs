using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domotica_admin.Modelo
{
    public class Administrativo
    {
        private static Administrativo Instancia;

        public ColeccionAlarma ColeccionAlarma { get; set; }

        public ColeccionUsuario ColeccionUsuario { get; set; }

        public ColeccionDispositivo ColeccionDispositivo { get; set; }

        public ColeccionNotificacion ColeccionNotificacion { get; set; }

        public Object ModuloSeguridad { get; set; }

        public Object ModuloGestionEnergia { get; set; }

        public static Administrativo getInstancia()
        {
            if (Instancia == null)
                Instancia = new Administrativo();

            return Instancia;
        }
    }
}