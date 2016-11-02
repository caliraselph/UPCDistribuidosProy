using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfTReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GrillaMaterialDefault(dgvBusquedaMaterial);
            GrillaMaterialDefault(dgvDetalleR);
        }

        protected void dgvBusquedaMaterial_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var a = 2;
        }

        private void GrillaMaterialDefault(GridView _dgv)
        {
            DataTable _dt = new DataTable("tb_test");
            DataRow _rw;

            DataColumn[] _colms =
                    { new DataColumn("Codigo", typeof(string)),
                    new DataColumn("Titulo", typeof(string)),
                    new DataColumn("CodTipMaterial", typeof(string)),
                    new DataColumn("TipoMaterial", typeof(string)),
                    new DataColumn("CodCategoria", typeof(string)),
                    new DataColumn("Categoria", typeof(string)),
                    new DataColumn("Anio", typeof(string)) };

            _dt.Columns.AddRange(_colms);
            _dgv.DataSource = _dt;
            _dgv.DataBind();

        }

        protected void dgvDetalleR_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}