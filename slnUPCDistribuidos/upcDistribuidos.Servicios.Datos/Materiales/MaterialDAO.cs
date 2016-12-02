using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using System.Data;
using System.Data.SqlClient;

namespace upcDistribuidos.Servicios.Datos.Materiales
{
    public class MaterialDAO
    {

        public Material ObtenerMaterial(string cod)
        {
            String _sql = @"SELECT [mat_cod],[titulo],[autor],[año],[editorial],[flag_sala],[stock],[cat_id],[tip_mat_id] 
                            FROM [tb_material]
                            WHERE mat_cod = @Codigo	";

            Material _mat = null;
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", cod);

            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                if(_reader.Read())
                {
                    _mat = new Material {
                        Codigo = _reader["mat_cod"].ToString(),
                        Anio = _reader["año"].ToString(),
                        Autor = _reader["autor"].ToString(),
                        Cantidad = Convert.ToInt32(_reader["cat_id"].ToString()),
                        Editorial = _reader["editorial"].ToString(),
                        Flag = Convert.ToInt32(string.IsNullOrEmpty(_reader["flag_sala"].ToString()) ? 0 : _reader["flag_sala"].ToString().Equals("True") ? 1 :0),
                        Stock = Convert.ToInt32(_reader["stock"].ToString()),
                        TipoId = Convert.ToInt32(_reader["tip_mat_id"].ToString()),
                        Titulo = _reader["titulo"].ToString()
                    };
                    
                }
            }
            _cnx.CerrarConexion();
            return _mat;
        }

        public Material RegistrarMaterial(Material material)
        {
            String _sql = @"INSERT INTO [dbo].[tb_material]
                            ([mat_cod]
                            ,[titulo]
                            ,[autor]
                            ,[año]
                            ,[editorial]
                            ,[flag_sala]
                            ,[stock]
                            ,[cat_id]
                            ,[tip_mat_id])
                         VALUES
                            (@mat_cod
                            ,@titulo
                            ,@autor
                            ,@anio
                            ,@editorial
                            ,@flag_sala
                            ,@stock
                            ,@cat_id
                            ,@tip_mat_id)
                            select SCOPE_IDENTITY() as id 
                            ";

            Material _mat = null;
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@mat_cod", material.Codigo);
            _cmd.Parameters.AddWithValue("@titulo", material.Titulo);
            _cmd.Parameters.AddWithValue("@autor", material.Autor);
            _cmd.Parameters.AddWithValue("@anio", material.Anio);
            _cmd.Parameters.AddWithValue("@editorial", material.Editorial);
            _cmd.Parameters.AddWithValue("@flag_sala", material.Flag);
            _cmd.Parameters.AddWithValue("@stock", material.Stock);
            _cmd.Parameters.AddWithValue("@cat_id", material.Cantidad);
            _cmd.Parameters.AddWithValue("@tip_mat_id", material.TipoId);
            _cnx.AbrirConexion();

            int _id = Convert.ToInt32(_cmd.ExecuteScalar());

            if (_id > 0)
                _mat = ObtenerMaterial(material.Codigo);
                        
            _cnx.CerrarConexion();
            return _mat;
        }

        public List<MaterialListar> ListarMateriales(Material material)
        {
            String _sql = @"SELECT m.mat_cod Codigo, m.Titulo ,m.Autor, m.Año Anio,m.Editorial,
                                CASE WHEN	m.flag_sala = 0 THEN 'BAJA' ELSE 'ALTA'END Flag,ttm.tip_mat_desc TipoMaterial
                                ,m.Stock 
                            FROM [dbo].[tb_material] m WITH(NOLOCK) 
	                            INNER JOIN dbo.tb_tipoMaterial ttm WITH	(NOLOCK) ON m.tip_mat_id = ttm	.tip_mat_id	
                            WHERE m.mat_cod LIKE '%'+@Codigo+ '%' 
                                AND	m.titulo LIKE '%'+@Titulo+'%' 
                                AND m.autor	LIKE '%'+@Autor+'%'
	                            AND	(@Anio = '' OR m.año = CAST(@Anio AS INT))
	                            AND (@Flag = -1 or m.flag_sala = @Flag)
                            ORDER BY m.mat_cod ASC	";

            List<MaterialListar> _lista = new List<MaterialListar>();
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", material.Codigo);
            _cmd.Parameters.AddWithValue("@Titulo", material.Titulo);
            _cmd.Parameters.AddWithValue("@Autor", material.Autor);
            _cmd.Parameters.AddWithValue("@Anio", material.Anio);
            _cmd.Parameters.AddWithValue("@Flag", material.Flag);

            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _lista.Add(
                        new MaterialListar
                        {
                            Codigo = _reader["Codigo"].ToString(),
                            Titulo = _reader["Titulo"].ToString(),
                            Autor = _reader["Autor"].ToString(),
                            Anio = _reader["Anio"].ToString(),
                            Editorial = _reader["Editorial"].ToString(),
                            Flag = _reader["Flag"].ToString(),
                            TipoMaterial = _reader["TipoMaterial"].ToString(),
                            stock = Convert.ToInt32(_reader["Stock"].ToString()),
                        }
                     );
                }
            }
            _cnx.CerrarConexion();
            return _lista;
        }

        public Material ModificarMaterial(Material material)
        {
            String _sql = @"UPDATE [dbo].[tb_material]
                            SET [titulo] = @titulo,
                                [autor] = @autor,
                                [año] = @anio,
                                [editorial] = @editorial,
                                [flag_sala] = @flag_sala,
                                [stock] = @stock,
                                [cat_id] = @cat_id,
                                [tip_mat_id] = @tip_mat_id
                            WHERE [mat_cod] = @mat_cod
                            ";

            Material _mat = null;
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@mat_cod", material.Codigo);
            _cmd.Parameters.AddWithValue("@titulo", material.Titulo);
            _cmd.Parameters.AddWithValue("@autor", material.Autor);
            _cmd.Parameters.AddWithValue("@anio", material.Anio);
            _cmd.Parameters.AddWithValue("@editorial", material.Editorial);
            _cmd.Parameters.AddWithValue("@flag_sala", material.Flag);
            _cmd.Parameters.AddWithValue("@stock", material.Stock);
            _cmd.Parameters.AddWithValue("@cat_id", material.Cantidad);
            _cmd.Parameters.AddWithValue("@tip_mat_id", material.TipoId);
            _cnx.AbrirConexion();
            _cmd.ExecuteNonQuery();
            _mat = ObtenerMaterial(material.Codigo);

            _cnx.CerrarConexion();
            return _mat;
        }

        public void EliminarMaterial(string codigo)
        {
            String _sql = @"UPDATE [dbo].[tb_material]
                            SET 
                                [flag_sala] = 0
                            WHERE [mat_cod] = @Codigo";

            Conexion _cnx = new Conexion();
            Material _mat = null;
            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", codigo);

            _cnx.AbrirConexion();

            _cmd.ExecuteNonQuery();
            _mat = ObtenerMaterial(codigo);
            _cnx.CerrarConexion();
        }

    }
}
