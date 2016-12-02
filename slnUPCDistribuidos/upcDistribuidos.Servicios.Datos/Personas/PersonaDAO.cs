using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.Servicios.Datos.Personas
{
    public class PersonaDAO
    {
        public Persona ObtenerPersona(string cod)
        {
            String _sql = @"SELECT *
                            FROM [tb_persona]
                            WHERE per_cod = @Codigo	";

            Persona _per = null;
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", cod);

            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                if (_reader.Read())
                {
                    _per = new Persona
                    {
                        Codigo = _reader["per_cod"].ToString(),
                        Nombres = _reader["nombres"].ToString(),
                        Apellidos = _reader["apellidos"].ToString(),
                        Correo = _reader["email"].ToString(),
                        Direccion = _reader["direccion"].ToString(),
                        Celular = _reader["celular"].ToString(),
                        NroLibros = Convert.ToByte(string.IsNullOrEmpty(_reader["nro_libros"].ToString()) ? "0" : _reader["nro_libros"].ToString()),
                        MontoDeuda = Convert.ToDecimal(string.IsNullOrEmpty(_reader["monto_deuda"].ToString()) ? "0.0" : _reader["monto_deuda"].ToString())

                    };

                }
            }
            _cnx.CerrarConexion();
            return _per;
        }

        public Persona RegistrarPersona(Persona persona)
        {
            String _sql = @"INSERT INTO [dbo].[tb_persona]
                            ([per_cod]
                            ,[nombres]
                            ,[apellidos]
                            ,[email]
                            ,[direccion]
                            ,[celular]
                            ,[nro_libros]
                            ,[monto_deuda])
                         VALUES
                            (@per_cod
                            ,@nombres
                            ,@apellidos
                            ,@email
                            ,@direccion
                            ,@celular
                            ,@nro_libros
                            ,@monto_deuda)
                            select SCOPE_IDENTITY() as id 
                            ";

            Persona _per = null;
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@per_cod", persona.Codigo);
            _cmd.Parameters.AddWithValue("@nombres", persona.Nombres);
            _cmd.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            _cmd.Parameters.AddWithValue("@email", persona.Correo);
            _cmd.Parameters.AddWithValue("@direccion", persona.Direccion);
            _cmd.Parameters.AddWithValue("@celular", persona.Celular);
            _cmd.Parameters.AddWithValue("@nro_libros", persona.NroLibros);
            _cmd.Parameters.AddWithValue("@monto_deuda", persona.MontoDeuda);
            _cnx.AbrirConexion();

            int _id = Convert.ToInt32(_cmd.ExecuteScalar());

            if (_id > 0)
                _per = ObtenerPersona(persona.Codigo);

            _cnx.CerrarConexion();
            return _per;
        }

        public Persona ActualizarPersona(Persona persona)
        {
            String _sql = @"UPDATE [dbo].[tb_persona] SET
                            nombres = @nombres,
                            apellidos = @apellidos,
                            email = @email,
                            direccion = @direccion,
                            celular = @celular,
                            nro_libros = @nro_libros,
                            monto_deuda = @monto_deuda
                            where per_cod = @per_cod)
                            ";

            Persona _per = null;
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@per_cod", persona.Codigo);
            _cmd.Parameters.AddWithValue("@nombres", persona.Nombres);
            _cmd.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            _cmd.Parameters.AddWithValue("@email", persona.Correo);
            _cmd.Parameters.AddWithValue("@direccion", persona.Direccion);
            _cmd.Parameters.AddWithValue("@celular", persona.Celular);
            _cmd.Parameters.AddWithValue("@nro_libros", persona.NroLibros);
            _cmd.Parameters.AddWithValue("@monto_deuda", persona.MontoDeuda);
            _cnx.AbrirConexion();

            int _id = Convert.ToInt32(_cmd.ExecuteScalar());

            if (_id > 0)
                _per = ObtenerPersona(persona.Codigo);

            _cnx.CerrarConexion();
            return _per;
        }

        public List<Persona> ListarPersonas()
        {
            String _sql = @"SELECT *
                            FROM [dbo].[tb_persona] WITH(NOLOCK) 
                            ORDER BY apellidos,nombres	";

            List<Persona> _lista = new List<Persona>();
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
          
            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _lista.Add(
                        new Persona
                        {
                            Codigo = _reader["per_cod"].ToString(),
                            Nombres = _reader["nombres"].ToString(),
                            Apellidos = _reader["apellidos"].ToString(),
                            Correo = _reader["email"].ToString(),
                            Direccion = _reader["direccion"].ToString(),
                            Celular = _reader["celular"].ToString(),
                            NroLibros = Convert.ToByte(string.IsNullOrEmpty(_reader["nro_libros"].ToString()) ? "0" : _reader["nro_libros"].ToString()),
                            MontoDeuda = Convert.ToDecimal(string.IsNullOrEmpty(_reader["monto_deuda"].ToString()) ? "0.0" : _reader["monto_deuda"].ToString())
                        }
                     );
                }
            }
            _cnx.CerrarConexion();
            return _lista;
        }

    }
}
