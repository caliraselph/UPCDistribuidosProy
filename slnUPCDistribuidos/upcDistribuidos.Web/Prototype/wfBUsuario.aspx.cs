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
    public partial class wfBUsuario : System.Web.UI.Page
    {
        IUsuarioBL _usuario = new UsuarioBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                grdUsuario.DataSource = dt;
            }
        }

        protected void btnNewUsu_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.UsuarioTrans);
        }

        protected void btnSalir_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Formularios.Principal);
        }

        protected void btnBusUsu_Click(object sender, ImageClickEventArgs e)
        {
            Usuario usuarioABuscar = new Usuario();
            List<UsuarioListar> lista = new List<UsuarioListar>();

            usuarioABuscar.codUsuario = txtCodigo.Text;
            usuarioABuscar.nombre = txtDescripcion.Text;

            lista = _usuario.ListarUsuarios(usuarioABuscar);

            DataTable dt = new DataTable();
            dt.Columns.Add("CodUsuario");
            dt.Columns.Add("Password");
            dt.Columns.Add("Perfil");
            dt.Columns.Add("NombreCompleto");

            foreach (UsuarioListar usu in lista)
            {
                DataRow row = dt.NewRow();

                row["CodUsuario"] = usu.CodUsuario;

                row["Password"] = usu.Password;

                row["Perfil"] = usu.Perfil;

                row["NombreCompleto"] = usu.NombreCompleto;

                dt.Rows.Add(row);
            }

            grdUsuario.DataSource = dt;
            grdUsuario.DataBind();
        }
    }
}