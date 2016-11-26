using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.Servicios.Personas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPersonaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPersonaService
    {
        [OperationContract]
        List<Persona> ListarPersonas();
        [OperationContract]
        Persona ObtenerPersona(string codigo);
        [OperationContract]
        Persona RegistrarPersona(Persona persona);
        [OperationContract]
        Persona ActualizarPersona(Persona persona);
        
    }
}
