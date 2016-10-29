using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web.Views
{
    public partial class wfPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            GridView1.DataSource = dt;
        }

        protected void btnNew_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfTPersona.aspx");
        }

        protected void btnNew2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfPrincipal.aspx");
        }

        protected void btnNew1_Click(object sender, ImageClickEventArgs e)
        {
            DataTable dt = GridView1.DataSource as DataTable;
            dt.Columns.Add("Sel");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("NroLibros");
            dt.Columns.Add("Deuda");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Email");

            DataRow row = dt.NewRow();

            row["Sel"] = false;

            row["Codigo"] = "U201502510";

            row["Apellidos"] = "PEREZ LUNA";

            row["Nombres"] = "JUAN ANDRES";

            row["Tipo"] = "Alumno";

            row["NroLibros"] = "5";

            row["Deuda"] = "0.00";

            row["Telefono"] = "4748765";

            row["Email"] = "JUAN.PEREZ@GMAIL.COM";

            dt.Rows.Add(row);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}