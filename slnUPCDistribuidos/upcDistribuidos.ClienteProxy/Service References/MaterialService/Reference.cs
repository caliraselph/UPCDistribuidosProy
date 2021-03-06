﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upcDistribuidos.ClienteProxy.MaterialService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MaterialService.IMaterialService")]
    public interface IMaterialService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialService/ObtenerMaterial", ReplyAction="http://tempuri.org/IMaterialService/ObtenerMaterialResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(upcDistribuidos.Entidades.Errores.ParametroException), Action="http://tempuri.org/IMaterialService/ObtenerMaterialParametroExceptionFault", Name="ParametroException", Namespace="http://schemas.datacontract.org/2004/07/upcDistribuidos.Entidades.Errores")]
        upcDistribuidos.Entidades.Entidades.Material ObtenerMaterial(string cod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialService/ObtenerMaterial", ReplyAction="http://tempuri.org/IMaterialService/ObtenerMaterialResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Material> ObtenerMaterialAsync(string cod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialService/RegistrarMaterial", ReplyAction="http://tempuri.org/IMaterialService/RegistrarMaterialResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(upcDistribuidos.Entidades.Errores.ParametroException), Action="http://tempuri.org/IMaterialService/RegistrarMaterialParametroExceptionFault", Name="ParametroException", Namespace="http://schemas.datacontract.org/2004/07/upcDistribuidos.Entidades.Errores")]
        [System.ServiceModel.FaultContractAttribute(typeof(upcDistribuidos.Entidades.Errores.RepetidoException), Action="http://tempuri.org/IMaterialService/RegistrarMaterialRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/upcDistribuidos.Entidades.Errores")]
        upcDistribuidos.Entidades.Entidades.Material RegistrarMaterial(upcDistribuidos.Entidades.Entidades.Material material);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialService/RegistrarMaterial", ReplyAction="http://tempuri.org/IMaterialService/RegistrarMaterialResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Material> RegistrarMaterialAsync(upcDistribuidos.Entidades.Entidades.Material material);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialService/ListarMateriales", ReplyAction="http://tempuri.org/IMaterialService/ListarMaterialesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(upcDistribuidos.Entidades.Errores.ParametroException), Action="http://tempuri.org/IMaterialService/ListarMaterialesParametroExceptionFault", Name="ParametroException", Namespace="http://schemas.datacontract.org/2004/07/upcDistribuidos.Entidades.Errores")]
        upcDistribuidos.Entidades.Mapper.MaterialListar[] ListarMateriales(upcDistribuidos.Entidades.Entidades.Material material);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialService/ListarMateriales", ReplyAction="http://tempuri.org/IMaterialService/ListarMaterialesResponse")]
        System.Threading.Tasks.Task<upcDistribuidos.Entidades.Mapper.MaterialListar[]> ListarMaterialesAsync(upcDistribuidos.Entidades.Entidades.Material material);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMaterialServiceChannel : upcDistribuidos.ClienteProxy.MaterialService.IMaterialService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MaterialServiceClient : System.ServiceModel.ClientBase<upcDistribuidos.ClienteProxy.MaterialService.IMaterialService>, upcDistribuidos.ClienteProxy.MaterialService.IMaterialService {
        
        public MaterialServiceClient() {
        }
        
        public MaterialServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MaterialServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaterialServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaterialServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public upcDistribuidos.Entidades.Entidades.Material ObtenerMaterial(string cod) {
            return base.Channel.ObtenerMaterial(cod);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Material> ObtenerMaterialAsync(string cod) {
            return base.Channel.ObtenerMaterialAsync(cod);
        }
        
        public upcDistribuidos.Entidades.Entidades.Material RegistrarMaterial(upcDistribuidos.Entidades.Entidades.Material material) {
            return base.Channel.RegistrarMaterial(material);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Entidades.Material> RegistrarMaterialAsync(upcDistribuidos.Entidades.Entidades.Material material) {
            return base.Channel.RegistrarMaterialAsync(material);
        }
        
        public upcDistribuidos.Entidades.Mapper.MaterialListar[] ListarMateriales(upcDistribuidos.Entidades.Entidades.Material material) {
            return base.Channel.ListarMateriales(material);
        }
        
        public System.Threading.Tasks.Task<upcDistribuidos.Entidades.Mapper.MaterialListar[]> ListarMaterialesAsync(upcDistribuidos.Entidades.Entidades.Material material) {
            return base.Channel.ListarMaterialesAsync(material);
        }
    }
}
