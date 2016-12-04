using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;


namespace upcDistribuidos.ClienteProxy.Seguridad
{
    public class UsuarioProxy
    {
        UsuarioService.UsuarioServiceClient services;

        public UsuarioProxy()
        {
            services = new UsuarioService.UsuarioServiceClient();
        }

        public Usuario ObtenerUsuario(string codUsuario)
        {
            return services.ObtenerUsuario(codUsuario);
        }
        public Usuario RegistrarUsuario(Usuario usuario)
        {
            return services.RegistrarUsuario(usuario);
        }
        public List<UsuarioListar> ListarUsuarios(Usuario usuario)
        {
            return services.ListarUsuarios(usuario).ToList();
        }
    }
}
