using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinkUAv1GenNHibernate.CEN.LinkUAv1;
using LinkUAv1GenNHibernate.EN.LinkUAv1;

namespace LinkUA
{
    public partial class SubirComentario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if ((String)Session["email"] == "" || Session["email"] == null)
            {
                Response.Redirect("login.aspx");
                NombreUsuario.Text = "Registrate para comentar";
                TextBox1.Visible = false;
            }
            else
            {
                UsuarioCEN user = new UsuarioCEN();
                NombreUsuario.Text = user.Buscar(Session["email"].ToString()).Nick;
            }
        }
    }
}