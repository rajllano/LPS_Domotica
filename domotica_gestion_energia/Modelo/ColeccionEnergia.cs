using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domotica_gestion_energia.Modelo
{
    public class ColeccionEnergia : Coleccion<Seguimiento>, IIterable
    {
        public Seguimiento BuscarPorIdSeguimiento(string pIdSeguimiento)
        {
            Seguimiento segEnergia = null;

            IteradorColeccionEnergia i = (IteradorColeccionEnergia)this.Iterador();

            while (i.tieneSiguiente())
            {
                segEnergia = i.Siguiente();

                if (segEnergia.Id == pIdSeguimiento)
                    return segEnergia;
            }

            return segEnergia;
        }
        
        public object Iterador()
        {
            return new IteradorColeccionEnergia(this);
        }
    }
}