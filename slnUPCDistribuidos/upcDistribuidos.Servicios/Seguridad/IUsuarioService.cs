using System.Collections.Generic;
using System.ServiceModel;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Entidades.Errores;

namespace upcDistribuidos.Servicios.Seguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarioService    {

        [FaultContract(typeof(ParametroException))]
        [OperationContract]
        Usuario ObtenerUsuario(string cod);

        [FaultContract(typeof(ParametroException))]
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Usuario RegistrarUsuario(Usuario usuario);

        [FaultContract(typeof(ParametroException))]
        [OperationContract]
        List<UsuarioListar> ListarUsuarios(Usuario usuario);
    }
}
