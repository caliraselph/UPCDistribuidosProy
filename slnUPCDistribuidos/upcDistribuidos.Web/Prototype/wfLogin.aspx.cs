using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfLogin : System.Web.UI.Page
    {
        private Int32 contador;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                contador = 0;
            }
            else
            {
                contador = 3;
            }

        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            var tusu = "";
            var usu = txtUsuario.Text.Trim();
            var con = txtContraseña.Text.Trim();

            if (usu=="SARIZACA" || usu== "BBONIFAZ")
            {
                if (usu == "BBONIFAZ")
                {
                    tusu = "Usuario";
                }else{
                    tusu = "Administrador(a)";
                }

                if (con== "1234")
                { 
                    if(tusu == "Administrador(a)")
                    {
                        Response.Redirect("wfPrincipal.aspx");
                    }

                    if (tusu == "Usuario")
                    {
                        Response.Redirect("wfPrincipalUsu.aspx");
                    }
                }else
                {
                    if (contador == 3)
                    {
                        Response.Write("<script>window.alert('Usuario ha sido bloqueado');</script>");
                    }
                    Response.Write("<script>window.alert('Contraseña inválida');</script>");
                    txtUsuario.Focus();
                }
            }
            else
            {
                Response.Write("<script>window.alert('El usuario ingresado no se encuentra registrado');</script>");
                txtUsuario.Focus();
            }

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}