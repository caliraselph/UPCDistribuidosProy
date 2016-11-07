using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfBUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            GridView1.DataSource = dt;
        }

        protected void btnNew_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfTUsuario.aspx");
        }

        protected void btnNew2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfPrincipal.aspx");
        }

        protected void btnNew1_Click(object sender, ImageClickEventArgs e)
        {
            DataTable dt = GridView1.DataSource as DataTable;
            dt.Columns.Add("Sel");
            dt.Columns.Add("Perfil");
            dt.Columns.Add("Usuario");
          

            DataRow row = dt.NewRow();

            row["Sel"] = false;

            row["Perfil"] = "ADMINISTRADOR";

            row["Usuario"] = "ADMIN";

         

            dt.Rows.Add(row);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnNew0_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>alert('El registro se elimino correctamente.')</script>");
        }
    }
}