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
    public partial class wfBPersona : System.Web.UI.Page
    {
        IPersonaBL _persona = new PersonaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                grdPersona.DataSource = dt;
            }
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
        
            if (txtCodigo.Text == "")
            {
                Response.Write("<script>alert('Por favor ingrese un código.')</script>");
                return;
            }


            List<Persona> lista = new List<Persona>();

            string codigo = txtCodigo.Text;


            lista = _persona.ListarPersonas();

            DataTable dt = new DataTable();
            dt.Columns.Add("Sel");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Correo");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Celular");
            dt.Columns.Add("NroLibros");
            dt.Columns.Add("MontoDeuda");


            foreach (Persona per in lista)
            {
                DataRow row = dt.NewRow();

                row["Sel"] = false;
                row["Codigo"] = per.Codigo;
                row["Apellidos"] = per.Apellidos;
                row["Nombres"] = per.Nombres;
                row["Correo"] = per.NroLibros;
                row["Direccion"] = per.MontoDeuda;
                row["Celular"] = per.Celular;
                row["NroLibros"] = per.Celular;
                row["MontoDeuda"] = per.Celular;

                dt.Rows.Add(row);
            }


            grdPersona.DataSource = dt;
            grdPersona.DataBind();
        }

        protected void btnSalir_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfPrincipal.aspx");
        }

        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfTPersona.aspx");
        }
    }
}