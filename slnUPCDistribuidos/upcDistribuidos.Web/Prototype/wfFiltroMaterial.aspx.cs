using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfFiltroMaterial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable _dt = new DataTable();
            DataRow _row;
            DataColumn _column = new DataColumn("TipoMaterial", typeof(string));
            DataColumn _column1 = new DataColumn("Codigo", typeof(string));
            DataColumn _column2 = new DataColumn("Autor", typeof(string));
            DataColumn _column3 = new DataColumn("Titulo", typeof(string));
            DataColumn _column4 = new DataColumn("Anio", typeof(string));

            _dt.Columns.Add(_column);
            _dt.Columns.Add(_column1);
            _dt.Columns.Add(_column2);
            _dt.Columns.Add(_column3);
            _dt.Columns.Add(_column4);

            _row = _dt.NewRow();
            _row["TipoMaterial"] = "Revista";
            _row["Codigo"] = "R01";
            _row["Autor"] = "Jose Luis";
            _row["Titulo"] = "Revista 01";
            _row["Anio"] = "2015";

            _dt.Rows.Add(_row);

            GridView1.DataSource = _dt;
            GridView1.DataBind();
        }
    }
}