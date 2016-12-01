using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using upcDistribuidos.Comun;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.ClienteLogica.Implementacion;
using System.Net;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfTPrestamo : Page
    {

        IMaestroBL _maestroBL= new MaestroBL();
        IMaterialBL _materialBL = new MaterialBL();
        IPrestamoBL _prestamoBL = new PrestamoBL();

        public string codVer = "";
        List<Material> _detalle = new List<Material>();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                codVer = string.IsNullOrEmpty(Request.QueryString["vew"]) ? "" : Request.QueryString["vew"];

                if (codVer != "")
                {
                    divBuscarMaterial.Visible = false;
                    
                }
                else {
                    GrillaMaterialDefault(dgvBusquedaMaterial);
                    GrillaMaterialDefault(dgvDetalleP);
                    CargarFechasNuevaReserva();

                }

                CargarCategoria();
                CargarTipoDeMateriales();

                txtCodigoR.Enabled = false;
                txtEstadoR.Text = "Prestado";
                txtEstadoR.Enabled = false;
                txtFechaDevolucionR.Enabled = false;
                txtFechaPrestamoR.Enabled = false;
                txtFechaRetornoR.Enabled = false;
                txtPersonaR.Enabled = false;


            }

        }

        private void CargarFechasNuevaReserva() {
            DateTime _actual = DateTime.Now;
            int year = _actual.Year;
            int mount = _actual.Month;
            int dia = _actual.Day;

            txtFechaPrestamoR.Text = DateTime.Parse(string.Concat(dia, "/", mount, "/", year, " 00:00")).ToShortDateString();
            txtFechaRetornoR.Text = DateTime.Parse(string.Concat(dia, "/", mount, "/", year, " 00:00")).AddDays(3).ToShortDateString();
        }

        protected void dgvBusquedaMaterial_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument.ToString());

            string _cod = dgvBusquedaMaterial.Rows[index].Cells[1].Text.ToString();

            if (_detalle.Count > 3)
            {
                Mensaje("Solo se puede agregar hasta 3 materiales");
                return;
            }
            

            foreach (Material item in _detalle)
            {
                if (item.Codigo.Equals(_cod))
                {
                    Mensaje("Producto ya esta ingresado");
                    return;
                }

            }

            _detalle.Add(_materialBL.ObtenerMaterial(_cod));
            CargarDetalle();

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
            int index = Convert.ToInt32(e.CommandArgument.ToString());

            string _cod = dgvBusquedaMaterial.Rows[index].Cells[1].Text.ToString();

            Material _m = _detalle.Where(c => c.Codigo.Equals(_cod)).SingleOrDefault();

            _detalle.Remove(_m);

            CargarDetalle();
            
        }

        protected void imgCancelarReserva_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.PrestamoBusq);
        }

        protected void imgGuardarReserva_Click(object sender, ImageClickEventArgs e)
        {
            DateTime? _datenull;
            if (_detalle.Count > 0)
            {
                Mensaje("No existe detalle");
                return;
            }
            if(_detalle.Count >3)
            {
                Mensaje("Solo se acepta 3 materiales");
                return;
            }
            
            try
            {
                Prestamo _pres = new Prestamo();
                _pres.Estado = 3;
                _pres.FechaEntrega = DateTime.Parse(txtFechaRetornoR.Text);
                _pres.FechaPrestamo = DateTime.Parse(txtFechaPrestamoR.Text);

                _prestamoBL.RegistrarPrestamo(_pres);

                Mensaje("Prestamo guardado correctamente");    
                Response.Redirect(Formularios.PrestamoBusq);
                
            }
            catch (WebException ex)
            {
                Mensaje(((HttpWebResponse)ex.Response).StatusDescription );
            }
        }

        private void CargarCategoria()
        {
            ddlCategoriaB.DataSource = _maestroBL.ListarCategorias(1);
            ddlCategoriaB.DataMember = "Id";
            ddlCategoriaB.DataValueField = "Id";
            ddlCategoriaB.DataTextField = "Descripcion";
            ddlCategoriaB.DataBind();
        }

        private void CargarTipoDeMateriales()
        {
            ddlTipoMaterialB.DataSource = _maestroBL.ListarTipoMateriales(1);
            ddlTipoMaterialB.DataMember = "Id";
            ddlTipoMaterialB.DataValueField = "Id";
            ddlTipoMaterialB.DataTextField = "Descripcion";
            ddlTipoMaterialB.DataBind();
        }

        private void Mensaje(string _msj)
        {
            Response.Write("<script>alert('" + _msj + "')</script>");
        }

        protected void imgBuscarMaterial_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                List<MaterialListar> _materiales = _materialBL.ListarMateriales(new Material
                {
                    Anio="",
                    Autor="",
                    Editorial="",
                    Flag= 1,
                    Titulo ="",
                    Codigo=""
                    
                });

                dgvBusquedaMaterial.DataSource = _materiales;
                dgvBusquedaMaterial.DataBind();


            }
            catch (WebException ex)
            {
                Mensaje(((HttpWebResponse)ex.Response).StatusDescription);
            }

        }

        private void CargarDetalle()
        {
            dgvDetalleP.DataSource = _detalle;
            dgvDetalleP.DataBind();
        }

    }
}