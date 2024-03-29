﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HiiPGISRolesFault", Namespace="http://hiip.ooh.dhs.vic.gov.au/")]
    [System.SerializableAttribute()]
    public partial class HiiPGISRolesFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://hiip.ooh.dhs.vic.gov.au/", ConfigurationName="HiiPGISRoles.IHiiPRoleService")]
    public interface IHiiPRoleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleNames", ReplyAction="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleNamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.HiiPGISRolesFault), Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleNamesHiiPGISRolesFaultFaul" +
            "t", Name="HiiPGISRolesFault")]
        string[] GetRoleNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetFriendlyRoleNames", ReplyAction="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetFriendlyRoleNamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.HiiPGISRolesFault), Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetFriendlyRoleNamesHiiPGISRolesF" +
            "aultFault", Name="HiiPGISRolesFault")]
        string[] GetFriendlyRoleNames(string[] roles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleNamesForScreenID", ReplyAction="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleNamesForScreenIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.HiiPGISRolesFault), Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleNamesForScreenIDHiiPGISRol" +
            "esFaultFault", Name="HiiPGISRolesFault")]
        System.Collections.Generic.Dictionary<string, bool> GetRoleNamesForScreenID(string screenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleAsString", ReplyAction="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleAsStringResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.HiiPGISRolesFault), Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetRoleAsStringHiiPGISRolesFaultF" +
            "ault", Name="HiiPGISRolesFault")]
        string GetRoleAsString(string rolename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWFSConnection", ReplyAction="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWFSConnectionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.HiiPGISRolesFault), Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWFSConnectionHiiPGISRolesFault" +
            "Fault", Name="HiiPGISRolesFault")]
        string GetWFSConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetStartOptions", ReplyAction="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetStartOptionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.HiiPGISRolesFault), Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetStartOptionsHiiPGISRolesFaultF" +
            "ault", Name="HiiPGISRolesFault")]
        string GetStartOptions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWFSProxyHost", ReplyAction="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWFSProxyHostResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.HiiPGISRolesFault), Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWFSProxyHostHiiPGISRolesFaultF" +
            "ault", Name="HiiPGISRolesFault")]
        string GetWFSProxyHost();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWMSProxyHost", ReplyAction="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWMSProxyHostResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.HiiPGISRolesFault), Action="http://hiip.ooh.dhs.vic.gov.au/IHiiPRoleService/GetWMSProxyHostHiiPGISRolesFaultF" +
            "ault", Name="HiiPGISRolesFault")]
        string GetWMSProxyHost();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IHiiPRoleServiceChannel : HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.IHiiPRoleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class HiiPRoleServiceClient : System.ServiceModel.ClientBase<HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.IHiiPRoleService>, HiiP.Framework.Security.UserManagement.Interface.HiiPGISRoles.IHiiPRoleService {
        
        public HiiPRoleServiceClient() {
        }
        
        public HiiPRoleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HiiPRoleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HiiPRoleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HiiPRoleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetRoleNames() {
            return base.Channel.GetRoleNames();
        }
        
        public string[] GetFriendlyRoleNames(string[] roles) {
            return base.Channel.GetFriendlyRoleNames(roles);
        }
        
        public System.Collections.Generic.Dictionary<string, bool> GetRoleNamesForScreenID(string screenID) {
            return base.Channel.GetRoleNamesForScreenID(screenID);
        }
        
        public string GetRoleAsString(string rolename) {
            return base.Channel.GetRoleAsString(rolename);
        }
        
        public string GetWFSConnection() {
            return base.Channel.GetWFSConnection();
        }
        
        public string GetStartOptions() {
            return base.Channel.GetStartOptions();
        }
        
        public string GetWFSProxyHost() {
            return base.Channel.GetWFSProxyHost();
        }
        
        public string GetWMSProxyHost() {
            return base.Channel.GetWMSProxyHost();
        }
    }
}
