//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientWSUser.wsUser {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://schemas.datacontract.org/2004/07/wsUser")]
    [System.SerializableAttribute()]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CelularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GrupoSanguineoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroDocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrimerApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrimerNombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SegundoApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SegundoNombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDocumentoField;
        
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
        public string Celular {
            get {
                return this.CelularField;
            }
            set {
                if ((object.ReferenceEquals(this.CelularField, value) != true)) {
                    this.CelularField = value;
                    this.RaisePropertyChanged("Celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GrupoSanguineo {
            get {
                return this.GrupoSanguineoField;
            }
            set {
                if ((object.ReferenceEquals(this.GrupoSanguineoField, value) != true)) {
                    this.GrupoSanguineoField = value;
                    this.RaisePropertyChanged("GrupoSanguineo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroDocumento {
            get {
                return this.NumeroDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroDocumentoField, value) != true)) {
                    this.NumeroDocumentoField = value;
                    this.RaisePropertyChanged("NumeroDocumento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrimerApellido {
            get {
                return this.PrimerApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.PrimerApellidoField, value) != true)) {
                    this.PrimerApellidoField = value;
                    this.RaisePropertyChanged("PrimerApellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrimerNombre {
            get {
                return this.PrimerNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.PrimerNombreField, value) != true)) {
                    this.PrimerNombreField = value;
                    this.RaisePropertyChanged("PrimerNombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SegundoApellido {
            get {
                return this.SegundoApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.SegundoApellidoField, value) != true)) {
                    this.SegundoApellidoField = value;
                    this.RaisePropertyChanged("SegundoApellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SegundoNombre {
            get {
                return this.SegundoNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.SegundoNombreField, value) != true)) {
                    this.SegundoNombreField = value;
                    this.RaisePropertyChanged("SegundoNombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDocumento {
            get {
                return this.TipoDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDocumentoField, value) != true)) {
                    this.TipoDocumentoField = value;
                    this.RaisePropertyChanged("TipoDocumento");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsUser.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/countPersonas", ReplyAction="http://tempuri.org/IService1/countPersonasResponse")]
        long countPersonas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/countPersonas", ReplyAction="http://tempuri.org/IService1/countPersonasResponse")]
        System.Threading.Tasks.Task<long> countPersonasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPersonas", ReplyAction="http://tempuri.org/IService1/getPersonasResponse")]
        clientWSUser.wsUser.Persona[] getPersonas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPersonas", ReplyAction="http://tempuri.org/IService1/getPersonasResponse")]
        System.Threading.Tasks.Task<clientWSUser.wsUser.Persona[]> getPersonasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPersona", ReplyAction="http://tempuri.org/IService1/getPersonaResponse")]
        clientWSUser.wsUser.Persona getPersona(string documento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPersona", ReplyAction="http://tempuri.org/IService1/getPersonaResponse")]
        System.Threading.Tasks.Task<clientWSUser.wsUser.Persona> getPersonaAsync(string documento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getApellidoPersona", ReplyAction="http://tempuri.org/IService1/getApellidoPersonaResponse")]
        string getApellidoPersona(string documento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getApellidoPersona", ReplyAction="http://tempuri.org/IService1/getApellidoPersonaResponse")]
        System.Threading.Tasks.Task<string> getApellidoPersonaAsync(string documento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPersona", ReplyAction="http://tempuri.org/IService1/addPersonaResponse")]
        long addPersona(clientWSUser.wsUser.Persona persona);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPersona", ReplyAction="http://tempuri.org/IService1/addPersonaResponse")]
        System.Threading.Tasks.Task<long> addPersonaAsync(clientWSUser.wsUser.Persona persona);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePersona", ReplyAction="http://tempuri.org/IService1/deletePersonaResponse")]
        long deletePersona(string documento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePersona", ReplyAction="http://tempuri.org/IService1/deletePersonaResponse")]
        System.Threading.Tasks.Task<long> deletePersonaAsync(string documento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updatePersona", ReplyAction="http://tempuri.org/IService1/updatePersonaResponse")]
        long updatePersona(clientWSUser.wsUser.Persona persona);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updatePersona", ReplyAction="http://tempuri.org/IService1/updatePersonaResponse")]
        System.Threading.Tasks.Task<long> updatePersonaAsync(clientWSUser.wsUser.Persona persona);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : clientWSUser.wsUser.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<clientWSUser.wsUser.IService1>, clientWSUser.wsUser.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long countPersonas() {
            return base.Channel.countPersonas();
        }
        
        public System.Threading.Tasks.Task<long> countPersonasAsync() {
            return base.Channel.countPersonasAsync();
        }
        
        public clientWSUser.wsUser.Persona[] getPersonas() {
            return base.Channel.getPersonas();
        }
        
        public System.Threading.Tasks.Task<clientWSUser.wsUser.Persona[]> getPersonasAsync() {
            return base.Channel.getPersonasAsync();
        }
        
        public clientWSUser.wsUser.Persona getPersona(string documento) {
            return base.Channel.getPersona(documento);
        }
        
        public System.Threading.Tasks.Task<clientWSUser.wsUser.Persona> getPersonaAsync(string documento) {
            return base.Channel.getPersonaAsync(documento);
        }
        
        public string getApellidoPersona(string documento) {
            return base.Channel.getApellidoPersona(documento);
        }
        
        public System.Threading.Tasks.Task<string> getApellidoPersonaAsync(string documento) {
            return base.Channel.getApellidoPersonaAsync(documento);
        }
        
        public long addPersona(clientWSUser.wsUser.Persona persona) {
            return base.Channel.addPersona(persona);
        }
        
        public System.Threading.Tasks.Task<long> addPersonaAsync(clientWSUser.wsUser.Persona persona) {
            return base.Channel.addPersonaAsync(persona);
        }
        
        public long deletePersona(string documento) {
            return base.Channel.deletePersona(documento);
        }
        
        public System.Threading.Tasks.Task<long> deletePersonaAsync(string documento) {
            return base.Channel.deletePersonaAsync(documento);
        }
        
        public long updatePersona(clientWSUser.wsUser.Persona persona) {
            return base.Channel.updatePersona(persona);
        }
        
        public System.Threading.Tasks.Task<long> updatePersonaAsync(clientWSUser.wsUser.Persona persona) {
            return base.Channel.updatePersonaAsync(persona);
        }
    }
}
