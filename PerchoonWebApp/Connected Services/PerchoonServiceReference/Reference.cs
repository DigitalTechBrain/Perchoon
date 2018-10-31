﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerchoonWebApp.PerchoonServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PerchoonServiceReference.GeneralStoreSoap")]
    public interface GeneralStoreSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetAsync();
        
        // CODEGEN: Generating message contract since message UserAuthenticationRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserAuthentication", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PerchoonWebApp.PerchoonServiceReference.UserAuthenticationResponse UserAuthentication(PerchoonWebApp.PerchoonServiceReference.UserAuthenticationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserAuthentication", ReplyAction="*")]
        System.Threading.Tasks.Task<PerchoonWebApp.PerchoonServiceReference.UserAuthenticationResponse> UserAuthenticationAsync(PerchoonWebApp.PerchoonServiceReference.UserAuthenticationRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthUser : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UserAuthentication", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UserAuthenticationRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public PerchoonWebApp.PerchoonServiceReference.AuthUser AuthUser;
        
        public UserAuthenticationRequest() {
        }
        
        public UserAuthenticationRequest(PerchoonWebApp.PerchoonServiceReference.AuthUser AuthUser) {
            this.AuthUser = AuthUser;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UserAuthenticationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UserAuthenticationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string UserAuthenticationResult;
        
        public UserAuthenticationResponse() {
        }
        
        public UserAuthenticationResponse(string UserAuthenticationResult) {
            this.UserAuthenticationResult = UserAuthenticationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GeneralStoreSoapChannel : PerchoonWebApp.PerchoonServiceReference.GeneralStoreSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GeneralStoreSoapClient : System.ServiceModel.ClientBase<PerchoonWebApp.PerchoonServiceReference.GeneralStoreSoap>, PerchoonWebApp.PerchoonServiceReference.GeneralStoreSoap {
        
        public GeneralStoreSoapClient() {
        }
        
        public GeneralStoreSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GeneralStoreSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeneralStoreSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeneralStoreSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataTable Get() {
            return base.Channel.Get();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetAsync() {
            return base.Channel.GetAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PerchoonWebApp.PerchoonServiceReference.UserAuthenticationResponse PerchoonWebApp.PerchoonServiceReference.GeneralStoreSoap.UserAuthentication(PerchoonWebApp.PerchoonServiceReference.UserAuthenticationRequest request) {
            return base.Channel.UserAuthentication(request);
        }
        
        public string UserAuthentication(PerchoonWebApp.PerchoonServiceReference.AuthUser AuthUser) {
            PerchoonWebApp.PerchoonServiceReference.UserAuthenticationRequest inValue = new PerchoonWebApp.PerchoonServiceReference.UserAuthenticationRequest();
            inValue.AuthUser = AuthUser;
            PerchoonWebApp.PerchoonServiceReference.UserAuthenticationResponse retVal = ((PerchoonWebApp.PerchoonServiceReference.GeneralStoreSoap)(this)).UserAuthentication(inValue);
            return retVal.UserAuthenticationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PerchoonWebApp.PerchoonServiceReference.UserAuthenticationResponse> PerchoonWebApp.PerchoonServiceReference.GeneralStoreSoap.UserAuthenticationAsync(PerchoonWebApp.PerchoonServiceReference.UserAuthenticationRequest request) {
            return base.Channel.UserAuthenticationAsync(request);
        }
        
        public System.Threading.Tasks.Task<PerchoonWebApp.PerchoonServiceReference.UserAuthenticationResponse> UserAuthenticationAsync(PerchoonWebApp.PerchoonServiceReference.AuthUser AuthUser) {
            PerchoonWebApp.PerchoonServiceReference.UserAuthenticationRequest inValue = new PerchoonWebApp.PerchoonServiceReference.UserAuthenticationRequest();
            inValue.AuthUser = AuthUser;
            return ((PerchoonWebApp.PerchoonServiceReference.GeneralStoreSoap)(this)).UserAuthenticationAsync(inValue);
        }
    }
}