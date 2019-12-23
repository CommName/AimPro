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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomProperties", Namespace="http://schemas.datacontract.org/2004/07/AIMProLibrary")]
    [System.SerializableAttribute()]
    public partial class RoomProperties : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AIMProClient.AIMProService.CursorType CursorTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AIMProClient.AIMProService.GameMode GameModeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AIMProClient.AIMProService.RoomSettings SettingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AIMProClient.AIMProService.TargetTypes TargetTypesAllowedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int maxPlayersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberOfTargetsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] seedField;
        
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
        public AIMProClient.AIMProService.CursorType CursorType {
            get {
                return this.CursorTypeField;
            }
            set {
                if ((this.CursorTypeField.Equals(value) != true)) {
                    this.CursorTypeField = value;
                    this.RaisePropertyChanged("CursorType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AIMProClient.AIMProService.GameMode GameMode {
            get {
                return this.GameModeField;
            }
            set {
                if ((this.GameModeField.Equals(value) != true)) {
                    this.GameModeField = value;
                    this.RaisePropertyChanged("GameMode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AIMProClient.AIMProService.RoomSettings Settings {
            get {
                return this.SettingsField;
            }
            set {
                if ((this.SettingsField.Equals(value) != true)) {
                    this.SettingsField = value;
                    this.RaisePropertyChanged("Settings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AIMProClient.AIMProService.TargetTypes TargetTypesAllowed {
            get {
                return this.TargetTypesAllowedField;
            }
            set {
                if ((this.TargetTypesAllowedField.Equals(value) != true)) {
                    this.TargetTypesAllowedField = value;
                    this.RaisePropertyChanged("TargetTypesAllowed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int maxPlayers {
            get {
                return this.maxPlayersField;
            }
            set {
                if ((this.maxPlayersField.Equals(value) != true)) {
                    this.maxPlayersField = value;
                    this.RaisePropertyChanged("maxPlayers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numberOfTargets {
            get {
                return this.numberOfTargetsField;
            }
            set {
                if ((this.numberOfTargetsField.Equals(value) != true)) {
                    this.numberOfTargetsField = value;
                    this.RaisePropertyChanged("numberOfTargets");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] seed {
            get {
                return this.seedField;
            }
            set {
                if ((object.ReferenceEquals(this.seedField, value) != true)) {
                    this.seedField = value;
                    this.RaisePropertyChanged("seed");
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
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="CursorType", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum CursorType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Piercing = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Explosive = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Limited = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Drunk = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Bazooka = 16,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="GameMode", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum GameMode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Duel = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MultyPlayerShootOut = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FastShooting = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PreciseShooting = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EndlessCampaign = 16,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomSettings", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum RoomSettings : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hidden = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PasswordProtected = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EloRestricted = 8,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="TargetTypes", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum TargetTypes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Moving = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Shielded = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Boost = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Negative = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Child = 16,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomState", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class RoomState : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AIMProClient.AIMProService.RoomSettings RoomSettingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int currentNumberOfPlayersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AIMProClient.AIMProService.GameMode gameModesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int maxNumberOfPlayersField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AIMProClient.AIMProService.RoomSettings RoomSettings {
            get {
                return this.RoomSettingsField;
            }
            set {
                if ((this.RoomSettingsField.Equals(value) != true)) {
                    this.RoomSettingsField = value;
                    this.RaisePropertyChanged("RoomSettings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int currentNumberOfPlayers {
            get {
                return this.currentNumberOfPlayersField;
            }
            set {
                if ((this.currentNumberOfPlayersField.Equals(value) != true)) {
                    this.currentNumberOfPlayersField = value;
                    this.RaisePropertyChanged("currentNumberOfPlayers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AIMProClient.AIMProService.GameMode gameModes {
            get {
                return this.gameModesField;
            }
            set {
                if ((this.gameModesField.Equals(value) != true)) {
                    this.gameModesField = value;
                    this.RaisePropertyChanged("gameModes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int maxNumberOfPlayers {
            get {
                return this.maxNumberOfPlayersField;
            }
            set {
                if ((this.maxNumberOfPlayersField.Equals(value) != true)) {
                    this.maxNumberOfPlayersField = value;
                    this.RaisePropertyChanged("maxNumberOfPlayers");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/createRoom", ReplyAction="http://tempuri.org/IAIMProServerService/createRoomResponse")]
        void createRoom(AIMProClient.AIMProService.RoomProperties settings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/createRoom", ReplyAction="http://tempuri.org/IAIMProServerService/createRoomResponse")]
        System.Threading.Tasks.Task createRoomAsync(AIMProClient.AIMProService.RoomProperties settings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/joinRoom", ReplyAction="http://tempuri.org/IAIMProServerService/joinRoomResponse")]
        void joinRoom(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/joinRoom", ReplyAction="http://tempuri.org/IAIMProServerService/joinRoomResponse")]
        System.Threading.Tasks.Task joinRoomAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/GetRooms", ReplyAction="http://tempuri.org/IAIMProServerService/GetRoomsResponse")]
        System.Collections.Generic.List<AIMProClient.AIMProService.RoomState> GetRooms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/GetRooms", ReplyAction="http://tempuri.org/IAIMProServerService/GetRoomsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AIMProClient.AIMProService.RoomState>> GetRoomsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/getProfiles", ReplyAction="http://tempuri.org/IAIMProServerService/getProfilesResponse")]
        System.Collections.Generic.List<AIMProClient.AIMProService.User> getProfiles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/getProfiles", ReplyAction="http://tempuri.org/IAIMProServerService/getProfilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AIMProClient.AIMProService.User>> getProfilesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/submitHit", ReplyAction="http://tempuri.org/IAIMProServerService/submitHitResponse")]
        void submitHit(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAIMProServerService/submitHit", ReplyAction="http://tempuri.org/IAIMProServerService/submitHitResponse")]
        System.Threading.Tasks.Task submitHitAsync(int x, int y);
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
        
        public void createRoom(AIMProClient.AIMProService.RoomProperties settings) {
            base.Channel.createRoom(settings);
        }
        
        public System.Threading.Tasks.Task createRoomAsync(AIMProClient.AIMProService.RoomProperties settings) {
            return base.Channel.createRoomAsync(settings);
        }
        
        public void joinRoom(int id) {
            base.Channel.joinRoom(id);
        }
        
        public System.Threading.Tasks.Task joinRoomAsync(int id) {
            return base.Channel.joinRoomAsync(id);
        }
        
        public System.Collections.Generic.List<AIMProClient.AIMProService.RoomState> GetRooms() {
            return base.Channel.GetRooms();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AIMProClient.AIMProService.RoomState>> GetRoomsAsync() {
            return base.Channel.GetRoomsAsync();
        }
        
        public System.Collections.Generic.List<AIMProClient.AIMProService.User> getProfiles() {
            return base.Channel.getProfiles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AIMProClient.AIMProService.User>> getProfilesAsync() {
            return base.Channel.getProfilesAsync();
        }
        
        public void submitHit(int x, int y) {
            base.Channel.submitHit(x, y);
        }
        
        public System.Threading.Tasks.Task submitHitAsync(int x, int y) {
            return base.Channel.submitHitAsync(x, y);
        }
    }
}
