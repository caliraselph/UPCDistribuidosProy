using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;

namespace WCFServices.Persistencia
{

    public class PersonaDAO
    {

        //private string cadenaConexion = "Data Source=(local);Initial Catalog=BD_Asesores;Integrated Security=SSPI;";
        private string cadenaConexion = @"data source=localhost\sql2008r2;initial catalog=Bd_Portal;persist security info=True;user id=db2admin;password=db2admin";
        public Persona PersonaCrear(Persona personaCrear)
        {

            Persona personaCreado = null;
            string sql = "INSERT INTO tb_persona VALUES (@cod, @nom,@apell,@corr,@dir,@cel,@nro,@deu)";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", personaCrear.Codigo));
                    com.Parameters.Add(new SqlParameter("@nom", personaCrear.Nombres));
                    com.Parameters.Add(new SqlParameter("@apell", personaCrear.Apellidos));
                    com.Parameters.Add(new SqlParameter("@corr", personaCrear.Correo));
                    com.Parameters.Add(new SqlParameter("@dir", personaCrear.Direccion));
                    com.Parameters.Add(new SqlParameter("@cel", personaCrear.Celular));
                    com.Parameters.Add(new SqlParameter("@nro", personaCrear.NroLibros));
                    com.Parameters.Add(new SqlParameter("@deu", personaCrear.Deuda));
                    com.ExecuteNonQuery();
                }
            }
            personaCreado = PersonaObtener(personaCrear.Codigo);
            return personaCreado;

        }

        public Persona PersonaObtener(string codigo)
        {
            Persona personaEncontrada = null;
            string sql = "SELECT * FROM tb_persona WHERE per_cod=@cod";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            personaEncontrada = new Persona()
                            {
                                Id = (int)resultado["per_id"],
                                Codigo = (string)resultado["per_cod"],
                                Nombres = (string)resultado["nombres"],
                                Apellidos = (string)resultado["apellidos"],
                                Correo = (string)resultado["email"],
                                Direccion = (string)resultado["direccion"],
                                Celular = (string)resultado["celular"],
                                NroLibros = (byte)resultado["nro_libros"],
                                Deuda = (Decimal)resultado["monto_deuda"],
                            };
                        }
                    }
                }
            }
            return personaEncontrada;
        }

        public Persona PersonaModificar(Persona personaModificar)
        {
            Persona personaModificado = null;
            string sql = "UPDATE tb_persona set nombres=@nom, apellidos=@apell, email=@corr,direccion=@dir,celular=@cel,nro_libros=@nro,monto_deuda=@deu where per_cod=@cod";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", personaModificar.Codigo));
                    com.Parameters.Add(new SqlParameter("@nom", personaModificar.Nombres));
                    com.Parameters.Add(new SqlParameter("@apell", personaModificar.Apellidos));
                    com.Parameters.Add(new SqlParameter("@corr", personaModificar.Correo));
                    com.Parameters.Add(new SqlParameter("@dir", personaModificar.Direccion));
                    com.Parameters.Add(new SqlParameter("@cel", personaModificar.Celular));
                    com.Parameters.Add(new SqlParameter("@nro", personaModificar.NroLibros));
                    com.Parameters.Add(new SqlParameter("@deu", personaModificar.Deuda));
                    com.ExecuteNonQuery();
                }
            }
            personaModificado = PersonaObtener(personaModificar.Codigo);
            return personaModificado;

        }

        public void PersonaEliminar(string codigo)
        {
            string sql = "DELETE tb_persona where per_cod=@cod";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    com.ExecuteNonQuery();
                }
            }
        }

        public List<Persona> PersonaListar()
        {
            List<Persona> personas = new List<Persona>();
            string sql = "SELECT * from tb_persona";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            personas.Add(new Persona
                            {
                                Codigo = (string)resultado["per_cod"],
                                Nombres = (string)resultado["nombres"],
                                Apellidos = (string)resultado["apellidos"],
                                Correo = (string)resultado["email"],
                                Direccion = (string)resultado["direccion"],
                                Celular = (string)resultado["celular"],
                                NroLibros = (byte)resultado["nro_libros"],
                                Deuda = (Decimal)resultado["monto_deuda"]
                            });

                        }
                    }
                }
            }

            return personas;

        }
    }
}