using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lps_domotica_modelo.Administracion
{
    public interface IIterador<T>
    {
        T Siguiente();
        bool tieneSiguiente();
    }
}
