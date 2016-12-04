using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.ClienteProxy;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.ClienteProxy.Seguridad;

namespace upcDistribuidos.ClienteLogica.Implementacion
{
    public class UsuarioBL : IUsuarioBL
    {
        UsuarioProxy proxy;

        public UsuarioBL()
        {
            proxy = new UsuarioProxy();
        }

        public List<UsuarioListar> ListarUsuarios(Usuario usuario)
        {
            List<UsuarioListar> lista = new List<UsuarioListar>();

            lista = proxy.ListarUsuarios(usuario);

            return lista;
        }

        public Usuario ObtenerUsuario(string codigoUsuario)
        {
            Usuario usuarioObtenido = new Usuario();

            usuarioObtenido = proxy.ObtenerUsuario(codigoUsuario);

            return usuarioObtenido;
        }

        public Usuario RegistrarUsuario(Usuario usuario)
        {
            Usuario usuarioCreado;

            usuarioCreado = proxy.RegistrarUsuario(usuario);

            return usuarioCreado;
        }
    }
}
