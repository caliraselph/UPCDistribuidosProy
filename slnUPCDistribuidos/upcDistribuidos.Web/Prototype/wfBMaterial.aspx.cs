using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.ClienteLogica.Implementacion;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Comun;


namespace upcDistribuidos.Web.Prototype
{
    public partial class wfBMaterial : System.Web.UI.Page
    {
        IMaestroBL _logica = new MaestroBL();
        int _Todos = 2;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCategoria();
                DataTable dt = new DataTable();
                grdMaterial.DataSource = dt;
            }
        }

        protected void btnNewMat_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.MaterialTrans);
        }

        protected void btnSalir_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.Principal);
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

        private void CargarCategoria()
        {
            cboCategoria.DataSource = _logica.ListarCategorias(_Todos);
            cboCategoria.DataMember = "Id";
            cboCategoria.DataValueField = "Descripcion";
            cboCategoria.DataBind();
        }

    }
}