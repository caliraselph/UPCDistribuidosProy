
using System.Collections.Generic;
using System.ServiceModel;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Entidades.Errores;


namespace upcDistribuidos.Servicios.Materiales
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMaterialService" in both code and config file together.
    [ServiceContract]
    public interface IMaterialService
    {
        [FaultContract(typeof(ParametroException))]
        [OperationContract]
        Material ObtenerMaterial(string cod);

        [FaultContract(typeof(ParametroException))]
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Material RegistrarMaterial(Material material);

        [FaultContract(typeof(ParametroException))]
        [OperationContract]
        List<MaterialListar> ListarMateriales(Material material);
    }
}
