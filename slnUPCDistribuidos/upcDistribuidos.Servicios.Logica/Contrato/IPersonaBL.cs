using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.Servicios.Logica.Contrato
{
    public interface IPersonaBL
    {
        Persona ObtenerPersona(string codigo);
        List<Persona> ListarPersonas();
        Persona RegistrarPersona(Persona persona);
        Persona ActualizarPersona(Persona persona);
    }
}
