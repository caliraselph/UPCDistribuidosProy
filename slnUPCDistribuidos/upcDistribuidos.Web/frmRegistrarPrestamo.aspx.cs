using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web
{
    public partial class frmRegistrarPrestamo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable _dt = new DataTable();
            DataRow _row;
            DataColumn _column = new DataColumn("Material", typeof(string));
            DataColumn _column1 = new DataColumn("Codigo", typeof(string));
            DataColumn _column2 = new DataColumn("Titulo", typeof(string));
            DataColumn _column3 = new DataColumn("Autor", typeof(string));

            _dt.Columns.Add(_column);
            _dt.Columns.Add(_column1);
            _dt.Columns.Add(_column2);
            _dt.Columns.Add(_column3);

            _row = _dt.NewRow();
            _row["Material"] = "Revista";
            _row["Codigo"] = "R01";
            _row["Titulo"] = "Revista 01";
            _row["Autor"] = "Jose Luis";

            _dt.Rows.Add(_row);

            GridView1.DataSource = _dt;
            GridView1.DataBind();

        }
    }
}