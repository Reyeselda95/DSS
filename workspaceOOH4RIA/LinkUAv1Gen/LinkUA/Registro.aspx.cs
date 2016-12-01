using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinkUAv1GenNHibernate.CEN.LinkUAv1;
using LinkUAv1GenNHibernate.EN.LinkUAv1;
using System.Text.RegularExpressions;

namespace LinkUA
{
    public partial class Registro1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TitulacionCEN titulaCen = new TitulacionCEN();
            foreach(TitulacionEN T in titulaCen.Listar(0,int.MaxValue))
            {
                titulacion.Items.Add(T.Nombre);
            }
            

        }

        private Boolean email_ua(String email)
        {
            String expresion;
            expresion = "@alu.ua.es";
            if (email.Contains(expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void ButtonCrear_Click(object sender, EventArgs e)
        {
            UsuarioCEN userCen = new UsuarioCEN();
            if (!email_ua(email1.Text))
            {
                LabelError3.Visible = true;
            }
            else
            {
                LabelError3.Visible = false;

                if (userCen.Exists(email1.Text))
                {
                    LabelError2.Visible = true;
                }
                else
                {
                    try
                    {
                        //user.Foto = "1";
                        userCen.New_(email1.Text, nick.Text, nom.Text, ape.Text, Convert.ToDateTime(fnac.Text), telf.Text, pass1.Text, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum.tramitando,titulacion.SelectedIndex+1);
                        Response.Redirect("Index.aspx");
                    }
                    catch (Exception ex)
                    {
                        LabelError1.Visible = true;
                    }
                }
            }
        }

    }
}