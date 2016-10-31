using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfBPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            grdPersona.DataSource = dt;
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {

            DataTable dt = grdPersona.DataSource as DataTable;
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("NroLibros");
            dt.Columns.Add("Deuda");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Email");

            DataRow row = dt.NewRow();


            row["Codigo"] = "U2015";
            row["Apellidos"] = "CASTILLO ESTRADA";
            row["Nombres"] = "CARLOS EMILIO";
            row["Tipo"] = "ALUMNO";
            row["NroLibros"] = "1";
            row["Deuda"] = "0.00";
            row["Telefono"] = "45756345";
            row["Email"] = "ccastillo@hotmail.com";

            dt.Rows.Add(row);

            grdPersona.DataSource = dt;
            grdPersona.DataBind();
        }

        protected void btnSalir_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfPrincipal.aspx");
        }

        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfTPersona.aspx");
        }
    }
}