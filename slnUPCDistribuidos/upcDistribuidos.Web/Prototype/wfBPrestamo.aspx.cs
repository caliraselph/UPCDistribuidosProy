using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfBPrestamo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GrillaDefault();



            }
        }


        private void  GrillaDefault()
        {
            DataTable _dt = new DataTable("tb_test");
            DataRow _rw;

            DataColumn[] _colms =
                    { new DataColumn("Codigo", typeof(string)),
                    new DataColumn("CodPersona", typeof(string)),
                    new DataColumn("Persona", typeof(string)),
                    new DataColumn("FechaReserva", typeof(string)),
                    new DataColumn("FechaPrestamo", typeof(string)),
                    new DataColumn("FechaEntrega", typeof(string)),
                    new DataColumn("FechaDevolucion", typeof(string)),
                    new DataColumn("CodEstado", typeof(string)),
                    new DataColumn("Estado", typeof(string)) };

            _dt.Columns.AddRange(_colms);
            dgvPrestamo.DataSource = _dt;
            dgvPrestamo.DataBind();
          
        }

        protected void imgFechaPresIni_Click(object sender, ImageClickEventArgs e)
        {
            calFecPresIni.Visible = !calFecPresIni.Visible;
        }

        protected void imgFechaPresFin_Click(object sender, ImageClickEventArgs e)
        {
            calFecPresFin.Visible = !calFecPresFin.Visible;
        }

        protected void calFecPresIni_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaPresIni.Text = calFecPresIni.SelectedDate.ToShortDateString();
            calFecPresIni.Visible = false;
        }

        protected void calFecPresFin_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaPresFin.Text = calFecPresFin.SelectedDate.ToShortDateString();
            calFecPresFin.Visible = false;
        }

        protected void imgFechaIniDev_Click(object sender, ImageClickEventArgs e)
        {
            calFechaIniDev.Visible = !calFechaIniDev.Visible;
        }

        protected void imgFechaFinDev_Click(object sender, ImageClickEventArgs e)
        {
            calFechaFinDev.Visible = !calFechaFinDev.Visible;
        }

        protected void calFechaIniDev_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaIniDev.Text = calFechaIniDev.SelectedDate.ToShortDateString();
            calFechaIniDev.Visible = false;
        }

        protected void calFechaFinDev_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaFinDev.Text = calFechaFinDev.SelectedDate.ToShortDateString();
            calFechaFinDev.Visible = false;
        }

        protected void dgvPrestamo_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}