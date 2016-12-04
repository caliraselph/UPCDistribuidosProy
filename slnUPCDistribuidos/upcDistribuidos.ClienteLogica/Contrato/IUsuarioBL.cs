using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.ClienteLogica.Contrato
{
    public interface IUsuarioBL
    {
        Usuario ObtenerUsuario(string codigoUsuario);
        Usuario RegistrarUsuario(Usuario usuario);
        List<UsuarioListar> ListarUsuarios(Usuario usuario);
    }
}
