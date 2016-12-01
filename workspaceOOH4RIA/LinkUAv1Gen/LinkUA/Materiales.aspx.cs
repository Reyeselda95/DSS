using LinkUAv1GenNHibernate.CEN.LinkUAv1;
using LinkUAv1GenNHibernate.EN.LinkUAv1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkUA
{
    public partial class Materiales : System.Web.UI.Page
    {
        int inicial = 0;
        int final = 10;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["email"] == "" || Session["email"] == null)
            {
                Response.Redirect("login.aspx");
            }

            if (!IsPostBack)
            {
                inicial = 0;
                final = inicial + 10;
            }
            else
            {
                final = inicial + 10;
            }
            MaterialCEN matCEN = new MaterialCEN();
            IList<MaterialEN> lista = matCEN.Listar(inicial, final);
            List<MaterialEN> lParsed = lista as List<MaterialEN>;

            ListView1.DataSource = lParsed;
            ListView1.DataBind();
        }

        protected void Descargar(object sender, EventArgs e)
        {
            string email = (String)Session["email"];//Coger email, de la sesion

            LinkButton btn = (LinkButton)sender;//Coger del atributo id
            int id = Int32.Parse(btn.CommandArgument.ToString());

            MaterialCEN matCEN = new MaterialCEN();
            string matURL = matCEN.Descargar(id, 0);

            Page_Load(sender, e); // Recargar la página, el redirect lo hace un script en el .aspx
            //Response.Redirect(matURL); //Redirige al enlace de descarga
            //Response.Write(String.Format("window.open('{0}','_blank')", ResolveUrl(matURL)));
        }

        protected void First(object sender, EventArgs e)
        {
            inicial = 0;
        }

        protected void Previous(object sender, EventArgs e)
        {
            inicial = inicial - 10;
        }

        protected void Next(object sender, EventArgs e)
        {
            inicial = inicial + 10;
        }

        protected void Last(object sender, EventArgs e)
        {
            PublicacionCEN pc = new PublicacionCEN();
            inicial=pc.Listar(0, int.MaxValue).Count()-10;
        }

    }
}