using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.ClienteLogica.Implementacion;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Comun;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfBUsuario : System.Web.UI.Page
    {
        //IUsuarioBL _UsuarioBL = new UsuarioBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            grdUsuario.DataSource = dt;
        }

        protected void btnNewUsu_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfTUsuario.aspx");
        }

        protected void btnSalir_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfPrincipal.aspx");
        }

        protected void btnBusUsu_Click(object sender, ImageClickEventArgs e)
        {
            DataTable dt = grdUsuario.DataSource as DataTable;
            dt.Columns.Add("CodUsuario");
            dt.Columns.Add("Password");
            dt.Columns.Add("Perfil");
            dt.Columns.Add("NombreCompleto");

            DataRow row = dt.NewRow();

            row["CodUsuario"] = "U201502510";

            row["Password"] = "&!*=%1";

            row["Perfil"] = "Usuario";

            row["NombreCompleto"] = "Sandra Arizaca";

            dt.Rows.Add(row);

            grdUsuario.DataSource = dt;
            grdUsuario.DataBind();
        }
    }
}