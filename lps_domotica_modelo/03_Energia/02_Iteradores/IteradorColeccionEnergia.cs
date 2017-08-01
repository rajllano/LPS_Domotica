using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lps_domotica_modelo.Administracion;

namespace lps_domotica_modelo.Energia
{
    public class IteradorColeccionEnergia
    {

        private ColeccionEnergia Coleccion = null;
        private int Indice;

        public IteradorColeccionEnergia(ColeccionEnergia a)
        {
            this.Coleccion = a;
            this.Indice = -1;
        }

        ~IteradorColeccionEnergia()
        {
            this.Coleccion = null;

            GC.Collect();
        }

        public Seguimiento Siguiente()
        {
            Indice++;

            if (Indice < this.Coleccion.Tamano())
                return this.Coleccion.Elemento(Indice);

            return null;
        }

        public bool tieneSiguiente()
        {
            if (this.Indice + 1 < this.Coleccion.Tamano())
                return true;

            return false;
        }

    }
}
