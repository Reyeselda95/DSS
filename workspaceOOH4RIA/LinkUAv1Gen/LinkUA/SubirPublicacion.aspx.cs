using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinkUAv1GenNHibernate.CEN.LinkUAv1;
using LinkUAv1GenNHibernate.EN.LinkUAv1;
using LinkUAv1GenNHibernate.Enumerated.LinkUAv1;
using System.Text.RegularExpressions;

namespace LinkUA
{
    public partial class SubirPublicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioAnonimo_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioAnonimo.Checked==true)
            RadioFirmado.Checked = false;
        }

        protected void RadioFirmado_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioFirmado.Checked == true)
            RadioAnonimo.Checked = false;
        }

        protected void Publicar_Click(object sender, EventArgs e)
        {
            PublicacionCEN publiCen = new PublicacionCEN();
            bool anonimo=true;
            CategoriaEnum categoria = CategoriaEnum.Otros;

            if(RadioAnonimo.Checked==true)
            {
                anonimo=true;
            }
            else if(RadioFirmado.Checked==true)
            {
                anonimo=false;
            }

            switch(cat.SelectedValue)
            {
                case "1":
                        categoria=CategoriaEnum.Social;
                    break;

                case "2":
                        categoria = CategoriaEnum.Piso;
                    break;

                case "3":
                        categoria = CategoriaEnum.Academico;
                    break;

                case "4":
                        categoria = CategoriaEnum.Amor;
                    break;

                case "5":
                        categoria = CategoriaEnum.Otros;
                    break;
            }

            publiCen.New_(titulo.Text, cont.Text, anonimo, false, DateTime.Now, 0, Session["email"].ToString(), categoria);


        }
    }
}