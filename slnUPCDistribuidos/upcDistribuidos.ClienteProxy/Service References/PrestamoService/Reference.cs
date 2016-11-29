﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upcDistribuidos.ClienteProxy.PrestamoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PrestamoService.IPrestamoService")]
    public interface IPrestamoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamoService/BuscarPrestamo", ReplyAction="http://tempuri.org/IPrestamoService/BuscarPrestamoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(upcDistribuidos.Entidades.Errores.ParametroException), Action="http://tempuri.org/IPrestamoService/BuscarPrestamoParametroExceptionFault", Name="ParametroException", Namespace="http://schemas.datacontract.org/2004/07/upcDistribuidos.Entidades.Errores")]
        upcDistribuidos.Entidades.Mapper.PrestamoListar[] BuscarPrestamo(string codigo, string estado, string persona, string fechaPresIni, string fechaPresFin, string fechaDevIni, string fechaDevFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamoService/BuscarPrestamo", ReplyAction="http://tempuri.org/IPrestamoService/BuscarPrestamoResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Mapper.PrestamoListar[]> BuscarPrestamoAsync(string codigo, string estado, string persona, string fechaPresIni, string fechaPresFin, string fechaDevIni, string fechaDevFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamoService/ObtenerPrestamo", ReplyAction="http://tempuri.org/IPrestamoService/ObtenerPrestamoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(upcDistribuidos.Entidades.Errores.ParametroException), Action="http://tempuri.org/IPrestamoService/ObtenerPrestamoParametroExceptionFault", Name="ParametroException", Namespace="http://schemas.datacontract.org/2004/07/upcDistribuidos.Entidades.Errores")]
        upcDistribuidos.Entidades.Entidades.Prestamo ObtenerPrestamo(string cod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamoService/ObtenerPrestamo", ReplyAction="http://tempuri.org/IPrestamoService/ObtenerPrestamoResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Prestamo> ObtenerPrestamoAsync(string cod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamoService/RegistrarPrestamo", ReplyAction="http://tempuri.org/IPrestamoService/RegistrarPrestamoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(upcDistribuidos.Entidades.Errores.ParametroException), Action="http://tempuri.org/IPrestamoService/RegistrarPrestamoParametroExceptionFault", Name="ParametroException", Namespace="http://schemas.datacontract.org/2004/07/upcDistribuidos.Entidades.Errores")]
        upcDistribuidos.Entidades.Entidades.Prestamo RegistrarPrestamo(upcDistribuidos.Entidades.Entidades.Prestamo prestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamoService/RegistrarPrestamo", ReplyAction="http://tempuri.org/IPrestamoService/RegistrarPrestamoResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Prestamo> RegistrarPrestamoAsync(upcDistribuidos.Entidades.Entidades.Prestamo prestamo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrestamoServiceChannel : upcDistribuidos.ClienteProxy.PrestamoService.IPrestamoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrestamoServiceClient : System.ServiceModel.ClientBase<upcDistribuidos.ClienteProxy.PrestamoService.IPrestamoService>, upcDistribuidos.ClienteProxy.PrestamoService.IPrestamoService {
        
        public PrestamoServiceClient() {
        }
        
        public PrestamoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrestamoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrestamoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrestamoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public upcDistribuidos.Entidades.Mapper.PrestamoListar[] BuscarPrestamo(string codigo, string estado, string persona, string fechaPresIni, string fechaPresFin, string fechaDevIni, string fechaDevFin) {
            return base.Channel.BuscarPrestamo(codigo, estado, persona, fechaPresIni, fechaPresFin, fechaDevIni, fechaDevFin);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Mapper.PrestamoListar[]> BuscarPrestamoAsync(string codigo, string estado, string persona, string fechaPresIni, string fechaPresFin, string fechaDevIni, string fechaDevFin) {
            return base.Channel.BuscarPrestamoAsync(codigo, estado, persona, fechaPresIni, fechaPresFin, fechaDevIni, fechaDevFin);
        }
        
        public upcDistribuidos.Entidades.Entidades.Prestamo ObtenerPrestamo(string cod) {
            return base.Channel.ObtenerPrestamo(cod);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Prestamo> ObtenerPrestamoAsync(string cod) {
            return base.Channel.ObtenerPrestamoAsync(cod);
        }
        
        public upcDistribuidos.Entidades.Entidades.Prestamo RegistrarPrestamo(upcDistribuidos.Entidades.Entidades.Prestamo prestamo) {
            return base.Channel.RegistrarPrestamo(prestamo);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Prestamo> RegistrarPrestamoAsync(upcDistribuidos.Entidades.Entidades.Prestamo prestamo) {
            return base.Channel.RegistrarPrestamoAsync(prestamo);
        }
    }
}
