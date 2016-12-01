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
    public partial class MisPublicaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["email"] == "" || Session["email"] == null)
            {
                Response.Redirect("login.aspx");
            }

            if (!IsPostBack)
            {
                string email = Session["email"].ToString();
                PublicacionCEN pc = new PublicacionCEN();
                IList<PublicacionEN> l = pc.Por_usuario(email);
                List<PublicacionEN> lParsed = l as List<PublicacionEN>;

                ListView1.DataSource = lParsed;
                ListView1.DataBind();
            }
           // else
            //{
              //  PublicacionCEN pc = new PublicacionCEN();
                //IList<PublicacionEN> l = pc.Listar(0, 5);
                //List<PublicacionEN> lParsed = l as List<PublicacionEN>;

                //ListView1.DataSource = lParsed;
                //ListView1.DataBind();}
        }
    }
}