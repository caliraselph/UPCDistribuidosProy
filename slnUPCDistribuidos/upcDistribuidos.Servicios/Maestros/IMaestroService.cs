using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using upcDistribuidos.Entidades.Entidades;


namespace upcDistribuidos.Servicios.Maestros
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMaestroService" in both code and config file together.
    [ServiceContract]
    public interface IMaestroService
    {
        [OperationContract]
        List<Estado> ListarEstados();
        [OperationContract]
        List<TipoMaterial> ListarTipoMateriales();
        [OperationContract]
        List<Categoria> ListarCategorias();
    }
}
