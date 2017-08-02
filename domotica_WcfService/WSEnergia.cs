using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using domotica_admin.Modelo;
using domotica_gestion_energia.Control;
using domotica_gestion_energia.Modelo;

namespace domotica_WcfService.Energia
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSEnergia" en el código y en el archivo de configuración a la vez.
    public class WSEnergia : IWSEnergia
    {
        public Respuesta Agregar(string pId, DateTime pFechaHora, int pHora, double pPotencia, Dispositivo pDispositivo)
        {
            domotica_admin.Modelo.Respuesta r = ControlSeguimiento.Agregar(pId, pFechaHora, pHora, pPotencia, pDispositivo);

            if (r.Estado)
            {
                Respuesta resServicio = new Respuesta();
                resServicio.Estado = r.Estado;
                resServicio.Mensaje = r.Mensaje;
                resServicio.Anexo = r.Anexo;

                return resServicio;
            }
            else
            {
                return new Respuesta() { Mensaje = "Servicio.Error" };
            }
        }

        public Respuesta Listar()
        {
            domotica_admin.Modelo.Respuesta r = domotica_gestion_energia.Control.ControlSeguimiento.Listar();
            if (r.Estado)
            {
                Respuesta resServicio = new Respuesta();
                resServicio.Estado = r.Estado;
                resServicio.Mensaje = r.Mensaje;
                resServicio.Anexo = r.Anexo;
                return resServicio;
            }
            else
            {
                return new Respuesta() { Mensaje = "Servicio.Error" };
            }
        }
    }
}