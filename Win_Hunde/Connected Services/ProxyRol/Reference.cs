﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Win_Hunde.ProxyRol {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Rol", Namespace="http://schemas.datacontract.org/2004/07/WCF_Hunde")]
    [System.SerializableAttribute()]
    public partial class Rol : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short cod_rolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nom_rolField;
        
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
        public short cod_rol {
            get {
                return this.cod_rolField;
            }
            set {
                if ((this.cod_rolField.Equals(value) != true)) {
                    this.cod_rolField = value;
                    this.RaisePropertyChanged("cod_rol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nom_rol {
            get {
                return this.nom_rolField;
            }
            set {
                if ((object.ReferenceEquals(this.nom_rolField, value) != true)) {
                    this.nom_rolField = value;
                    this.RaisePropertyChanged("nom_rol");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyRol.IServicioRol")]
    public interface IServicioRol {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioRol/listarRoles", ReplyAction="http://tempuri.org/IServicioRol/listarRolesResponse")]
        Win_Hunde.ProxyRol.Rol[] listarRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioRol/listarRoles", ReplyAction="http://tempuri.org/IServicioRol/listarRolesResponse")]
        System.Threading.Tasks.Task<Win_Hunde.ProxyRol.Rol[]> listarRolesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioRolChannel : Win_Hunde.ProxyRol.IServicioRol, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioRolClient : System.ServiceModel.ClientBase<Win_Hunde.ProxyRol.IServicioRol>, Win_Hunde.ProxyRol.IServicioRol {
        
        public ServicioRolClient() {
        }
        
        public ServicioRolClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioRolClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioRolClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioRolClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Win_Hunde.ProxyRol.Rol[] listarRoles() {
            return base.Channel.listarRoles();
        }
        
        public System.Threading.Tasks.Task<Win_Hunde.ProxyRol.Rol[]> listarRolesAsync() {
            return base.Channel.listarRolesAsync();
        }
    }
}