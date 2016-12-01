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
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIni_Click(object sender, EventArgs e)
        {
            UsuarioCEN userCen = new UsuarioCEN();
            UsuarioEN userEn = new UsuarioEN();

            string email = UserName.Text;
            string pass = Password.Text;

            if (userCen.Login(email, pass)) 
            {
                Session["email"] = email;

                Response.Redirect("Index.aspx");
            }
            else
            {
                LabelError.Visible = true;
            }
        }

    }
}