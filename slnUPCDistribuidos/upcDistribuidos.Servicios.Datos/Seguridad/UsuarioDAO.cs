using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using System.Data;
using System.Data.SqlClient;

namespace upcDistribuidos.Servicios.Datos.Seguridad
{
    public class UsuarioDAO
    {

        public Usuario ObtenerUsuario(string cod)
        {
            String _sql = @"SELECT [codUsuario],[password],[perfil_id],[estado], [per_id]
                            FROM [tb_usuario]
                            WHERE codUsuario = @Codigo	";

            Usuario _mat = null;
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", cod);

            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                if (_reader.Read())
                {
                    _mat = new Usuario
                    {
                        codUsuario = _reader["codUsuario"].ToString(),
                        password = _reader["password"].ToString(),
                        perfil_id = _reader["perfil_id"].ToString(),
                        estado = Convert.ToBoolean(_reader["estado"].ToString()),
                        per_id = Convert.ToInt32(_reader["per_id"].ToString())
                    };

                }
            }
            _cnx.CerrarConexion();
            return _mat;
        }

        public Usuario RegistrarUsuario(Usuario usuario)
        {
            String _sql = @"INSERT INTO [dbo].[tb_usuario]
                            ([codUsuario]
                            ,[password]
                            ,[perfil_id]
                            ,[estado]
                            ,[per_id])
                         VALUES
                            (@codUsuario
                            ,@password
                            ,@perfil_id
                            ,@estado
                            ,@per_id)
                            select SCOPE_IDENTITY() as id 
                            ";

            Usuario _mat = null;
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@codUsuario", usuario.codUsuario);
            _cmd.Parameters.AddWithValue("@password", usuario.password);
            _cmd.Parameters.AddWithValue("@perfil_id", usuario.perfil_id);
            _cmd.Parameters.AddWithValue("@estado", usuario.estado);
            _cmd.Parameters.AddWithValue("@per_id", usuario.per_id);
            _cnx.AbrirConexion();

            int _id = Convert.ToInt32(_cmd.ExecuteScalar());

            if (_id > 0)
                _mat = ObtenerUsuario(usuario.codUsuario);

            _cnx.CerrarConexion();
            return _mat;
        }

        public List<UsuarioListar> ListarUsuarios(Usuario usuario)
        {
            String _sql = @"SELECT u.codUsuario CodUsuario, u.Password,
                                CASE WHEN   u.perfil_id = 'USU' THEN 'Usuario' ELSE 'Administrador'END Perfil,
                                p.nombres + ' ' + p.apellidos NombreCompleto
                            FROM[dbo].[tb_usuario] u WITH(NOLOCK) 
	                            INNER JOIN dbo.tb_persona p WITH(NOLOCK) ON u.per_id = p.per_id	
                            WHERE u.codUsuario LIKE '%'+@Codigo+ '%' AND p.nombres + ' ' + p.apellidos	LIKE '%'+@Nombre+'%'
                            ORDER BY u.codUsuario ASC";

            List<UsuarioListar> _lista = new List<UsuarioListar>();
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", usuario.codUsuario);
            _cmd.Parameters.AddWithValue("@Nombre", usuario.nombre);

            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _lista.Add(
                        new UsuarioListar
                        {
                            CodUsuario = _reader["CodUsuario"].ToString(),
                            Password = _reader["Password"].ToString(),
                            Perfil = _reader["Perfil"].ToString(),
                            NombreCompleto = _reader["NombreCompleto"].ToString()
                        }
                     );
                }
            }
            _cnx.CerrarConexion();
            return _lista;
        }
    }
}
