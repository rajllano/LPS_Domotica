﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lps_domotica_vista.domotica_WcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dispositivo", Namespace="http://schemas.datacontract.org/2004/07/domotica_admin.Modelo")]
    [System.SerializableAttribute()]
    public partial class Dispositivo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lps_domotica_vista.domotica_WcfService.EEstadoDispositivo EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdDispositivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lps_domotica_vista.domotica_WcfService.ETipoDispositivo TipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lps_domotica_vista.domotica_WcfService.EEstadoDispositivo Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDispositivo {
            get {
                return this.IdDispositivoField;
            }
            set {
                if ((object.ReferenceEquals(this.IdDispositivoField, value) != true)) {
                    this.IdDispositivoField = value;
                    this.RaisePropertyChanged("IdDispositivo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.IdUsuarioField, value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lps_domotica_vista.domotica_WcfService.ETipoDispositivo Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((this.TipoField.Equals(value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Valor {
            get {
                return this.ValorField;
            }
            set {
                if ((this.ValorField.Equals(value) != true)) {
                    this.ValorField = value;
                    this.RaisePropertyChanged("Valor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EEstadoDispositivo", Namespace="http://schemas.datacontract.org/2004/07/domotica_admin.Modelo")]
    public enum EEstadoDispositivo : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ACTIVO = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INACTIVO = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ETipoDispositivo", Namespace="http://schemas.datacontract.org/2004/07/domotica_admin.Modelo")]
    public enum ETipoDispositivo : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ENERGIA = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SEGURIDAD = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ILUMINACION = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ETipoAlarma", Namespace="http://schemas.datacontract.org/2004/07/domotica_admin.Modelo")]
    public enum ETipoAlarma : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DISPOSTIVO_VALOR_DOUBLE = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DISPOSTIVO_VALOR_FECHA = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respuesta", Namespace="http://schemas.datacontract.org/2004/07/domotica_WcfService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(lps_domotica_vista.domotica_WcfService.Alarma))]
    public partial class Respuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeServicioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeServicio {
            get {
                return this.MensajeServicioField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeServicioField, value) != true)) {
                    this.MensajeServicioField = value;
                    this.RaisePropertyChanged("MensajeServicio");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alarma", Namespace="http://schemas.datacontract.org/2004/07/domotica_WcfService")]
    [System.SerializableAttribute()]
    public partial class Alarma : lps_domotica_vista.domotica_WcfService.Respuesta {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lps_domotica_vista.domotica_WcfService.Dispositivo DispositivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaHoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdAlarmaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double Limite_InferiorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double Limite_SuperiorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lps_domotica_vista.domotica_WcfService.ETipoAlarma TipificacioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lps_domotica_vista.domotica_WcfService.Dispositivo Dispositivo {
            get {
                return this.DispositivoField;
            }
            set {
                if ((object.ReferenceEquals(this.DispositivoField, value) != true)) {
                    this.DispositivoField = value;
                    this.RaisePropertyChanged("Dispositivo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaHora {
            get {
                return this.FechaHoraField;
            }
            set {
                if ((this.FechaHoraField.Equals(value) != true)) {
                    this.FechaHoraField = value;
                    this.RaisePropertyChanged("FechaHora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdAlarma {
            get {
                return this.IdAlarmaField;
            }
            set {
                if ((object.ReferenceEquals(this.IdAlarmaField, value) != true)) {
                    this.IdAlarmaField = value;
                    this.RaisePropertyChanged("IdAlarma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Limite_Inferior {
            get {
                return this.Limite_InferiorField;
            }
            set {
                if ((this.Limite_InferiorField.Equals(value) != true)) {
                    this.Limite_InferiorField = value;
                    this.RaisePropertyChanged("Limite_Inferior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Limite_Superior {
            get {
                return this.Limite_SuperiorField;
            }
            set {
                if ((this.Limite_SuperiorField.Equals(value) != true)) {
                    this.Limite_SuperiorField = value;
                    this.RaisePropertyChanged("Limite_Superior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lps_domotica_vista.domotica_WcfService.ETipoAlarma Tipificacio {
            get {
                return this.TipificacioField;
            }
            set {
                if ((this.TipificacioField.Equals(value) != true)) {
                    this.TipificacioField = value;
                    this.RaisePropertyChanged("Tipificacio");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="domotica_WcfService.IWSAdministracion")]
    public interface IWSAdministracion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSAdministracion/Agregar", ReplyAction="http://tempuri.org/IWSAdministracion/AgregarResponse")]
        lps_domotica_vista.domotica_WcfService.Alarma Agregar(string pIdAlarma, string pNombre, System.DateTime pFechaHora, lps_domotica_vista.domotica_WcfService.Dispositivo pDispositivo, double pLimite_Inferior, double pLimite_Superior, lps_domotica_vista.domotica_WcfService.ETipoAlarma pTipificacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSAdministracion/Agregar", ReplyAction="http://tempuri.org/IWSAdministracion/AgregarResponse")]
        System.Threading.Tasks.Task<lps_domotica_vista.domotica_WcfService.Alarma> AgregarAsync(string pIdAlarma, string pNombre, System.DateTime pFechaHora, lps_domotica_vista.domotica_WcfService.Dispositivo pDispositivo, double pLimite_Inferior, double pLimite_Superior, lps_domotica_vista.domotica_WcfService.ETipoAlarma pTipificacion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSAdministracionChannel : lps_domotica_vista.domotica_WcfService.IWSAdministracion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSAdministracionClient : System.ServiceModel.ClientBase<lps_domotica_vista.domotica_WcfService.IWSAdministracion>, lps_domotica_vista.domotica_WcfService.IWSAdministracion {
        
        public WSAdministracionClient() {
        }
        
        public WSAdministracionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSAdministracionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSAdministracionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSAdministracionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public lps_domotica_vista.domotica_WcfService.Alarma Agregar(string pIdAlarma, string pNombre, System.DateTime pFechaHora, lps_domotica_vista.domotica_WcfService.Dispositivo pDispositivo, double pLimite_Inferior, double pLimite_Superior, lps_domotica_vista.domotica_WcfService.ETipoAlarma pTipificacion) {
            return base.Channel.Agregar(pIdAlarma, pNombre, pFechaHora, pDispositivo, pLimite_Inferior, pLimite_Superior, pTipificacion);
        }
        
        public System.Threading.Tasks.Task<lps_domotica_vista.domotica_WcfService.Alarma> AgregarAsync(string pIdAlarma, string pNombre, System.DateTime pFechaHora, lps_domotica_vista.domotica_WcfService.Dispositivo pDispositivo, double pLimite_Inferior, double pLimite_Superior, lps_domotica_vista.domotica_WcfService.ETipoAlarma pTipificacion) {
            return base.Channel.AgregarAsync(pIdAlarma, pNombre, pFechaHora, pDispositivo, pLimite_Inferior, pLimite_Superior, pTipificacion);
        }
    }
}
