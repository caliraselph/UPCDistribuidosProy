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
using System.Net;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfTMaterial : System.Web.UI.Page
    {
        IMaestroBL _logica = new MaestroBL();
        IMaterialBL _material = new MaterialBL();
        int _Todos = 1;

        public string codEdic = "";
        public string codVer = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                codEdic = string.IsNullOrEmpty(Request.QueryString["edt"]) ? "" : Request.QueryString["edt"];
                codVer = string.IsNullOrEmpty(Request.QueryString["vew"]) ? "" : Request.QueryString["vew"];
                txtCodigo.Enabled = true;

                CargarCategoria();
                CargarEstados();
                CargarTipoDeMateriales();

                if (codEdic != "")
                {
                    ObtenerMaterial(codEdic);
                }

                if (codVer != "")
                {
                    VerMaterial(codVer);
                }
            }
        }

        private void ObtenerMaterial(string cod)
        {
            Material materialObtenido = new Material();
            materialObtenido = _material.ObtenerMaterial(cod);

            txtCodigo.Text = materialObtenido.Codigo;
            txtTitulo.Text = materialObtenido.Titulo;
            cboTipo.SelectedValue = materialObtenido.TipoId.ToString();
            txtStock.Text = materialObtenido.Stock.ToString();
            txtEditorial.Text = materialObtenido.Editorial;
            txtAutor.Text = materialObtenido.Autor;
            txtAno.Text = materialObtenido.Anio;
            cboEstado.SelectedValue = materialObtenido.Flag.ToString();
            //cboEstado.SelectedIndex = 1;
            cboCategoria.SelectedValue = materialObtenido.Cantidad.ToString();

            txtCodigo.Enabled = false;
        }

        private void VerMaterial(string cod)
        {
            Material materialObtenido = new Material();
            materialObtenido = _material.ObtenerMaterial(cod);

            txtCodigo.Text = materialObtenido.Codigo;
            txtTitulo.Text = materialObtenido.Titulo;
            cboTipo.SelectedValue = materialObtenido.TipoId.ToString();
            txtStock.Text = materialObtenido.Stock.ToString();
            txtEditorial.Text = materialObtenido.Editorial;
            txtAutor.Text = materialObtenido.Autor;
            txtAno.Text = materialObtenido.Anio;
            cboEstado.SelectedValue = materialObtenido.Flag.ToString();
            //cboEstado.SelectedIndex = 1;
            cboCategoria.SelectedValue = materialObtenido.Cantidad.ToString();

            txtCodigo.Enabled = false;
            txtTitulo.Enabled = false;
            cboTipo.Enabled = false;
            txtStock.Enabled = false;
            txtEditorial.Enabled = false;
            txtAutor.Enabled = false;
            txtAno.Enabled = false;
            cboEstado.Enabled = false;
            cboCategoria.Enabled = false;
            btnNewMat.Visible = false;
        }

        protected void btnSalMat_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.MaterialBusq);
        }

        protected void btnNewMat_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "" || txtTitulo.Text == "" || txtStock.Text == ""
                    || txtAno.Text == "" || txtAutor.Text == "" || txtEditorial.Text == ""
                    || int.Parse(cboTipo.SelectedValue) < 0 || int.Parse(cboCategoria.SelectedValue) < 0
                    || int.Parse(cboEstado.SelectedValue) < 0)
                {
                    Response.Write("<script>alert('Por favor ingrese los datos faltantes.')</script>");
                    return;
                }

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

                if (txtCodigo.Enabled)
                {
                    _material.RegistrarMaterial(material);
                    Response.Write("<script>alert('El material se registró correctamente.')</script>");
                    Response.Write("<script>window.location.href='" + Formularios.MaterialBusq + "'</script>");
                }
                else
                {
                    _material.ModificarMaterial(material);
                    Response.Write("<script>alert('El material se modificó correctamente.')</script>");
                    Response.Write("<script>window.location.href='" + Formularios.MaterialBusq + "'</script>");
                }

                //Response.Redirect(Formularios.MaterialBusq);
            }
            catch (WebException ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
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