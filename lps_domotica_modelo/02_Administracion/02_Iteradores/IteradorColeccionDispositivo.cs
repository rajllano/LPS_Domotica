using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lps_domotica_modelo.Administracion
{
    public class IteradorColeccionDispositivo
    {

        private ColeccionDispositivo Coleccion = null;
        private int Indice;

        public IteradorColeccionDispositivo(ColeccionDispositivo a)
        {
            this.Coleccion = a;
            this.Indice = -1;
        }

        ~IteradorColeccionDispositivo()
        {
            this.Coleccion = null;

            GC.Collect();
        }

        public Dispositivo Siguiente()
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
