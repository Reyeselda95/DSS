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
    public partial class MasterPage1 : System.Web.UI.MasterPage
    {
        UsuarioCEN userCen = new UsuarioCEN();
        UsuarioEN userEn = new UsuarioEN();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String) Session["email"] == "" || Session["email"] == null)
            {
                userLabel.Text = "Log In ";
            }
            else{
                string email = (String)Session["email"];//Coger del atributo session
                userEn = userCen.get_IUsuarioCAD().ReadOIDDefault(email);
                userLabel.Text = userEn.Nick + " ";
            }
        }
    }
}