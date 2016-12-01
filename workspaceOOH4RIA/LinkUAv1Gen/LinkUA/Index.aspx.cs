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
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["email"] == "" || Session["email"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (!IsPostBack)
            {
                Session["inicial"] = Convert.ToString(0);
            }

            PublicacionCEN publiCEN = new PublicacionCEN();
            IList<PublicacionEN> lista = publiCEN.Listar(Convert.ToInt32((String)Session["inicial"]), 10);
            IList<PublicacionEN> destacados = publiCEN.Por_likes();
            List<PublicacionEN> lParsed = lista as List<PublicacionEN>;
            List<PublicacionEN> dParsed = destacados as List<PublicacionEN>;

            ListView1.DataSource = lParsed;
            ListView1.DataBind();

            ListView2.DataSource = dParsed;
            ListView2.DataBind();


        }

        protected void DarLike(object sender, EventArgs e)
        {
            string email = (String)Session["email"];//Coger email, de la sesion

            LinkButton btn = (LinkButton)sender;//Coger del atributo id
            int id = Int32.Parse(btn.CommandArgument.ToString());

            PublicacionCEN publiCEN = new PublicacionCEN();
            PublicacionEN publiEN = publiCEN.Buscar(id);

            if (publiCEN.Likeado(id, email))
            {
                publiCEN.Quitar_like(id, email);
            }
            else
            {
                publiCEN.Dar_like(id, email);
            }

            Page_Load(sender, e); //Refresca
        }

        protected void First(object sender, EventArgs e)
        {
            Session["inicial"] = Convert.ToString(0);
            Page_Load(sender, e);
        }

        protected void Previous(object sender, EventArgs e)
        {
            if (Convert.ToInt32((String)Session["inicial"]) - 10 >= 0)
            {
                Session["inicial"] = Convert.ToString(Convert.ToInt32((String)Session["inicial"]) - 10);
            }
            Page_Load(sender, e);
        }

        protected void Next(object sender, EventArgs e)
        {
            PublicacionCEN pc = new PublicacionCEN();
            if (Convert.ToInt32((String)Session["inicial"]) + 10 < pc.Listar(0, int.MaxValue).Count())
            {
                Session["inicial"] = Convert.ToString(Convert.ToInt32((String)Session["inicial"]) + 10);
            }
            Page_Load(sender, e);
        }

        protected void Last(object sender, EventArgs e)
        {
            PublicacionCEN pc = new PublicacionCEN();
            Session["inicial"] = Convert.ToString(pc.Listar(0, int.MaxValue).Count() - pc.Listar(0, int.MaxValue).Count() % 10);
            Page_Load(sender, e);
        }

    }
}