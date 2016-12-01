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
    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["email"] == "" || Session["email"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                UsuarioCEN user = new UsuarioCEN();
                UsuarioEN userEn = new UsuarioEN();
                userEn = user.Buscar(Session["email"].ToString());

                LabelNick.Text = userEn.Nick;
                LabelEmail.Text = userEn.Email;
                LabelFecha.Text = userEn.Fnac.ToString();
                LabelTelf.Text = userEn.Tfno;
                LabelNombre.Text = userEn.Nombre;
                LabelApellidos.Text = userEn.Apellidos;
                //LabelTitulacion.Text = userEn.Titulacion_1;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarPerfil.aspx");
        }
    }
}