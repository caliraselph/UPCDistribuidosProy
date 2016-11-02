using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfBMaterial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            grdMaterial.DataSource = dt;
        }

        protected void btnNewMat_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfTMaterial.aspx");
        }

        protected void btnSalir_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfPrincipal.aspx");
        }

        protected void btnBusMat_Click(object sender, ImageClickEventArgs e)
        {
            DataTable dt = grdMaterial.DataSource as DataTable;
            dt.Columns.Add("Sel");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Autor");

            DataRow row = dt.NewRow();

            row["Sel"] = false;

            row["Codigo"] = "DS001";

            row["Titulo"] = "Sistemas Distribuidos";

            row["Autor"] = "Pedro Molina";

            dt.Rows.Add(row);

            grdMaterial.DataSource = dt;
            grdMaterial.DataBind();
        }
    }
}