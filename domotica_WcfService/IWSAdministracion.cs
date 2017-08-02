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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSAdministracion
    {
        [OperationContract]
        Alarma Agregar(string pIdAlarma, string pNombre, DateTime pFechaHora, Dispositivo pDispositivo, Double pLimite_Inferior, Double pLimite_Superior, ETipoAlarma pTipificacion);
               
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "domotica_WcfService.ContractType".
    [DataContract]
    public class Alarma: Respuesta
    {
        [DataMember]
        public string IdAlarma { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public DateTime FechaHora { get; set; }
        [DataMember]
        public domotica_admin.Modelo.Dispositivo Dispositivo { get; set; }
        [DataMember]
        public Double Limite_Inferior { get; set; }
        [DataMember]
        public Double Limite_Superior { get; set; }
        [DataMember]
        public ETipoAlarma Tipificacio { get; set; }
    }

    [DataContract]
    public class Respuesta {
        [DataMember]
        public string MensajeServicio { get; set; }
    }
}
