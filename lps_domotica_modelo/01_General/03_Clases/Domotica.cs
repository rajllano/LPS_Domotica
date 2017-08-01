using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lps_domotica_modelo.Administracion;
using lps_domotica_modelo.Energia;
using lps_domotica_modelo.Seguridad;

namespace lps_domotica_modelo.Administracion
{
    public class Domotica
    {
        private static Domotica Instancia;

        public ColeccionAlarma ColeccionAlarma { get; set; }

        public ColeccionDispositivo ColeccionDispositivo { get; set; }

        public ColeccionNotificacion ColeccionNotificacion { get; set; }

        public ColeccionIntrusion ColeccionIntrusion { get; set; }
        public ColeccionEnergia ColeccionEnergia { get; set; }


        public static Domotica getInstancia()
        {
            if (Instancia == null)
                Instancia = new Domotica();

            return Instancia;
        }

        public Domotica()
        {
            this.ColeccionAlarma = new ColeccionAlarma();
            this.ColeccionDispositivo = new ColeccionDispositivo();
            this.ColeccionNotificacion = new ColeccionNotificacion();

            /*aqui debe variar dependiendo del paquete*/
            this.ColeccionIntrusion = new ColeccionIntrusion();
            this.ColeccionEnergia = new ColeccionEnergia();
        }

        /*
        public Seguridad Seguridad
        {
            get; set;
        }

        public Administrativo Administrativo
        {
            get; set;
        }*/
    }
}