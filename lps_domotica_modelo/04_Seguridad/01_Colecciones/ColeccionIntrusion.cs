using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lps_domotica_modelo.Administracion;

namespace lps_domotica_modelo.Seguridad
{
    public class ColeccionIntrusion : Coleccion<Intrusion>, IIterable
    {
        public Intrusion BuscarPorId(string pId)
        {
            Intrusion segIntrusion = null;

            IteradorColeccionIntrusion i = (IteradorColeccionIntrusion)this.Iterador();

            while (i.tieneSiguiente())
            {
                segIntrusion = i.Siguiente();

                if (segIntrusion.Id == pId)
                    return segIntrusion;
            }

            return segIntrusion;
        }
        
        public object Iterador()
        {
            return new IteradorColeccionIntrusion(this);
        }
    }
}