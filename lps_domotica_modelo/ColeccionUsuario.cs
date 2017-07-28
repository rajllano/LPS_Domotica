using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lps_domotica_modelo
{
    public class ColeccionUsuario : Coleccion<Usuario>
    {
        public Usuario BuscarXNombre(string Nombre)
        {
            Usuario u = null;

            for(int x=0;x<this.Tamano();x++)
            {
                u = this.Elemento(x);

                if (u.Nombre == Nombre)
                    return u;
            }

            return u;
        }

        public bool Autenticar(string Nombre)
        {
            return true;
        }
    }
}