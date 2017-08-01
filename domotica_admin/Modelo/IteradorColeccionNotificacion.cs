using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica_admin.Modelo
{
    public class IteradorColeccionNotificacion
    {

        private ColeccionNotificacion Coleccion = null;
        private int Indice;

        public IteradorColeccionNotificacion (ColeccionNotificacion a)
        {
            this.Coleccion = a;
            this.Indice = -1;
        }

        ~IteradorColeccionNotificacion()
        {
            this.Coleccion = null;

            GC.Collect();
        }

        public Notificacion Siguiente()
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
