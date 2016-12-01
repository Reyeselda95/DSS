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
    public partial class changePass1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String) Session["email"] == "" || Session["email"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void ButtonIni_Click(object sender, EventArgs e)
        {
            UsuarioCEN userCen = new UsuarioCEN();
            UsuarioEN userEn = new UsuarioEN();

            string email = (String)Session["email"];//Coger del atributo session
            string LastPass = lastPass.Text;
            string Pass = pass1.Text;
            string Pass2 = pass2.Text;

            if (userCen.Login(email, LastPass))
            {
                if(Pass.Equals(Pass2)){
                    try{
                        userEn = userCen.get_IUsuarioCAD().ReadOIDDefault(email);
                        userEn.Pass=Pass;
                        userCen.get_IUsuarioCAD().Modify(userEn);
                        Response.Redirect("perfil.aspx");
                    }
                    catch(Exception ex){}
                }
            }
        }

    }
}