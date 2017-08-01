﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lps_domotica_modelo.Administracion;
using lps_domotica_modelo.Seguridad;

namespace lps_domotica_control
{
    public class ControlIntrusion
    {
        public static Respuesta Agregar(Intrusion d)
        {
            return Agregar(d.Id, d.FechaHora, d.Hora, d.Dispositivo);
        }

        public static Respuesta Agregar(string pId, DateTime pFechaHora, int pHora, Dispositivo pDispositivo)
        {
            Respuesta r = new Respuesta("ControlIntrusion.Agregar");

            try
            {   Intrusion a = new Intrusion();

                a.Id = pId;
                a.FechaHora = pFechaHora;
                a.Hora = pHora;
                a.Dispositivo = pDispositivo;                

                Domotica.getInstancia().ColeccionIntrusion.Agregar(a);

                r.Anexo.Add("Intrusion", a);
                r.Mensaje += "Se agrego Intrusion de Id " + pId;
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);
            }

            return r;
        }
        
        public static Respuesta BuscarPorId(string pId)
        {
            Respuesta r = new Respuesta("ControlIntrusion.BuscarPorId");

            try
            {
                Intrusion d = Domotica.getInstancia().ColeccionIntrusion.BuscarPorId(pId);

                if (d == null)
                    throw new Exception("No existe Intrusion con el Id " + pId);

                r.Anexo.Add("Intrusion", d);
                r.Mensaje = "Intrusion con el Id " + pId + " fue encontrado";
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);
            }

            return r;
        }

        public static Respuesta Listar()
        {
            Respuesta r = new Respuesta("ControlIntrusion.Listar");

            try
            {
                ColeccionIntrusion cd = Domotica.getInstancia().ColeccionIntrusion;

                if (cd.Tamano() == 0)
                    throw new Exception("No existen Intrusiones");

                r.Anexo.Add("ColeccionIntrusiones", cd);
                r.Mensaje = "Cantidad de Intrusiones " + cd.Tamano();
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);
            }

            return r;
        }
    }
}
