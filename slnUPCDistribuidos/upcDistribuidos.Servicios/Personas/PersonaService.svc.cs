using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Entidades.Errores;
using upcDistribuidos.Servicios.Logica.Contrato;
using upcDistribuidos.Servicios.Logica.Implementacion;

namespace upcDistribuidos.Servicios.Personas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PersonaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PersonaService.svc o PersonaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PersonaService : IPersonaService
    {
        IPersonaBL logica = new PersonaBL();
        public Persona ActualizarPersona(Persona persona)
        {
            if (persona != null)
            {
                if (!string.IsNullOrEmpty(persona.Codigo) || !string.IsNullOrEmpty(persona.Nombres) ||
                    !string.IsNullOrEmpty(persona.Apellidos) || !string.IsNullOrEmpty(persona.Direccion) ||
                     !string.IsNullOrEmpty(persona.Correo) || !string.IsNullOrEmpty(persona.Celular))
                {
                    if (logica.ObtenerPersona(persona.Codigo) == null)
                    {
                        throw new FaultException<RepetidoException>(
                            new RepetidoException { Codigo = "101", Mensaje = "Código mo Existe" },
                            new FaultReason("Error Registrar Persona")
                        );
                    }
                    else
                    {
                        return logica.ActualizarPersona(persona);
                    }
                }
                else
                {
                    throw new FaultException<ParametroException>(
                            new ParametroException { Codigo = "203", Mensaje = "Faltan datos de personas" },
                            new FaultReason("Error Registrar Persona")
                        );
                }
            }
            else
            {
                throw new FaultException<ParametroException>(
                      new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                      new FaultReason("Error Registrar Persona")
                );
            }
        }

        public List<Persona> ListarPersonas()
        {
            return logica.ListarPersonas();
        }

        public Persona ObtenerPersona(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                return logica.ObtenerPersona(codigo);
            }
            else
            {
                throw new FaultException<ParametroException>(
                      new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                      new FaultReason("Error Obtener Persona")
                );
            }
        }

        public Persona RegistrarPersona(Persona persona)
        {
            if (persona != null)
            {
                if (!string.IsNullOrEmpty(persona.Codigo) || !string.IsNullOrEmpty(persona.Nombres) ||
                    !string.IsNullOrEmpty(persona.Apellidos) || !string.IsNullOrEmpty(persona.Direccion) ||
                     !string.IsNullOrEmpty(persona.Correo) || !string.IsNullOrEmpty(persona.Celular))
                {
                    if (logica.ObtenerPersona(persona.Codigo) != null)
                    {
                        throw new FaultException<RepetidoException>(
                            new RepetidoException { Codigo = "101", Mensaje = "Código ya Existe" },
                            new FaultReason("Error Registrar Persona")
                        );
                    }
                    else
                    {
                        return logica.RegistrarPersona(persona);
                    }
                }
                else
                {
                    throw new FaultException<ParametroException>(
                            new ParametroException { Codigo = "203", Mensaje = "Faltan datos de personas" },
                            new FaultReason("Error Registrar Persona")
                        );
                }
            }
            else
            {
                throw new FaultException<ParametroException>(
                      new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                      new FaultReason("Error Registrar Persona")
                );
            }
        }
    }
}
