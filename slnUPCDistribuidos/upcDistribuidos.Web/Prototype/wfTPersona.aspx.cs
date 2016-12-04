using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.ClienteLogica.Implementacion;
using upcDistribuidos.Comun;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfTPersona : System.Web.UI.Page
    {
        IPersonaBL _persona = new PersonaBL();

        public string codEdic = "";
        public string codVer = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                codEdic = string.IsNullOrEmpty(Request.QueryString["edt"]) ? "" : Request.QueryString["edt"];
                codVer = string.IsNullOrEmpty(Request.QueryString["vew"]) ? "" : Request.QueryString["vew"];
                txtCodigo.Enabled = true;

              

                if (codEdic != "")
                {
                    ObtenerPersona(codEdic);
                }

                if (codVer != "")
                {
                    VerPersona(codVer);
                }
            }
        }

        protected void btnNew2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfBPersona.aspx");
        }

        protected void btnGrabar_Click(object sender, ImageClickEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text) && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellido.Text) && !String.IsNullOrEmpty(txtCorreo.Text) && !String.IsNullOrEmpty(txtTelefono.Text) && !String.IsNullOrEmpty(txtDireccion.Text))
            {
                Persona persona = new Persona();

                persona.Codigo = txtCodigo.Text;
                persona.Nombres = txtNombre.Text;
                persona.Apellidos = txtApellido.Text;
                persona.Correo = txtCorreo.Text;
                persona.Celular = txtTelefono.Text;
                persona.Direccion = txtDireccion.Text;
                persona.NroLibros = Convert.ToInt32(txtNroLibro.Text);
                persona.MontoDeuda = Convert.ToDecimal(txtDeuda.Text);

                if (txtCodigo.Enabled)
                {
                    _persona.RegistrarPersona(persona);
                    Response.Write("<script>alert('La persona se registró correctamente.')</script>");
                    Response.Write("<script>window.location.href='" + Formularios.PersonaBusq + "'</script>");
                }
                else
                {
                    _persona.ActualizarPersona(persona);
                    Response.Write("<script>alert('El material se modificó correctamente.')</script>");
                    Response.Write("<script>window.location.href='" + Formularios.PersonaBusq + "'</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('No se puede registrar la persona, todos los campos son obligatorios.')</script>");
            }
        }

        private void ObtenerPersona(string cod)
        {
            Persona personaObtenida = new Persona();
            personaObtenida = _persona.ObtenerPersona(cod);

            txtCodigo.Text = personaObtenida.Codigo;
            txtNombre.Text = personaObtenida.Nombres;
            txtApellido.Text = personaObtenida.Apellidos;
            txtCorreo.Text = personaObtenida.Correo;
            txtTelefono.Text = personaObtenida.Celular;
            txtDireccion.Text = personaObtenida.Direccion;
            txtNroLibro.Text = personaObtenida.NroLibros.ToString();
            txtDeuda.Text = personaObtenida.MontoDeuda.ToString();

            txtCodigo.Enabled = false;
        }

        private void VerPersona(string cod)
        {
            Persona personaObtenida = new Persona();
            personaObtenida = _persona.ObtenerPersona(cod);

            txtCodigo.Text = personaObtenida.Codigo;
            txtNombre.Text = personaObtenida.Nombres;
            txtApellido.Text = personaObtenida.Apellidos;
            txtCorreo.Text = personaObtenida.Correo;
            txtTelefono.Text = personaObtenida.Celular;
            txtDireccion.Text = personaObtenida.Direccion;
            txtNroLibro.Text = personaObtenida.NroLibros.ToString();
            txtDeuda.Text = personaObtenida.MontoDeuda.ToString();

            txtCodigo.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtNroLibro.Enabled = false;
            txtDeuda.Enabled = false;
        }

        protected void btnSalMat_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.PersonaBusq);
        }
    }
}