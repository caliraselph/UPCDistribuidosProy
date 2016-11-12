using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.ClienteLogica.Implementacion;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Comun;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfTMaterial : System.Web.UI.Page
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
                CargarTipoDeMateriales();
            }
        }

        protected void btnSalMat_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.MaterialBusq);
        }

        protected void btnNewMat_Click(object sender, ImageClickEventArgs e)
        {
            string cod = "";
            Material material = new Material();
            material.Codigo = txtCodigo.Text;
            material.Titulo = txtTitulo.Text;
            material.TipoId = int.Parse(cboTipo.SelectedValue);
            material.Stock = int.Parse(txtStock.Text);
            material.Editorial = txtEditorial.Text;
            material.Autor = txtAutor.Text;
            material.Anio = txtAno.Text;
            material.Flag = int.Parse(cboEstado.SelectedValue);
            material.Cantidad = int.Parse(cboCategoria.SelectedValue);

            _material.RegistrarMaterial(material);

            
            Response.Redirect(Formularios.MaterialBusq);
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

        private void CargarTipoDeMateriales()
        {
            cboTipo.DataSource = _logica.ListarTipoMateriales(_Todos);
            cboTipo.DataMember = "Id";
            cboTipo.DataValueField = "Id";
            cboTipo.DataTextField = "Descripcion";
            cboTipo.DataBind();
        }
    }
}