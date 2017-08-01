using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lps_domotica_modelo.Administracion;
using lps_domotica_modelo.Energia;

namespace lps_domotica_control
{
    public class ControlSeguimiento
    {
        public static Respuesta Agregar(Seguimiento d)
        {
            return Agregar(d.Id, d.FechaHora, d.Hora, d.Potencia, d.Dispositivo);
        }

        public static Respuesta Agregar(string pId, DateTime pFechaHora, int pHora, Double pPotencia, Dispositivo pDispositivo)
        {
            Respuesta r = new Respuesta("ControlSeguimiento.Agregar");

            try
            {
                Seguimiento a = new Seguimiento();

                a.Id = pId;
                a.FechaHora = pFechaHora;
                a.Hora = pHora;
                a.Potencia = pPotencia;
                a.Dispositivo = pDispositivo;

                Domotica.getInstancia().ColeccionEnergia.Agregar(a);

                r.Anexo.Add("SeguimientoEnergia", a);
                r.Mensaje += "Se agrego SeguimientoEnergia de Id " + pId;
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
            Respuesta r = new Respuesta("ControlSeguimiento.BuscarPorId");

            try
            {
                Seguimiento d = Domotica.getInstancia().ColeccionEnergia.BuscarPorIdSeguimiento(pId);

                if (d == null)
                    throw new Exception("No existe Seguimiento Energia con el Id " + pId);

                r.Anexo.Add("SeguimientoEnergia", d);
                r.Mensaje = "SeguimientoEnergia con el Id " + pId + " fue encontrado";
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
            Respuesta r = new Respuesta("ControlSeguimiento.Listar");

            try
            {
                ColeccionEnergia cd = Domotica.getInstancia().ColeccionEnergia;

                if (cd.Tamano() == 0)
                    throw new Exception("No existen SeguimientoEnergia");

                r.Anexo.Add("ColeccionSeguimientoEnergia", cd);
                r.Mensaje = "Cantidad de SeguimientoEnergia " + cd.Tamano();
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
