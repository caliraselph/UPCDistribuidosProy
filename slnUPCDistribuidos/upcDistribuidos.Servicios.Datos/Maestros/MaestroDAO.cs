using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using upcDistribuidos.Servicios.Datos;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.Servicios.Datos.Maestros
{
    public class MaestroDAO
    {
        public List<Estado> ListarEstados()
        {
            String _sql = @"SELECT sta_id,sta_abrev,sta_desc 
                            FROM [dbo].[tb_estado] WITH	(NOLOCK)
                            ORDER BY dbo.tb_estado.sta_desc ASC	";

            List<Estado> _lista = new List<Estado>();
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _lista.Add(
                        new Estado {
                            Id = Convert.ToInt32(_reader["sta_id"].ToString()),
                            Abreviatura = _reader["sta_abrev"].ToString(),
                            Descripcion = _reader["sta_desc"].ToString()
                        }
                     );
                }
            }
            _cnx.CerrarConexion();
            return _lista;
        }

        public List<TipoMaterial> ListarTipoMateriales()
        {
            String _sql = @"SELECT tip_mat_id,tip_mat_desc 
                            FROM [dbo].[tb_tipoMaterial] WITH(NOLOCK)
                            ORDER BY tip_mat_desc ASC";

            List<TipoMaterial> _lista = new List<TipoMaterial>();
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _lista.Add(
                        new TipoMaterial
                        {
                            Id = Convert.ToInt32(_reader["tip_mat_id"].ToString()),
                            Descripcion = _reader["tip_mat_desc"].ToString()
                        }
                     );
                }
            }
            _cnx.CerrarConexion();
            return _lista;
        }

        public List<Categoria> ListarCategorias()
        {
            String _sql = @"SELECT cat_id,cat_desc 
                            FROM tb_categoria WITH(NOLOCK)
                            ORDER BY cat_desc ASC";

            List<Categoria> _lista = new List<Categoria>();
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _lista.Add(
                        new Categoria
                        {
                            Id = Convert.ToInt32(_reader["cat_id"].ToString()),
                            Descripcion = _reader["cat_desc"].ToString()
                        }
                     );
                }
            }
            _cnx.CerrarConexion();
            return _lista;
        }


    }
}
