using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lps_domotica_modelo.Administracion;

namespace lps_domotica_control
{
    public class ControlAlarma
    {
        public static Respuesta Agregar(Alarma d)
        {
            return Agregar(d.IdDispositivo, d.Nombre, d.FechaHora, d.Dispositivo, d.Limite_Inferior, d.Limite_Superior, d.Tipificacion);
        }

        public static Respuesta Agregar(string pIdAlarma, string pNombre, DateTime pFechaHora, Dispositivo pDispositivo, Double pLimite_Inferior, Double pLimite_Superior, ETipoAlarma pTipificacion)
        {
            Respuesta r = new Respuesta("ControlAlarma.Agregar");

            try
            {
                if (pDispositivo.IdDispositivo.Length <= 0)
                    throw new Exception("El campo Id Dispositivo es obligatorio");

                if (pNombre.Length <= 0)
                    throw new Exception("El campo nombre es obligatorio");

                if (pLimite_Inferior <= 0 || pLimite_Superior <= 0)
                    throw new Exception("El campo Limite Inferior o Superior de la Alarma debe ser mayor a cero");

                if (pLimite_Inferior == pLimite_Superior)
                    throw new Exception("El campo Limite Inferior y Superior de la Alarma no pueden ser iguales");
                
                Alarma a = Domotica.getInstancia().ColeccionAlarma.BuscarPorIdAlarma(pIdAlarma);

                if (a != null)
                    throw new Exception("Ya existe dispositivo " + pDispositivo.IdDispositivo);

                a = new Alarma();

                a.IdAlarma = pIdAlarma;
                a.Nombre = pNombre;
                a.FechaHora = pFechaHora;
                a.Dispositivo = pDispositivo;
                a.Limite_Inferior = pLimite_Inferior;
                a.Limite_Superior = pLimite_Superior;
                a.Tipificacion = pTipificacion;

                Domotica.getInstancia().ColeccionAlarma.Agregar(a);

                r.Anexo.Add("Alarma", a);
                r.Mensaje += "Se agrego el exitosamente la alarma de Id " + pIdAlarma;
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
            Respuesta r = new Respuesta("ControlAlarma.EliminarPorId");

            try
            {
                Alarma d = Domotica.getInstancia().ColeccionAlarma.BuscarPorIdAlarma(pId);

                if (d == null)
                    throw new Exception("No existe alarma de Id " + pId);

                Domotica.getInstancia().ColeccionDispositivo.Eliminar(d);
                r.Mensaje += "Se elimino exitosamente alarma con Id " + pId;
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
            Respuesta r = new Respuesta("ControlAlarma.BuscarPorId");

            try
            {
                Alarma d = Domotica.getInstancia().ColeccionAlarma.BuscarPorIdAlarma(pId);

                if (d == null)
                    throw new Exception("No existe alarma con el Id " + pId);

                r.Anexo.Add("Alarma", d);
                r.Mensaje = "Alarma con el Id " + pId + " fue encontrado";
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
            Respuesta r = new Respuesta("ControlAlarma.Listar");

            try
            {
                ColeccionAlarma cd = Domotica.getInstancia().ColeccionAlarma;

                if (cd.Tamano() == 0)
                    throw new Exception("No existen alarmas");

                r.Anexo.Add("ColeccionAlarmas", cd);
                r.Mensaje = "Cantidad de alarmas " + cd.Tamano();
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
