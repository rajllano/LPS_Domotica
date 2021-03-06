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
    [ServiceContract]
    public interface IWSAdministracion
    {
        [OperationContract]
        Respuesta AgregarAlarma(string pIdAlarma, string pNombre, DateTime pFechaHora, Dispositivo pDispositivo, Double pLimite_Inferior, Double pLimite_Superior, ETipoAlarma pTipificacion);
        [OperationContract]
        Respuesta ListarAlarma();
    }

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
