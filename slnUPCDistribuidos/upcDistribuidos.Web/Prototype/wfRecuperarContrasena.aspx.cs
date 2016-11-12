using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfRecuperarContrasena : System.Web.UI.Page
    {
        private string email2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                email2 = "";
            }
            else
            {
                email2 = "U201202510@upc.edu.pe";
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();

            if (email == "U201202510@upc.edu.pe")
            {
                Response.Write("<script>window.alert('Se ha enviado recordatorio de contraseña a su correo');</script>");
            }else
            {
                if ("U201202510@upc.edu.pe" != email && email2 !="" && email!="")
                {
                    Response.Write("<script>window.alert('Correo es incorrecto');</script>");
                }

                if (email2 =="" && email != "U201202510@upc.edu.pe" && email != "")
                {
                    Response.Write("<script>window.alert('Usuario no cuenta con email registrado');</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('Falló el envío del recordatorio de contraseña');</script>");
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfLogin.aspx");
        }
    }
}