using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lps_domotica_modelo.Administracion;

namespace lps_domotica_control
{
    public class ControlNotificacion
    {
        public static Respuesta Agregar(Notificacion n)
        {
            return Agregar(n.IdNotificacion, n.FechaHora, n.Dispositivo, n.Mensaje);
        }

        public static Respuesta Agregar(string pIdNotificacion, DateTime pFechaHora, Dispositivo pDispositivo, string pMensaje)
        {
            Respuesta r = new Respuesta("ControlNotificacion.Agregar");

            try
            {
                if (pIdNotificacion.Length <= 0)
                    throw new Exception("El campo Id es obligatorio");

                if (pDispositivo.IdDispositivo.Length <= 0)
                    throw new Exception("El campo Id Dispositivo es obligatorio");

                if (pMensaje.Length <= 0 )
                    throw new Exception("El campo mensaje es obligatorio");
                
                Notificacion n = Domotica.getInstancia().ColeccionNotificacion.BuscarPorId(pIdNotificacion);

                if (n != null)
                    throw new Exception("Ya existe notificacion " + pDispositivo.IdDispositivo);

                n = new Notificacion();

                n.IdNotificacion = pIdNotificacion;
                n.FechaHora = pFechaHora;
                n.Dispositivo = pDispositivo;
                n.Mensaje = pMensaje;
                
                Domotica.getInstancia().ColeccionNotificacion.Agregar(n);

                r.Anexo.Add("Notificacion", n);
                r.Mensaje += "Se agrego el exitosamente la notificacion de Id " + pIdNotificacion;
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

        public static Respuesta EliminarPorId(string pId)
        {
            Respuesta r = new Respuesta("ControlNotificacion.EliminarPorId");

            try
            {
                Notificacion d = Domotica.getInstancia().ColeccionNotificacion.BuscarPorId(pId);

                if (d == null)
                    throw new Exception("No existe notificacion de Id " + pId);

                Domotica.getInstancia().ColeccionNotificacion.Eliminar(d);
                r.Mensaje += "Se elimino exitosamente notificacion con Id " + pId;
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
            Respuesta r = new Respuesta("ControlNotificacion.BuscarPorId");

            try
            {
                Notificacion d = Domotica.getInstancia().ColeccionNotificacion.BuscarPorId(pId);

                if (d == null)
                    throw new Exception("No existe notificacion con el Id " + pId);

                r.Anexo.Add("Notificacion", d);
                r.Mensaje = "Notificacion con el Id " + pId + " fue encontrado";
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
            Respuesta r = new Respuesta("ControlNotificacion.Listar");

            try
            {
                ColeccionNotificacion cd = Domotica.getInstancia().ColeccionNotificacion;

                if (cd.Tamano() == 0)
                    throw new Exception("No existen notificaciones");

                r.Anexo.Add("ColeccionNotificacion", cd);
                r.Mensaje = "Cantidad de Notificaciones " + cd.Tamano();
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
