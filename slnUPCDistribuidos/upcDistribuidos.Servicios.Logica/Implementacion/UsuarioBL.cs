using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Servicios.Datos.Seguridad;
using upcDistribuidos.Servicios.Logica.Contrato;

namespace upcDistribuidos.Servicios.Logica.Implementacion
{
    public class UsuarioBL : IUsuarioBL
    {
        UsuarioDAO _dao = null;

        public UsuarioBL()
        {
            _dao = new UsuarioDAO();
        }


        public List<UsuarioListar> ListarUsuarios(Usuario material)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerUsuario(string codUsuario)
        {
            throw new NotImplementedException();
        }

        public Usuario RegistrarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
