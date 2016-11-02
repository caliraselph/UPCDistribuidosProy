using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfBReserva : System.Web.UI.Page
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
            dgvReserva.DataSource = _dt;
            dgvReserva.DataBind();
          
        }

        protected void imgFechaResIni_Click(object sender, ImageClickEventArgs e) 
        {
            calFecResIni.Visible = !calFecResIni.Visible;

        }

        protected void imgFechaResFin_Click(object sender, ImageClickEventArgs e)
        {
            calFecResFin.Visible = !calFecResFin.Visible;
        }

        protected void calFecResIni_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaResIni.Text = calFecResIni.SelectedDate.ToShortDateString();
            calFecResIni.Visible = false;
        }

        protected void calFecResFin_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaResFin.Text = calFecResFin.SelectedDate.ToShortDateString();
            calFecResFin.Visible = false;
        }

        protected void dgvReserva_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var r = 1;
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
    }
}