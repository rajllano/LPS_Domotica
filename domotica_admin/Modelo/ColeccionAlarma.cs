using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domotica_admin.Modelo
{
    public class ColeccionAlarma : Coleccion<Alarma>, IIterable
    {
        public Alarma BuscarPorIdAlarma(string pIdAlarma)
        {
            Alarma alarma = null;

            IteradorColeccionAlarma  i = (IteradorColeccionAlarma)this.Iterador();

            while (i.tieneSiguiente())
            {
                alarma = i.Siguiente();

                if (alarma.IdAlarma == pIdAlarma)
                    return alarma;
            }

            return alarma;
        }
        
        public object Iterador()
        {
            return new IteradorColeccionAlarma(this);
        }
    }
}