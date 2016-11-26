using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.ClienteProxy.Personas
{
    public class PersonaProxy
    {
        PersonaService.PersonaServiceClient services;
        public PersonaProxy()
        {
            services = new PersonaService.PersonaServiceClient();
        }
        public Persona ObtenerPersona(string codigo)
        {
            return services.ObtenerPersona(codigo);
        }
        public Persona RegistrarPersona(Persona persona)
        {
            return services.RegistrarPersona(persona);
        }
        public Persona ActualizarPersona(Persona persona)
        {
            return services.ActualizarPersona(persona);
        }
        public List<Persona> ListarPersonas()
        {
            return services.ListarPersonas().ToList();
        }
    }
}
