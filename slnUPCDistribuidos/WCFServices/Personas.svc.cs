using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;
using WCFServices.Persistencia;

namespace WCFServices
{
    public class Personas : IPersonas
    {
        private PersonaDAO personaDAO = new PersonaDAO();
        public Persona PersonaCrear(Persona personaCrear)
        {
            if (personaDAO.PersonaObtener(personaCrear.Codigo) != null)
            {
                throw new FaultException<RepetidoException>(
                new RepetidoException { Codigo = "101", Descripcion = "El registro ya existe." },
                new FaultReason("Error al intentar creacion."));
            }
            return personaDAO.PersonaCrear(personaCrear);
        }

        public void PersonaEliminar(string codigo)
        {
            personaDAO.PersonaEliminar(codigo);
        }

        public List<Persona> PersonaListar()
        {
            return personaDAO.PersonaListar();
        }

        public Persona PersonaModificar(Persona personaModificar)
        {
            return personaDAO.PersonaModificar(personaModificar);
        }

        public Persona PersonaObtener(string codigo)
        {
            return personaDAO.PersonaObtener(codigo);
        }
    }
}
