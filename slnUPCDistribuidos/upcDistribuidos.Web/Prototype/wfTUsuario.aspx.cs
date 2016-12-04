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
    public partial class wfTUsuario : System.Web.UI.Page
    {
        IUsuarioBL _usuario = new UsuarioBL();
        IPersonaBL _persona = new PersonaBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewUsu_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "" || txtContrasena.Text == "" || txtCodPersona.Text == "")
                {
                    Response.Write("<script>alert('Por favor ingrese los datos faltantes.')</script>");
                    return;
                }

                Usuario usuario = new Usuario();
                usuario.codUsuario = txtUsuario.Text;
                usuario.password = txtContrasena.Text;
                usuario.perfil_id = ddlPerfil.SelectedValue;
                usuario.per_id = int.Parse(lblIdPersona.Text);
                usuario.estado = bool.Parse(ddlEstado.SelectedValue);

                _usuario.RegistrarUsuario(usuario);
                Response.Write("<script>alert('El usuario se registró correctamente.')</script>");
                Response.Redirect(Formularios.UsuarioBusq);
            }
            catch
            {
                Response.Write("<script>alert('Ocurrió un error al ingresar los datos.')</script>");
            }
        }

        protected void btnSalUsu_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.UsuarioBusq);
        }

        protected void btnBusPer_Click(object sender, ImageClickEventArgs e)
        {
            if (txtCodPersona.Text == "" || txtDescPersona.Text == "")
            {
                Response.Write("<script>alert('Por favor ingresar el código o el nombre de la persona.')</script>");
                return;
            }

            Persona persona = new Persona();

            persona = _persona.ObtenerPersona(txtCodPersona.Text);

            txtCodPersona.Text = persona.Codigo;
            txtDescPersona.Text = persona.Nombres + " " + persona.Apellidos;
            lblIdPersona.Text = Convert.ToString(persona.Id);

            //Response.Write("<script>window.open('wfBPersona.aspx', 'Persona', 'location=1,status=1,scrollbars=1,width=800,height=500');</script>");

        }
    }
}