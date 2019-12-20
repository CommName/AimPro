﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIMProClient.AIMProService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<AIMProClient.AIMProService.Matches> MatchHistoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public int Elo {
            get {
                return this.EloField;
            }
            set {
                if ((this.EloField.Equals(value) != true)) {
                    this.EloField = value;
                    this.RaisePropertyChanged("Elo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AIMProClient.AIMProService.Matches> MatchHistory {
            get {
                return this.MatchHistoryField;
            }
            set {
                if ((object.ReferenceEquals(this.MatchHistoryField, value) != true)) {
                    this.MatchHistoryField = value;
                    this.RaisePropertyChanged("MatchHistory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Matches", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Matches : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberOfHitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalNumberOfTargetsField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumberOfHits {
            get {
                return this.NumberOfHitsField;
            }
            set {
                if ((this.NumberOfHitsField.Equals(value) != true)) {
                    this.NumberOfHitsField = value;
                    this.RaisePropertyChanged("NumberOfHits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalNumberOfTargets {
            get {
                return this.TotalNumberOfTargetsField;
            }
            set {
                if ((this.TotalNumberOfTargetsField.Equals(value) != true)) {
                    this.TotalNumberOfTargetsField = value;
                    this.RaisePropertyChanged("TotalNumberOfTargets");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AIMProService.IAIMProServerService")]
    public interface IAIMProServerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/login", ReplyAction="http://tempuri.org/IAIMProServerService/loginResponse")]
        bool login(string username, byte[] pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/login", ReplyAction="http://tempuri.org/IAIMProServerService/loginResponse")]
        System.Threading.Tasks.Task<bool> loginAsync(string username, byte[] pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/signUp", ReplyAction="http://tempuri.org/IAIMProServerService/signUpResponse")]
        bool signUp(string username, byte[] pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/signUp", ReplyAction="http://tempuri.org/IAIMProServerService/signUpResponse")]
        System.Threading.Tasks.Task<bool> signUpAsync(string username, byte[] pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/getProfile", ReplyAction="http://tempuri.org/IAIMProServerService/getProfileResponse")]
        AIMProClient.AIMProService.User getProfile(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/getProfile", ReplyAction="http://tempuri.org/IAIMProServerService/getProfileResponse")]
        System.Threading.Tasks.Task<AIMProClient.AIMProService.User> getProfileAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/getProfiles", ReplyAction="http://tempuri.org/IAIMProServerService/getProfilesResponse")]
        System.Collections.Generic.List<AIMProClient.AIMProService.User> getProfiles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/getProfiles", ReplyAction="http://tempuri.org/IAIMProServerService/getProfilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AIMProClient.AIMProService.User>> getProfilesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAIMProServerServiceChannel : AIMProClient.AIMProService.IAIMProServerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AIMProServerServiceClient : System.ServiceModel.ClientBase<AIMProClient.AIMProService.IAIMProServerService>, AIMProClient.AIMProService.IAIMProServerService {
        
        public AIMProServerServiceClient() {
        }
        
        public AIMProServerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AIMProServerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AIMProServerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AIMProServerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool login(string username, byte[] pass) {
            return base.Channel.login(username, pass);
        }
        
        public System.Threading.Tasks.Task<bool> loginAsync(string username, byte[] pass) {
            return base.Channel.loginAsync(username, pass);
        }
        
        public bool signUp(string username, byte[] pass) {
            return base.Channel.signUp(username, pass);
        }
        
        public System.Threading.Tasks.Task<bool> signUpAsync(string username, byte[] pass) {
            return base.Channel.signUpAsync(username, pass);
        }
        
        public AIMProClient.AIMProService.User getProfile(string username) {
            return base.Channel.getProfile(username);
        }
        
        public System.Threading.Tasks.Task<AIMProClient.AIMProService.User> getProfileAsync(string username) {
            return base.Channel.getProfileAsync(username);
        }
        
        public System.Collections.Generic.List<AIMProClient.AIMProService.User> getProfiles() {
            return base.Channel.getProfiles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AIMProClient.AIMProService.User>> getProfilesAsync() {
            return base.Channel.getProfilesAsync();
        }
    }
}
