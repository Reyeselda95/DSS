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
    public partial class VerPublicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Comentar
            if ((String)Session["email"] == "" || Session["email"] == null)
            {
                Response.Redirect("login.aspx");
                NombreUsuario.Text = "Registrate para comentar";
                SComentario.Visible = false;
            }
            else
            {
                UsuarioCEN user = new UsuarioCEN();
                NombreUsuario.Text = user.Buscar(Session["email"].ToString()).Nick + ":";
            }

            //Publicación
            String id = Request.QueryString["ID"].Replace("'", "");;
            int idInt = Int32.Parse(id);

            PublicacionCEN publiCen = new PublicacionCEN();
            PublicacionEN publiEn= publiCen.Buscar(idInt);
            List<PublicacionEN> listaPuEn =  new List<PublicacionEN>();
            listaPuEn.Add(publiEn);

            ListView1.DataSource = listaPuEn;
            ListView1.DataBind();

            //Comentarios
            ComentarioCEN comentCen = new ComentarioCEN();
            IList<ComentarioEN> listCom = comentCen.Por_publicacion(idInt);
            List<ComentarioEN> listaCoEn = listCom as List<ComentarioEN>;

            ListView2.DataSource = listaCoEn;
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

        protected void ComentarClick(object sender, EventArgs e){
            ComentarioCEN comentCen = new ComentarioCEN();
            String id = Request.QueryString["ID"].Replace("'", "");;
            int idInt = Int32.Parse(id);

            comentCen.New_(SComentario.Text, DateTime.Now, 0, Session["Email"].ToString(), idInt);
        }
    }
}