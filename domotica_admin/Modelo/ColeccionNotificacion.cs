using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domotica_admin.Modelo
{
    public class ColeccionNotificacion : Coleccion<Notificacion>, IIterable
    {
        public Notificacion BuscarPorId(string pIdNotificacion)
        {
            Notificacion notificacion = null;

            IteradorColeccionNotificacion i = (IteradorColeccionNotificacion)this.Iterador();

            while (i.tieneSiguiente())
            {
                notificacion = i.Siguiente();

                if (notificacion.IdNotificacion == pIdNotificacion)
                    return notificacion;
            }

            return notificacion;
        }

        public object Iterador()
        {
            return new IteradorColeccionNotificacion(this);
        }
    }
}