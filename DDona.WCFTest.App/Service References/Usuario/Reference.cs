﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDona.WCFTest.App.Usuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioDTO", Namespace="http://schemas.datacontract.org/2004/07/DDona.WCFTest.DTO.Usuario")]
    [System.SerializableAttribute()]
    public partial class UsuarioDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Usuario.IUsuario")]
    public interface IUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Get", ReplyAction="http://tempuri.org/IUsuario/GetResponse")]
        DDona.WCFTest.App.Usuario.UsuarioDTO[] Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Get", ReplyAction="http://tempuri.org/IUsuario/GetResponse")]
        System.Threading.Tasks.Task<DDona.WCFTest.App.Usuario.UsuarioDTO[]> GetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetById", ReplyAction="http://tempuri.org/IUsuario/GetByIdResponse")]
        DDona.WCFTest.App.Usuario.UsuarioDTO GetById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetById", ReplyAction="http://tempuri.org/IUsuario/GetByIdResponse")]
        System.Threading.Tasks.Task<DDona.WCFTest.App.Usuario.UsuarioDTO> GetByIdAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioChannel : DDona.WCFTest.App.Usuario.IUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioClient : System.ServiceModel.ClientBase<DDona.WCFTest.App.Usuario.IUsuario>, DDona.WCFTest.App.Usuario.IUsuario {
        
        public UsuarioClient() {
        }
        
        public UsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DDona.WCFTest.App.Usuario.UsuarioDTO[] Get() {
            return base.Channel.Get();
        }
        
        public System.Threading.Tasks.Task<DDona.WCFTest.App.Usuario.UsuarioDTO[]> GetAsync() {
            return base.Channel.GetAsync();
        }
        
        public DDona.WCFTest.App.Usuario.UsuarioDTO GetById(int Id) {
            return base.Channel.GetById(Id);
        }
        
        public System.Threading.Tasks.Task<DDona.WCFTest.App.Usuario.UsuarioDTO> GetByIdAsync(int Id) {
            return base.Channel.GetByIdAsync(Id);
        }
    }
}