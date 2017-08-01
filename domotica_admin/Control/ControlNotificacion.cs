using domotica_admin.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace domotica_admin.Control
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
                
                Notificacion n = Administrativo.getInstancia().ColeccionNotificacion.BuscarPorId(pIdNotificacion);

                if (n != null)
                    throw new Exception("Ya existe notificacion " + pDispositivo.IdDispositivo);

                n = new Notificacion();

                n.IdNotificacion = pIdNotificacion;
                n.FechaHora = pFechaHora;
                n.Dispositivo = pDispositivo;
                n.Mensaje = pMensaje;

                Administrativo.getInstancia().ColeccionNotificacion.Agregar(n);

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
                Notificacion d = Administrativo.getInstancia().ColeccionNotificacion.BuscarPorId(pId);

                if (d == null)
                    throw new Exception("No existe notificacion de Id " + pId);

                Administrativo.getInstancia().ColeccionNotificacion.Eliminar(d);
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
                Notificacion d = Administrativo.getInstancia().ColeccionNotificacion.BuscarPorId(pId);

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
                ColeccionNotificacion cd = Administrativo.getInstancia().ColeccionNotificacion;

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
