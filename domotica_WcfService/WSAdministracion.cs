﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using domotica_admin.Control;
using domotica_admin.Modelo;

namespace domotica_WcfService.Administracion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class WSAdministracion : IWSAdministracion
    {
        public Respuesta AgregarAlarma(string pIdAlarma, string pNombre, DateTime pFechaHora, Dispositivo pDispositivo, double pLimite_Inferior, double pLimite_Superior, ETipoAlarma pTipificacion)
        {
            domotica_admin.Modelo.Respuesta r = ControlAlarma.Agregar(pIdAlarma, pNombre, pFechaHora, pDispositivo, pLimite_Inferior, pLimite_Superior, pTipificacion);

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

        public Respuesta ListarAlarma()
        {
            domotica_admin.Modelo.Respuesta r = ControlAlarma.Listar();
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
