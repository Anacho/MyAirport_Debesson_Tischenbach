﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.FormIhm.ServiceBagage {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BagageDefinition", Namespace="http://schemas.datacontract.org/2004/07/MyAirport.Pim.Entities")]
    [System.SerializableAttribute()]
    public partial class BagageDefinition : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClasseBagageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeIataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompagnieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ContinuationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateVolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBagageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItineraireField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short JourExploitationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LigneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char LigneAlphaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool RushField;
        
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
        public string ClasseBagage {
            get {
                return this.ClasseBagageField;
            }
            set {
                if ((object.ReferenceEquals(this.ClasseBagageField, value) != true)) {
                    this.ClasseBagageField = value;
                    this.RaisePropertyChanged("ClasseBagage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodeIata {
            get {
                return this.CodeIataField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeIataField, value) != true)) {
                    this.CodeIataField = value;
                    this.RaisePropertyChanged("CodeIata");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Compagnie {
            get {
                return this.CompagnieField;
            }
            set {
                if ((object.ReferenceEquals(this.CompagnieField, value) != true)) {
                    this.CompagnieField = value;
                    this.RaisePropertyChanged("Compagnie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Continuation {
            get {
                return this.ContinuationField;
            }
            set {
                if ((this.ContinuationField.Equals(value) != true)) {
                    this.ContinuationField = value;
                    this.RaisePropertyChanged("Continuation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateVol {
            get {
                return this.DateVolField;
            }
            set {
                if ((this.DateVolField.Equals(value) != true)) {
                    this.DateVolField = value;
                    this.RaisePropertyChanged("DateVol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBagage {
            get {
                return this.IdBagageField;
            }
            set {
                if ((this.IdBagageField.Equals(value) != true)) {
                    this.IdBagageField = value;
                    this.RaisePropertyChanged("IdBagage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Itineraire {
            get {
                return this.ItineraireField;
            }
            set {
                if ((object.ReferenceEquals(this.ItineraireField, value) != true)) {
                    this.ItineraireField = value;
                    this.RaisePropertyChanged("Itineraire");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short JourExploitation {
            get {
                return this.JourExploitationField;
            }
            set {
                if ((this.JourExploitationField.Equals(value) != true)) {
                    this.JourExploitationField = value;
                    this.RaisePropertyChanged("JourExploitation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ligne {
            get {
                return this.LigneField;
            }
            set {
                if ((object.ReferenceEquals(this.LigneField, value) != true)) {
                    this.LigneField = value;
                    this.RaisePropertyChanged("Ligne");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char LigneAlpha {
            get {
                return this.LigneAlphaField;
            }
            set {
                if ((this.LigneAlphaField.Equals(value) != true)) {
                    this.LigneAlphaField = value;
                    this.RaisePropertyChanged("LigneAlpha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Rush {
            get {
                return this.RushField;
            }
            set {
                if ((this.RushField.Equals(value) != true)) {
                    this.RushField = value;
                    this.RaisePropertyChanged("Rush");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MultiBagageException", Namespace="http://schemas.datacontract.org/2004/07/MyAirport.Pim.Entities")]
    [System.SerializableAttribute()]
    public partial class MultiBagageException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeIATAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.FormIhm.ServiceBagage.BagageDefinition[] resBagagesField;
        
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
        public string CodeIATA {
            get {
                return this.CodeIATAField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeIATAField, value) != true)) {
                    this.CodeIATAField = value;
                    this.RaisePropertyChanged("CodeIATA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.FormIhm.ServiceBagage.BagageDefinition[] resBagages {
            get {
                return this.resBagagesField;
            }
            set {
                if ((object.ReferenceEquals(this.resBagagesField, value) != true)) {
                    this.resBagagesField = value;
                    this.RaisePropertyChanged("resBagages");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RoutageBagage", Namespace="http://schemas.datacontract.org/2004/07/MyAirport.Pim.Entities")]
    [System.SerializableAttribute()]
    public partial class RoutageBagage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LocalisationEjectionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LocalisationSureteN1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LocalisationSuretetN3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomEjectionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomSureteN1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomSureteN3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatutEjectionField;
        
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
        public int LocalisationEjection {
            get {
                return this.LocalisationEjectionField;
            }
            set {
                if ((this.LocalisationEjectionField.Equals(value) != true)) {
                    this.LocalisationEjectionField = value;
                    this.RaisePropertyChanged("LocalisationEjection");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LocalisationSureteN1 {
            get {
                return this.LocalisationSureteN1Field;
            }
            set {
                if ((this.LocalisationSureteN1Field.Equals(value) != true)) {
                    this.LocalisationSureteN1Field = value;
                    this.RaisePropertyChanged("LocalisationSureteN1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LocalisationSuretetN3 {
            get {
                return this.LocalisationSuretetN3Field;
            }
            set {
                if ((this.LocalisationSuretetN3Field.Equals(value) != true)) {
                    this.LocalisationSuretetN3Field = value;
                    this.RaisePropertyChanged("LocalisationSuretetN3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomEjection {
            get {
                return this.NomEjectionField;
            }
            set {
                if ((object.ReferenceEquals(this.NomEjectionField, value) != true)) {
                    this.NomEjectionField = value;
                    this.RaisePropertyChanged("NomEjection");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomSureteN1 {
            get {
                return this.NomSureteN1Field;
            }
            set {
                if ((object.ReferenceEquals(this.NomSureteN1Field, value) != true)) {
                    this.NomSureteN1Field = value;
                    this.RaisePropertyChanged("NomSureteN1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomSureteN3 {
            get {
                return this.NomSureteN3Field;
            }
            set {
                if ((object.ReferenceEquals(this.NomSureteN3Field, value) != true)) {
                    this.NomSureteN3Field = value;
                    this.RaisePropertyChanged("NomSureteN3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatutEjection {
            get {
                return this.StatutEjectionField;
            }
            set {
                if ((object.ReferenceEquals(this.StatutEjectionField, value) != true)) {
                    this.StatutEjectionField = value;
                    this.RaisePropertyChanged("StatutEjection");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBagage.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBagageById", ReplyAction="http://tempuri.org/IService/GetBagageByIdResponse")]
        Client.FormIhm.ServiceBagage.BagageDefinition GetBagageById(int idBagage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBagageById", ReplyAction="http://tempuri.org/IService/GetBagageByIdResponse")]
        System.Threading.Tasks.Task<Client.FormIhm.ServiceBagage.BagageDefinition> GetBagageByIdAsync(int idBagage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBagageByCodeIata", ReplyAction="http://tempuri.org/IService/GetBagageByCodeIataResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.FormIhm.ServiceBagage.MultiBagageException), Action="http://tempuri.org/IService/GetBagageByCodeIataMultiBagageExceptionFault", Name="MultiBagageException", Namespace="http://schemas.datacontract.org/2004/07/MyAirport.Pim.Entities")]
        Client.FormIhm.ServiceBagage.BagageDefinition GetBagageByCodeIata(string codeIata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBagageByCodeIata", ReplyAction="http://tempuri.org/IService/GetBagageByCodeIataResponse")]
        System.Threading.Tasks.Task<Client.FormIhm.ServiceBagage.BagageDefinition> GetBagageByCodeIataAsync(string codeIata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateBagage", ReplyAction="http://tempuri.org/IService/CreateBagageResponse")]
        int CreateBagage(Client.FormIhm.ServiceBagage.BagageDefinition bagage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateBagage", ReplyAction="http://tempuri.org/IService/CreateBagageResponse")]
        System.Threading.Tasks.Task<int> CreateBagageAsync(Client.FormIhm.ServiceBagage.BagageDefinition bagage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetInfoRoutage", ReplyAction="http://tempuri.org/IService/GetInfoRoutageResponse")]
        Client.FormIhm.ServiceBagage.RoutageBagage GetInfoRoutage(int idBagage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetInfoRoutage", ReplyAction="http://tempuri.org/IService/GetInfoRoutageResponse")]
        System.Threading.Tasks.Task<Client.FormIhm.ServiceBagage.RoutageBagage> GetInfoRoutageAsync(int idBagage);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.FormIhm.ServiceBagage.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client.FormIhm.ServiceBagage.IService>, Client.FormIhm.ServiceBagage.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.FormIhm.ServiceBagage.BagageDefinition GetBagageById(int idBagage) {
            return base.Channel.GetBagageById(idBagage);
        }
        
        public System.Threading.Tasks.Task<Client.FormIhm.ServiceBagage.BagageDefinition> GetBagageByIdAsync(int idBagage) {
            return base.Channel.GetBagageByIdAsync(idBagage);
        }
        
        public Client.FormIhm.ServiceBagage.BagageDefinition GetBagageByCodeIata(string codeIata) {
            return base.Channel.GetBagageByCodeIata(codeIata);
        }
        
        public System.Threading.Tasks.Task<Client.FormIhm.ServiceBagage.BagageDefinition> GetBagageByCodeIataAsync(string codeIata) {
            return base.Channel.GetBagageByCodeIataAsync(codeIata);
        }
        
        public int CreateBagage(Client.FormIhm.ServiceBagage.BagageDefinition bagage) {
            return base.Channel.CreateBagage(bagage);
        }
        
        public System.Threading.Tasks.Task<int> CreateBagageAsync(Client.FormIhm.ServiceBagage.BagageDefinition bagage) {
            return base.Channel.CreateBagageAsync(bagage);
        }
        
        public Client.FormIhm.ServiceBagage.RoutageBagage GetInfoRoutage(int idBagage) {
            return base.Channel.GetInfoRoutage(idBagage);
        }
        
        public System.Threading.Tasks.Task<Client.FormIhm.ServiceBagage.RoutageBagage> GetInfoRoutageAsync(int idBagage) {
            return base.Channel.GetInfoRoutageAsync(idBagage);
        }
    }
}