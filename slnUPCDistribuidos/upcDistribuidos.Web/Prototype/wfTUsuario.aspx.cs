using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfTUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSalir_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfBUsuario.aspx");
        }

        protected void btnGrabar_Click(object sender, ImageClickEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtContrasena.Text) )
            {
                Response.Write("<script>alert('El registro se registró correctamente.')</script>");

            }
            else
            {
                Response.Write("<script>alert('No se puede registrar el usuario, todos los campos son obligatorios.')</script>");
            }
        }

       
    }
}