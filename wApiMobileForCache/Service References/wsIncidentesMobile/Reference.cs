﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetFullList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetFullList(string pTbl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetFullList", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetFullListAsync(string pTbl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetHC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetHC(long pInc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetHC", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetHCAsync(long pInc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViaje", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetViaje(long pInc, string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViaje", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetViajeAsync(long pInc, string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViajeV2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetViajeV2(long pInc, string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViajeV2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetViajeV2Async(long pInc, string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViajesMovil", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetViajesMovil(string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.GetViajesMovil", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetViajesMovilAsync(string pMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetCancelacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SetCancelacion(long pInc, string pMov, string pObs, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetCancelacion", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SetCancelacionAsync(long pInc, string pMov, string pObs, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetFinal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SetFinal(long pInc, string pMov, long pDig, long pMot, long pAviCos, string pObs, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetFinal", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SetFinalAsync(long pInc, string pMov, long pDig, long pMot, long pAviCos, string pObs, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetFinalV2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SetFinalV2(long pInc, string pMov, long pDig, long pMot, long pAviCos, long pNroRpt, string pObs, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetFinalV2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SetFinalV2Async(long pInc, string pMov, long pDig, long pMot, long pAviCos, long pNroRpt, string pObs, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetFinalV3", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SetFinalV3(long pInc, string pMov, long pDig, long pMot, long pAviCos, long pHorEsp, long pMinEsp, long pNroRpt, string pObs, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetFinalV3", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SetFinalV3Async(long pInc, string pMov, long pDig, long pMot, long pAviCos, long pHorEsp, long pMinEsp, long pNroRpt, string pObs, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetLlegada", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SetLlegada(long pInc, string pMov, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetLlegada", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SetLlegadaAsync(long pInc, string pMov, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetSalida", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SetSalida(long pInc, string pMov, decimal pLat, decimal pLon, string pUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WebServices.IncidentesMobile.SetSalida", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SetSalidaAsync(long pInc, string pMov, decimal pLat, decimal pLon, string pUsr);
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
        
        public System.Data.DataSet GetFullList(string pTbl) {
            return base.Channel.GetFullList(pTbl);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetFullListAsync(string pTbl) {
            return base.Channel.GetFullListAsync(pTbl);
        }
        
        public System.Data.DataSet GetHC(long pInc) {
            return base.Channel.GetHC(pInc);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetHCAsync(long pInc) {
            return base.Channel.GetHCAsync(pInc);
        }
        
        public System.Data.DataSet GetViaje(long pInc, string pMov) {
            return base.Channel.GetViaje(pInc, pMov);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetViajeAsync(long pInc, string pMov) {
            return base.Channel.GetViajeAsync(pInc, pMov);
        }
        
        public System.Data.DataSet GetViajeV2(long pInc, string pMov) {
            return base.Channel.GetViajeV2(pInc, pMov);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetViajeV2Async(long pInc, string pMov) {
            return base.Channel.GetViajeV2Async(pInc, pMov);
        }
        
        public System.Data.DataSet GetViajesMovil(string pMov) {
            return base.Channel.GetViajesMovil(pMov);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetViajesMovilAsync(string pMov) {
            return base.Channel.GetViajesMovilAsync(pMov);
        }
        
        public System.Data.DataSet SetCancelacion(long pInc, string pMov, string pObs, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetCancelacion(pInc, pMov, pObs, pLat, pLon, pUsr);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SetCancelacionAsync(long pInc, string pMov, string pObs, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetCancelacionAsync(pInc, pMov, pObs, pLat, pLon, pUsr);
        }
        
        public System.Data.DataSet SetFinal(long pInc, string pMov, long pDig, long pMot, long pAviCos, string pObs, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetFinal(pInc, pMov, pDig, pMot, pAviCos, pObs, pLat, pLon, pUsr);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SetFinalAsync(long pInc, string pMov, long pDig, long pMot, long pAviCos, string pObs, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetFinalAsync(pInc, pMov, pDig, pMot, pAviCos, pObs, pLat, pLon, pUsr);
        }
        
        public System.Data.DataSet SetFinalV2(long pInc, string pMov, long pDig, long pMot, long pAviCos, long pNroRpt, string pObs, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetFinalV2(pInc, pMov, pDig, pMot, pAviCos, pNroRpt, pObs, pLat, pLon, pUsr);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SetFinalV2Async(long pInc, string pMov, long pDig, long pMot, long pAviCos, long pNroRpt, string pObs, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetFinalV2Async(pInc, pMov, pDig, pMot, pAviCos, pNroRpt, pObs, pLat, pLon, pUsr);
        }
        
        public System.Data.DataSet SetFinalV3(long pInc, string pMov, long pDig, long pMot, long pAviCos, long pHorEsp, long pMinEsp, long pNroRpt, string pObs, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetFinalV3(pInc, pMov, pDig, pMot, pAviCos, pHorEsp, pMinEsp, pNroRpt, pObs, pLat, pLon, pUsr);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SetFinalV3Async(long pInc, string pMov, long pDig, long pMot, long pAviCos, long pHorEsp, long pMinEsp, long pNroRpt, string pObs, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetFinalV3Async(pInc, pMov, pDig, pMot, pAviCos, pHorEsp, pMinEsp, pNroRpt, pObs, pLat, pLon, pUsr);
        }
        
        public System.Data.DataSet SetLlegada(long pInc, string pMov, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetLlegada(pInc, pMov, pLat, pLon, pUsr);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SetLlegadaAsync(long pInc, string pMov, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetLlegadaAsync(pInc, pMov, pLat, pLon, pUsr);
        }
        
        public System.Data.DataSet SetSalida(long pInc, string pMov, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetSalida(pInc, pMov, pLat, pLon, pUsr);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SetSalidaAsync(long pInc, string pMov, decimal pLat, decimal pLon, string pUsr) {
            return base.Channel.SetSalidaAsync(pInc, pMov, pLat, pLon, pUsr);
        }
    }
}
