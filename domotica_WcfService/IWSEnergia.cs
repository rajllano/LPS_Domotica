using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using domotica_admin.Control;
using domotica_admin.Modelo;

namespace domotica_WcfService.Energia
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSEnergia" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSEnergia
    {
        [OperationContract]
        Respuesta AgregarEnergia(string pId, DateTime pFechaHora, int pHora, Double pPotencia, int pDispositivo);
        Respuesta ListarEnergia();
    }

    [DataContract]
    public class Energia : Respuesta
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public DateTime FechaHora { get; set; }
        [DataMember]
        public int Hora { get; set; }
        [DataMember]
        public Double Potencia { get; set; }
        [DataMember]
        public int Dispositivo { get; set; }
        
    }

    [DataContract]
    public class Respuesta
    {
        [DataMember]
        public Boolean Estado { get; set; }
        [DataMember]
        public string Mensaje { get; set; }
        [DataMember]
        public Dictionary<string, Object> Anexo { get; set; }
    }
}
