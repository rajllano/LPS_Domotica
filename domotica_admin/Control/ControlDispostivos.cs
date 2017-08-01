using domotica_admin.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica_admin.Control
{
    public static class ControlDispostivos
    {

        public static Respuesta Agregar(Dispositivo d)
        {
            return Agregar(d.IdDispositivo, d.IdUsuario, d.Nombre, d.Tipo, d.Estado, d.Valor);
        }

        public static Respuesta Agregar(string pIdDispostivo, string pIdUsuaurio, string pNombre, ETipoDispositivo pTipo, EEstadoDispositivo pEstado, Double pValor)
        {
            Respuesta r = new Respuesta("ControlDispositivo.Agregar");

            try
            {
                if (pIdDispostivo.Length <= 0)
                    throw new Exception("El campo Placa es obligatorio");

                if (pIdUsuaurio.Length <= 0)
                    throw new Exception("El campo Tag es obligatorio");

                if (pNombre.Length <= 0)
                    throw new Exception("El campo Marca es obligatorio");
                                

                Dispositivo d = Administrativo.getInstancia().ColeccionDispositivo.BuscarPorId(pIdDispostivo);

                if (d != null)
                    throw new Exception("Ya existe dispositivo " + pIdDispostivo);

                d = new Dispositivo();

                d.IdDispositivo = pIdDispostivo;
                d.IdUsuario = pIdUsuaurio;
                d.Nombre = pNombre;
                d.Tipo = pTipo;
                d.Estado = pEstado;
                d.Valor = pValor;

                Administrativo.getInstancia().ColeccionDispositivo.Agregar(d);

                r.Anexo.Add("Dispositivo", d);
                r.Mensaje += "Se agrego el exitosamente el dispositivo de Id " + pIdDispostivo;
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
            Respuesta r = new Respuesta("ControlDispositivo.EliminarPorId");

            try
            {
                Dispositivo d = Administrativo.getInstancia().ColeccionDispositivo.BuscarPorId(pId);

                if (d == null)
                    throw new Exception("No existe un dispositivo de Id " + pId);

                Administrativo.getInstancia().ColeccionDispositivo.Eliminar(d);
                r.Mensaje += "Se elimino exitosamente el dispositivo con Id " + pId;
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
            Respuesta r = new Respuesta("ControlDispositivo.BuscarPorId");

            try
            {
                Dispositivo d = Administrativo.getInstancia().ColeccionDispositivo.BuscarPorId(pId);

                if (d == null)
                    throw new Exception("No existe dispositivo con el Id " + pId);

                r.Anexo.Add("Dispositivo", d);
                r.Mensaje = "Dispositivo con el Id " + pId + " fue encontrado";
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
            Respuesta r = new Respuesta("ControlDispositivo.Listar");

            try
            {
                ColeccionDispositivo cd = Administrativo.getInstancia().ColeccionDispositivo;

                if (cd.Tamano() == 0)
                    throw new Exception("No existen dispositivos");

                r.Anexo.Add("ColeccionDispositivos", cd);
                r.Mensaje = "Cantidad de dispositivos " + cd.Tamano();
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
