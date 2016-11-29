using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.Servicios.Materiales
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMaterialRESTService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMaterialRESTService
    {
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Material/{cod}", ResponseFormat = WebMessageFormat.Json)]
        void EliminaMaterial(string cod);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Material", ResponseFormat = WebMessageFormat.Json)]
        Material ModificarMaterial(Material material);
    }
}
