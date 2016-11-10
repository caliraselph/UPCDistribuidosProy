using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;

namespace WCFServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPersonas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPersonas
    {
        [OperationContract]
        Persona PersonaCrear(Persona personaCrear);
        [OperationContract]
        Persona PersonaModificar(Persona personaModificar);
        [OperationContract]
        Persona PersonaObtener(string codigo);
        [OperationContract]
        void PersonaEliminar(string codigo);
        [OperationContract]
        List<Persona> PersonaListar();
    }
}
