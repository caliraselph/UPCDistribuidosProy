﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Servicios.Datos.Materiales;
using System.Data;
using System.Data.SqlClient;

namespace upcDistribuidos.Servicios.Datos.Prestamos
{
    public class PrestamoDAO
    {

        DateTime? _dateNull = null;

        public List<PrestamoListar> BuscarPrestamo(string codigo,string estado,string persona, DateTime fechaPresIni,
                                                   DateTime fechaPresFin, DateTime fechaDevIni, DateTime fechaDevFin)
        {
            String _sql = @"
                    select 
	                    CONCAT('PR-', p.pres_id) Codigo,
	                    per.per_cod CodPersona,
	                    CONCAT(per.nombres,', ',per.apellidos) Persona,
	                    CONCAT(convert(char(10),p.fec_reserva,103), ' ', convert(char(5),p.fec_reserva,114))  FechaReserva,
	                    CONCAT(convert(char(10),p.fec_ini_pre,103), ' ', convert(char(5),p.fec_ini_pre,114))  FechaPrestamo,
	                    CONCAT(convert(char(10),p.fec_fin_pre,103), ' ', convert(char(5),p.fec_fin_pre,114))  FechaEntrega,
	                    CONCAT(convert(char(10),p.fec_devolucion,103), ' ', convert(char(5),p.fec_devolucion,114))  FechaDevolucion,
	                    e.sta_abrev CodEstado,
	                    e.sta_desc Estado
                    from 
	                    tb_prestamo p with(nolock)
	                    inner join tb_persona per with(nolock) on per.per_id = p.per_id
	                    inner join tb_estado e with(nolock) on p.estado=e.sta_id
                    where 
	                    CONCAT('PR-',p.pres_id) like case when isnull(@codigo,'') ='' then '%' else @codigo end and
	                    e.sta_abrev = case when @Estado = '-1' then e.sta_abrev else @estado end  and
	                    per.per_cod like case when isnull(@Persona,'') ='' then '%' else @Persona end and
	                    (p.fec_ini_pre between @FechaPresIni and @FechaPresFin) and 
	                    (p.fec_fin_pre between @FechaDevIni and @FechaDevFin)
                        order by p.pres_id desc  ";

            List<PrestamoListar> _lista = new List<PrestamoListar>();
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", codigo);
            _cmd.Parameters.AddWithValue("@Estado", estado);
            _cmd.Parameters.AddWithValue("@Persona", persona);
            _cmd.Parameters.AddWithValue("@FechaPresIni", fechaPresIni);
            _cmd.Parameters.AddWithValue("@FechaPresFin", fechaPresFin);
            _cmd.Parameters.AddWithValue("@FechaDevIni", fechaDevIni);
            _cmd.Parameters.AddWithValue("@FechaDevFin", fechaDevFin);

            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _lista.Add(
                        new PrestamoListar
                        {
                            Codigo = _reader["Codigo"].ToString(),
                            CodPersona = _reader["CodPersona"].ToString(),
                            CodEstado = _reader["CodEstado"].ToString(),
                            Estado = _reader["Estado"].ToString(),
                            FechaDevolucion = _reader["FechaDevolucion"].ToString(),
                            FechaEntrega = _reader["FechaEntrega"].ToString(),
                            FechaPrestamo = _reader["FechaPrestamo"].ToString(),
                            FechaReserva = _reader["FechaReserva"].ToString(),
                            Persona = _reader["Persona"].ToString()
                        }
                     );
                }
            }
            _cnx.CerrarConexion();
            return _lista;
        }

        public Prestamo ObtenerPrestamo(string cod)
        {
            String _sql = @"
                            SELECT 
                                CONCAT('PR-',c.pres_id) Codigo
                                ,c.[estado] Estado
                                ,c.[fec_reserva] FechaReserva
                                ,c.[fec_ini_pre] FechaPrestamo
                                ,c.[fec_fin_pre] FechaEntrega
                                ,c.[fec_devolucion] FechaDevolucion
                                ,c.[observacion] Observacion
                                ,c.[per_id] Persona
                                ,c.[adm_id] UsuarioCreacion
                            	,convert(varchar(256),(select concat(',',m.mat_cod )
                            		from [tb_prestamo_det] p
                            			inner join tb_material m on p.mat_id=m.mat_id
                            		where p.pres_id = c.pres_id
                            		for xml path(''))
                            	) Materiales
                            FROM [dbo].[tb_prestamo] c with(nolock) 
                            WHERE CONCAT('PR-',c.pres_id) = @Codigo";

            Prestamo _pres = null;
            string _mat = string.Empty;
            List<Material> _materiales = new List<Material>();
            MaterialDAO _matDao = new MaterialDAO();

            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", cod);

            _cnx.AbrirConexion();

            using (SqlDataReader _reader = _cmd.ExecuteReader())
            {
                if (_reader.Read())
                {
                    _pres = new Prestamo
                    {
                        Codigo = _reader["Codigo"].ToString(),
                        Estado = Convert.ToInt16(_reader["Estado"].ToString()),
                        FechaDevolucion = string.IsNullOrEmpty(_reader["FechaDevolucion"].ToString()) ? _dateNull: Convert.ToDateTime(_reader["FechaDevolucion"].ToString()),
                        FechaEntrega = _reader["FechaEntrega"] == null ? _dateNull : Convert.ToDateTime(_reader["FechaEntrega"].ToString()),
                        FechaPrestamo = _reader["FechaPrestamo"] == null ? _dateNull : Convert.ToDateTime(_reader["FechaPrestamo"].ToString()),
                        FechaReserva = string.IsNullOrEmpty(_reader["FechaReserva"].ToString()) ? _dateNull : Convert.ToDateTime(_reader["FechaReserva"].ToString()),
                        Observacion = _reader["Observacion"]== null ? string.Empty: _reader["Observacion"].ToString(),
                        PersonaId = Convert.ToInt32(_reader["Persona"].ToString()),
                        UsuarioCreacion= Convert.ToInt32(_reader["UsuarioCreacion"].ToString())
                    };

                    _pres.Persona = new Persona { Codigo = ObtenerPersonaCodigo(_pres.PersonaId.Value)};
                    _mat = _reader["Materiales"] == null ? string.Empty : _reader["Materiales"].ToString();
                    
                    foreach (string codmat in _mat.Split(','))
                    {
                        if (string.IsNullOrEmpty(codmat))
                            continue;
                        _materiales.Add(_matDao.ObtenerMaterial(codmat));
                    }

                    _pres.Materiales = _materiales;

                }
            }
            
            _cnx.CerrarConexion();
            return _pres;
        }
        
        public Prestamo RegistrarPrestamo(Prestamo prestamo)
        {
            String _sql = @"INSERT INTO [dbo].[tb_prestamo]
                                ([estado]
                                ,[fec_reserva]
                                ,[fec_ini_pre]
                                ,[fec_fin_pre]
                                ,[fec_devolucion]
                                ,[observacion]
                                ,[per_id]
                                ,[adm_id])
                            VALUES
                                (@Estado
                                ,@FechaReserva
                                ,@FechaPrestamo
                                ,@FechaEntrega
                                ,@FechaDevolucion
                                ,@Observacion
                                ,@Persona
                                ,@UsuarioCreacion)

                            select SCOPE_IDENTITY() as id 
                            ";

            Prestamo _pres = null;
            Conexion _cnx = new Conexion();

            int _IdPersona = ObtenerPersonaId(prestamo.Persona.Codigo);

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.CommandTimeout = 100000;
            _cmd.Parameters.AddWithValue("@Estado", prestamo.Estado);

            // _cmd.Parameters.Add(new SqlParameter { ParameterName = "@FechaReserva", SqlDbType = SqlDbType.DateTime, Value = prestamo.FechaReserva == null });

            if(prestamo.FechaReserva == null)
                _cmd.Parameters.AddWithValue("@FechaReserva", DBNull.Value);
            else
                _cmd.Parameters.AddWithValue("@FechaReserva", prestamo.FechaReserva);

            _cmd.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
            _cmd.Parameters.AddWithValue("@FechaEntrega", prestamo.FechaEntrega);

            if(prestamo.FechaDevolucion == null)
                _cmd.Parameters.AddWithValue("@FechaDevolucion", DBNull.Value);
            else
                _cmd.Parameters.AddWithValue("@FechaDevolucion", prestamo.FechaDevolucion);

            //_cmd.Parameters.Add(new SqlParameter { ParameterName = "@FechaDevolucion", SqlDbType = SqlDbType.DateTime, Value = prestamo.FechaDevolucion });

            if(prestamo.Observacion == null)
                _cmd.Parameters.AddWithValue("@Observacion", DBNull.Value);
            else
                _cmd.Parameters.AddWithValue("@Observacion", prestamo.Observacion);

            //_cmd.Parameters.Add(new SqlParameter { ParameterName= "@Observacion",SqlDbType = SqlDbType.VarChar,Value= prestamo.Observacion } );

            _cmd.Parameters.AddWithValue("@Persona", _IdPersona);
            _cmd.Parameters.AddWithValue("@UsuarioCreacion", prestamo.UsuarioCreacion);
            _cnx.AbrirConexion();

            int _id = Convert.ToInt32(_cmd.ExecuteScalar());

            if (_id > 0) {

                _sql = @"INSERT INTO [dbo].[tb_prestamo_det]
                       ([pres_id]
                        ,[mat_id]
                        ,[cant])
                    VALUES
                        (@PrestamoId
                        ,@MaterialId
                        ,@Cantidad)
                    ";
                foreach (Material item in prestamo.Materiales)
                {
                    int _MaterialId = ObtenerMaterialId(item.Codigo);

                    _cmd.CommandText = _sql;
                    _cmd.Parameters.Clear();
                    _cmd.Parameters.AddWithValue("@PrestamoId", _id);
                    _cmd.Parameters.AddWithValue("@MaterialId", _MaterialId);
                    _cmd.Parameters.AddWithValue("@Cantidad", 1);
                  
                    _cmd.ExecuteNonQuery();

                }
                _pres = ObtenerPrestamo("PR-" + _id.ToString());

            }

            _cnx.CerrarConexion();
            return _pres;
        }
        
        private int ObtenerMaterialId(string codigo)
        {
            String _sql = @" select mat_id
                            from [dbo].[tb_material] 
                            WHERE mat_cod =  @Codigo";
      
            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", codigo);

            _cnx.AbrirConexion();

            int _id = Convert.ToInt16(_cmd.ExecuteScalar());
            
            _cnx.CerrarConexion();
            return _id;
        }

        private int ObtenerPersonaId(string codigo)
        {
            String _sql = @"  select Per_id from [dbo].[tb_persona] where per_cod=   @Codigo";

            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Codigo", codigo);

            _cnx.AbrirConexion();

            int _id = Convert.ToInt16(_cmd.ExecuteScalar());

            _cnx.CerrarConexion();
            return _id;
        }

        private string ObtenerPersonaCodigo(int id)
        {
            String _sql = @"  select per_cod from [dbo].[tb_persona] where Per_id=   @Id";

            Conexion _cnx = new Conexion();

            SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
            _cmd.Parameters.AddWithValue("@Id", id);

            _cnx.AbrirConexion();

            string _codigo = Convert.ToString(_cmd.ExecuteScalar());

            _cnx.CerrarConexion();
            return _codigo;
        }

        public bool AnularPrestamo(string cod)
        {
            bool _estado = false;

            String _sql = @"  update [dbo].[tb_prestamo]
                                set estado = 2
                                where CONCAT('PR-',pres_id) =@Codigo";
            try
            {
                Conexion _cnx = new Conexion();

                SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
                _cmd.Parameters.AddWithValue("@Codigo", cod);

                _cnx.AbrirConexion();

                _cmd.ExecuteNonQuery();

                _cnx.CerrarConexion();
                _estado = true;
            }
            catch (Exception)
            {
                _estado = false;
            }

            return _estado;
        }

        public bool DevolverPrestamo(string cod)
        {
            bool _estado = false;

            String _sql = @"  update [dbo].[tb_prestamo]
                                set fec_devolucion = getdate() ,estado = 4 
                            where CONCAT('PR-',pres_id) = @Codigo";
            try
            {
                Conexion _cnx = new Conexion();

                SqlCommand _cmd = new SqlCommand(_sql, _cnx.ObtenerConexion());
                _cmd.Parameters.AddWithValue("@Codigo", cod);

                _cnx.AbrirConexion();

                _cmd.ExecuteNonQuery();

                _cnx.CerrarConexion();
                _estado = true;
            }
            catch (Exception)
            {
                _estado = false;
            }

            return _estado;
        }
    }
}
