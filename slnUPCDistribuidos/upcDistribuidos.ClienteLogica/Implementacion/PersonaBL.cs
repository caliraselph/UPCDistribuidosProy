using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.ClienteProxy;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

using upcDistribuidos.ClienteProxy.Personas;

namespace upcDistribuidos.ClienteLogica.Implementacion
{
    public class PersonaBL : IPersonaBL
    {
        PersonaProxy proxy;

        public PersonaBL()
        {
            proxy = new PersonaProxy();
        }

        public Persona ActualizarPersona(Persona persona)
        {
            Persona personaActualizada;

            personaActualizada = proxy.ActualizarPersona(persona);

            return personaActualizada;
        }

        public List<Persona> ListarPersonas()
        {
            return proxy.ListarPersonas();
         }

        public Persona ObtenerPersona(string codigo)
        {
            Persona persona = new Persona();

            persona = proxy.ObtenerPersona(codigo);

            return persona;
        }

        public Persona RegistrarPersona(Persona persona)
        {
            Persona personaCreada;

            personaCreada = proxy.RegistrarPersona(persona);

            return personaCreada;
        }
    }
}
