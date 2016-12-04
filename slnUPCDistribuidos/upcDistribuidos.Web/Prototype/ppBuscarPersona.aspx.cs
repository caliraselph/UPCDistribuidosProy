using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.ClienteLogica.Implementacion;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.Web.Prototype
{
    public partial class ppBuscarPersona : System.Web.UI.Page
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

        protected void grdPersona_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument.ToString());

            string _cod = grdPersona.Rows[index].Cells[1].Text.ToString();
                     
            //ClientScript.RegisterClientScriptBlock(GetType(), "Refresca", "window.opener.location.reload(); window.close();", true);
            ClientScript.RegisterClientScriptBlock(GetType(), "Refresca", "window.opener.MostrarCodigoEmpleado('" + _cod + "');window.close();", true);
            
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            //if (txtCodigo.Text == "")
            //{
            //    Response.Write("<script>alert('Por favor ingrese un código.')</script>");
            //    return;
            //}


            List<Persona> lista = new List<Persona>();

            string codigo = txtCodigo.Text;


            lista = _persona.ListarPersonas();

            DataTable dt = new DataTable();
       
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Email");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("NroLibros");
       
            foreach (Persona per in lista)
            {
                DataRow row = dt.NewRow();

                //row["Sel"] = false;
                row["Codigo"] = per.Codigo;
                row["Apellidos"] = per.Apellidos;
                row["Nombres"] = per.Nombres;
                row["Email"] = per.Correo;
                row["Telefono"] = per.Celular;
                row["NroLibros"] = per.NroLibros;
                
                dt.Rows.Add(row);
            }
                           
            grdPersona.DataSource = dt;
            grdPersona.DataBind();
        }
    }
}