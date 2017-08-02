using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica_gestion_energia.Modelo
{
    public class Energia
    {
        private static Energia Instancia;

        public ColeccionEnergia ColeccionEnergia { get; set; }

        public static Energia getInstancia()
        {
            if (Instancia == null)
                Instancia = new Energia();

            return Instancia;
        }

        public Energia()
        {
            ColeccionEnergia = new ColeccionEnergia();
        }
    }
}
