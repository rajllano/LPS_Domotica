using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica_admin.Modelo
{
    public interface IIterador<T>
    {
        T Siguiente();
        bool tieneSiguiente();
    }
}
