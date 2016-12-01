using LinkUAv1GenNHibernate.CEN.LinkUAv1;
using LinkUAv1GenNHibernate.EN.LinkUAv1;
using LinkUAv1GenNHibernate.Enumerated.LinkUAv1;
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
    public partial class Categoria : System.Web.UI.Page
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

            PublicacionCEN pc = new PublicacionCEN();
            CategoriaEnum categoria = CategoriaEnum.Otros;
            String cat = Request.QueryString["CAT"];

            switch (cat)
            {
                case "Social":
                    categoria = CategoriaEnum.Social;
                    break;

                case "Alojamiento":
                    categoria = CategoriaEnum.Piso;
                    break;

                case "Educacion":
                    categoria = CategoriaEnum.Academico;
                    break;

                case "Flechazo":
                    categoria = CategoriaEnum.Amor;
                    break;

                case "Otros":
                    categoria = CategoriaEnum.Otros;
                    break;
            }

            IList<PublicacionEN> l = pc.Por_categoria(categoria);
            //IList<PublicacionEN> l = pc.Listar(inicial, final);
            List<PublicacionEN> lParsed = l as List<PublicacionEN>;

            ListView1.DataSource = lParsed;
            ListView1.DataBind();
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

            Response.Redirect(Request.RawUrl); //Refresca
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