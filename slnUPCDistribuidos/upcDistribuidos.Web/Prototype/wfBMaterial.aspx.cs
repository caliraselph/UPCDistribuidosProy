using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.ClienteLogica.Implementacion;
using upcDistribuidos.Entidades;
using upcDistribuidos.Comun;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfBMaterial : System.Web.UI.Page
    {
        IMaestroBL _logica = new MaestroBL();
        IMaterialBL _material = new MaterialBL();
        int _Todos = 2;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCategoria();
                CargarEstados();
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
            if (txtCodigo.Text == "")
            {
                Response.Write("<script>alert('Por favor ingrese un código.')</script>");
                return;
            }

            Material materialABuscar = new Material();
            List<MaterialListar> lista = new List<MaterialListar>();

            materialABuscar.Codigo = txtCodigo.Text;
            materialABuscar.Titulo = txtTitulo.Text;
            materialABuscar.Cantidad = int.Parse(cboCategoria.SelectedValue);
            materialABuscar.Flag = int.Parse(cboEstado.SelectedValue);
            materialABuscar.Anio = txtAnio.Text;
            materialABuscar.Autor = txtAutor.Text;

            lista = _material.ListarMateriales(materialABuscar);

            DataTable dt = new DataTable();
            dt.Columns.Add("Sel");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Autor");

            foreach (MaterialListar mat in lista)
            {
                DataRow row = dt.NewRow();

                row["Sel"] = false;

                row["Codigo"] = mat.Codigo;

                row["Titulo"] = mat.Titulo;

                row["Autor"] = mat.Autor;

                dt.Rows.Add(row);
            }
            

            grdMaterial.DataSource = dt;
            grdMaterial.DataBind();
        }

        private void CargarCategoria()
        {
            cboCategoria.DataSource = _logica.ListarCategorias(_Todos);
            cboCategoria.DataMember = "Id";
            cboCategoria.DataValueField = "Id";
            cboCategoria.DataTextField = "Descripcion";
            cboCategoria.DataBind();
        }


        private void CargarEstados()
        {
            cboEstado.DataSource = _logica.ListarFlags(_Todos);
            cboEstado.DataMember = "Id";
            cboEstado.DataValueField = "Id";
            cboEstado.DataTextField = "Descripcion";
            cboEstado.DataBind();
        }
    }
}