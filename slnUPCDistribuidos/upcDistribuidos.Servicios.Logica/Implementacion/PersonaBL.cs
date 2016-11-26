using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Servicios.Datos.Personas;
using upcDistribuidos.Servicios.Logica.Contrato;

namespace upcDistribuidos.Servicios.Logica.Implementacion
{
    public class PersonaBL : IPersonaBL
    {
        PersonaDAO _dao = null;

        public PersonaBL()
        {
            _dao = new PersonaDAO();
        }

        public List<Persona> ListarPersonas()
        {
            return _dao.ListarPersonas();
        }

        public Persona ObtenerPersona(string codigo)
        {
            return _dao.ObtenerPersona(codigo);
        }

        public Persona RegistrarPersona(Persona persona)
        {
            return _dao.RegistrarPersona(persona);
        }
        public Persona ActualizarPersona(Persona persona)
        {
            return _dao.ActualizarPersona(persona);
        }
    }
}
