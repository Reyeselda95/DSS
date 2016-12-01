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
    public partial class ModificarPerfil : System.Web.UI.Page
    {
        UsuarioCEN userCen = new UsuarioCEN();
        UsuarioEN userEn = new UsuarioEN();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String) Session["email"] == "" || Session["email"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else{
                string email = (String)Session["email"];//Coger del atributo session
                userEn = userCen.get_IUsuarioCAD().ReadOIDDefault(email);
                NickName.Text = userEn.Nick;
                User.Text = userEn.Email;
                TextBox2.Text = userEn.Nombre;
                TextBox3.Text = userEn.Apellidos;
                TextBox4.Text = userEn.Tfno;
                fnac.Text = userEn.Fnac.ToString();
            }
        }

        protected void Label6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                userEn.Nick = NickName.Text;
                userEn.Email = User.Text;
                userEn.Nombre = TextBox2.Text;
                userEn.Apellidos = TextBox3.Text;
                userEn.Tfno = TextBox4.Text;
                userEn.Fnac = Convert.ToDateTime(fnac.Text);
                userCen.get_IUsuarioCAD().Modify(userEn);
            }catch(Exception ex){}
        }
    }
}