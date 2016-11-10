    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfTPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNroLibro.Text = "0";
            txtDeuda.Text = "0";
        }

        protected void btnNew2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfBPersona.aspx");
        }

        protected void btnGrabar_Click(object sender, ImageClickEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text) && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellido.Text) && !String.IsNullOrEmpty(txtCorreo.Text) && !String.IsNullOrEmpty(txtTelefono.Text) && !String.IsNullOrEmpty(txtDireccion.Text))
            {
                Response.Write("<script>alert('El registro se registró correctamente.')</script>");

            }
            else
            {
                Response.Write("<script>alert('No se puede registrar la persona, todos los campos son obligatorios.')</script>");
            }
        }
    }
}