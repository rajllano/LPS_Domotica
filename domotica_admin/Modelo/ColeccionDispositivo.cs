using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domotica_admin.Modelo
{
    public class ColeccionDispositivo : Coleccion<Dispositivo>, IIterable
    {
        public Dispositivo BuscarPorId(string pIdDispositivo)
        {
            Dispositivo dispositivo = null;

            IteradorColeccionDispositivo   i = (IteradorColeccionDispositivo)this.Iterador();

            while (i.tieneSiguiente())
            {
                dispositivo = i.Siguiente();

                if (dispositivo.IdDispositivo == pIdDispositivo)
                    return dispositivo;
            }

            return dispositivo;
        }

        public object Iterador()
        {
            return new IteradorColeccionDispositivo(this);
        }
    }
}