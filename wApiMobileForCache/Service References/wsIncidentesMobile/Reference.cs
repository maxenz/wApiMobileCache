﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wApiMobileForCache.wsIncidentesMobile {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="wsIncidentesMobile.IncidentesMobileSoap")]
    public interface IncidentesMobileSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViaje", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetViaje(string pVij, string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViaje", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetViajeAsync(string pVij, string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViajesMovil", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetViajesMovil(string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViajesMovil", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetViajesMovilAsync(string pMov);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IncidentesMobileSoapChannel : wApiMobileForCache.wsIncidentesMobile.IncidentesMobileSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IncidentesMobileSoapClient : System.ServiceModel.ClientBase<wApiMobileForCache.wsIncidentesMobile.IncidentesMobileSoap>, wApiMobileForCache.wsIncidentesMobile.IncidentesMobileSoap {
        
        public IncidentesMobileSoapClient() {
        }
        
        public IncidentesMobileSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IncidentesMobileSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IncidentesMobileSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IncidentesMobileSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetViaje(string pVij, string pMov) {
            return base.Channel.GetViaje(pVij, pMov);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetViajeAsync(string pVij, string pMov) {
            return base.Channel.GetViajeAsync(pVij, pMov);
        }
        
        public System.Data.DataSet GetViajesMovil(string pMov) {
            return base.Channel.GetViajesMovil(pMov);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetViajesMovilAsync(string pMov) {
            return base.Channel.GetViajesMovilAsync(pMov);
        }
    }
}
