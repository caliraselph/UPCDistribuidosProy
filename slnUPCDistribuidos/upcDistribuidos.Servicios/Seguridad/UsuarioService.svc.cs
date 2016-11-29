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


namespace upcDistribuidos.Servicios.Seguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UsuarioService : IUsuarioService
    {
        IUsuarioBL _UsuarioBL = new UsuarioBL();

        public List<UsuarioListar> ListarUsuarios(Usuario usuario)
        {
            if (usuario != null)
            {
                if (!string.IsNullOrEmpty(usuario.codUsuario) || !string.IsNullOrEmpty(usuario.nombre))
                {
                    return _UsuarioBL.ListarUsuarios(usuario);
                }
                else
                {
                    throw new FaultException<ParametroException>(
                            new ParametroException { Codigo = "202", Mensaje = "Debe ingresar al menos un filtro" },
                            new FaultReason("Error Listar Usuario")
                        );

                }
            }
            else
            {
                throw new FaultException<ParametroException>(
                            new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                            new FaultReason("Error Listar Usuario")
                       );
            }
        }

        public Usuario ObtenerUsuario(string cod)
        {
            if (!string.IsNullOrEmpty(cod))
            {
                return _UsuarioBL.ObtenerUsuario(cod);
            }
            else
            {
                throw new FaultException<ParametroException>(
                      new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                      new FaultReason("Error Obtener Usuario")
                );
            }
        }

        public Usuario RegistrarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                if (!string.IsNullOrEmpty(usuario.codUsuario) || !string.IsNullOrEmpty(usuario.password) ||
                    usuario.per_id > 0)
                {
                    if (_UsuarioBL.ObtenerUsuario(usuario.codUsuario) != null)
                    {
                        return _UsuarioBL.RegistrarUsuario(usuario);
                    }
                    else
                    {
                        throw new FaultException<RepetidoException>(
                            new RepetidoException { Codigo = usuario.codUsuario, Mensaje = "Código ya Existe" },
                            new FaultReason("Error Registrar Usuario")
                        );
                    }
                }
                else
                {
                    throw new FaultException<ParametroException>(
                            new ParametroException { Codigo = "203", Mensaje = "Faltan datos del usuario" },
                            new FaultReason("Error Registrar Usuario")
                        );
                }
            }
            else
            {
                throw new FaultException<ParametroException>(
                      new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                      new FaultReason("Error Registrar Usuario")
                );
            }
        }
    }
}
