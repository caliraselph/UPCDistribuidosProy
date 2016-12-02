using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace upcDistribuidos.Servicios.Datos
{
    public class Conexion
    {
        private SqlConnection cnxBD;

        public Conexion() {
            //cnxBD = new SqlConnection(ConfigurationManager.ConnectionStrings["cnxBD"].ToString());
            cnxBD = new SqlConnection(ConfigurationManager.ConnectionStrings["cnxBD1"].ToString());
        }

        public SqlConnection ObtenerConexion() {
            return cnxBD;
        }
        public void AbrirConexion()
        {
            if (cnxBD.State != ConnectionState.Open)
                cnxBD.Open();
        }

        public void CerrarConexion()
        {
            if (cnxBD.State != ConnectionState.Closed)
                cnxBD.Close();
        }

    }
}
