using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web
{
    public partial class frmBuscarPrestamo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable _dt = new DataTable();
            DataRow _row;
            DataColumn _column = new DataColumn("Codigo", typeof(string));
            DataColumn _column1 = new DataColumn("FechaSalida", typeof(string));
            DataColumn _column2 = new DataColumn("FechaIngreso", typeof(string));
            DataColumn _column3 = new DataColumn("TipoPersona", typeof(string));
            DataColumn _column4 = new DataColumn("Persona", typeof(string));

            _dt.Columns.Add(_column);
            _dt.Columns.Add(_column1);
            _dt.Columns.Add(_column2);
            _dt.Columns.Add(_column3);
            _dt.Columns.Add(_column4);

            _row = _dt.NewRow();
            _row["Codigo"] = "PR01";
            _row["FechaSalida"] = "01/10/2015";
            _row["FechaIngreso"] = "15/10/2015";
            _row["TipoPersona"] = "Profesor";
            _row["Persona"] = "Jose Luis";

            _dt.Rows.Add(_row);

            GridView1.DataSource = _dt;
            GridView1.DataBind();


        }

        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/frmRegistrarPrestamo.aspx");

        }
    }
}