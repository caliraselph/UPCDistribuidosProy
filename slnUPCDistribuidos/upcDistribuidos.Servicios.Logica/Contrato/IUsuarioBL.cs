using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Servicios.Datos.Materiales;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.Servicios.Logica.Contrato
{
    public interface IUsuarioBL
    {
        Usuario ObtenerUsuario(string codUsuario);
        Usuario RegistrarUsuario(Usuario usuario);
        List<UsuarioListar> ListarUsuarios(Usuario material);
    }
}
