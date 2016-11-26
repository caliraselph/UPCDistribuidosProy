﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upcDistribuidos.ClienteProxy.PersonaService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonaService.IPersonaService")]
    public interface IPersonaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ListarPersonas", ReplyAction="http://tempuri.org/IPersonaService/ListarPersonasResponse")]
        upcDistribuidos.Entidades.Entidades.Persona[] ListarPersonas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ListarPersonas", ReplyAction="http://tempuri.org/IPersonaService/ListarPersonasResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Persona[]> ListarPersonasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersona", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaResponse")]
        upcDistribuidos.Entidades.Entidades.Persona ObtenerPersona(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersona", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Persona> ObtenerPersonaAsync(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/RegistrarPersona", ReplyAction="http://tempuri.org/IPersonaService/RegistrarPersonaResponse")]
        upcDistribuidos.Entidades.Entidades.Persona RegistrarPersona(upcDistribuidos.Entidades.Entidades.Persona persona);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/RegistrarPersona", ReplyAction="http://tempuri.org/IPersonaService/RegistrarPersonaResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Persona> RegistrarPersonaAsync(upcDistribuidos.Entidades.Entidades.Persona persona);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ActualizarPersona", ReplyAction="http://tempuri.org/IPersonaService/ActualizarPersonaResponse")]
        upcDistribuidos.Entidades.Entidades.Persona ActualizarPersona(upcDistribuidos.Entidades.Entidades.Persona persona);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ActualizarPersona", ReplyAction="http://tempuri.org/IPersonaService/ActualizarPersonaResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Persona> ActualizarPersonaAsync(upcDistribuidos.Entidades.Entidades.Persona persona);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonaServiceChannel : upcDistribuidos.ClienteProxy.PersonaService.IPersonaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonaServiceClient : System.ServiceModel.ClientBase<upcDistribuidos.ClienteProxy.PersonaService.IPersonaService>, upcDistribuidos.ClienteProxy.PersonaService.IPersonaService {
        
        public PersonaServiceClient() {
        }
        
        public PersonaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public upcDistribuidos.Entidades.Entidades.Persona[] ListarPersonas() {
            return base.Channel.ListarPersonas();
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Persona[]> ListarPersonasAsync() {
            return base.Channel.ListarPersonasAsync();
        }
        
        public upcDistribuidos.Entidades.Entidades.Persona ObtenerPersona(string codigo) {
            return base.Channel.ObtenerPersona(codigo);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Persona> ObtenerPersonaAsync(string codigo) {
            return base.Channel.ObtenerPersonaAsync(codigo);
        }
        
        public upcDistribuidos.Entidades.Entidades.Persona RegistrarPersona(upcDistribuidos.Entidades.Entidades.Persona persona) {
            return base.Channel.RegistrarPersona(persona);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Persona> RegistrarPersonaAsync(upcDistribuidos.Entidades.Entidades.Persona persona) {
            return base.Channel.RegistrarPersonaAsync(persona);
        }
        
        public upcDistribuidos.Entidades.Entidades.Persona ActualizarPersona(upcDistribuidos.Entidades.Entidades.Persona persona) {
            return base.Channel.ActualizarPersona(persona);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Persona> ActualizarPersonaAsync(upcDistribuidos.Entidades.Entidades.Persona persona) {
            return base.Channel.ActualizarPersonaAsync(persona);
        }
    }
}
