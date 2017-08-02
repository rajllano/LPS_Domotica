using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using domotica_admin.Control;
using domotica_admin.Modelo;

namespace domotica_WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class WSAdministracion : IWSAdministracion
    {
        public Alarma Agregar(string pIdAlarma, string pNombre, DateTime pFechaHora, Dispositivo pDispositivo, double pLimite_Inferior, double pLimite_Superior, ETipoAlarma pTipificacion)
        {
            domotica_admin.Modelo.Respuesta r = ControlAlarma.Agregar(pIdAlarma, pNombre, pFechaHora, pDispositivo, pLimite_Inferior, pLimite_Superior, pTipificacion);

            if (r.Estado)
            {
                return new Alarma() { MensajeServicio = "Servicio.AlarmaRegistrada" };
            }
            else {
                return new Alarma() { MensajeServicio = "Servicio.Error" };
            }
        }
    }
}
