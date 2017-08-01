using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica_seguridad.Modelo
{
    public class IteradorColeccionIntrusion
    {

        private ColeccionIntrusion Coleccion = null;
        private int Indice;

        public IteradorColeccionIntrusion(ColeccionIntrusion a)
        {
            this.Coleccion = a;
            this.Indice = -1;
        }

        ~IteradorColeccionIntrusion()
        {
            this.Coleccion = null;

            GC.Collect();
        }

        public Intrusion Siguiente()
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
