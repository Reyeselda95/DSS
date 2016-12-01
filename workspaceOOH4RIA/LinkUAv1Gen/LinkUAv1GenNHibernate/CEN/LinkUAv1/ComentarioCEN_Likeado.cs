
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using LinkUAv1GenNHibernate.EN.LinkUAv1;
using LinkUAv1GenNHibernate.CAD.LinkUAv1;

namespace LinkUAv1GenNHibernate.CEN.LinkUAv1
{
public partial class ComentarioCEN
{
public bool Likeado (int p_comentario, string p_usuario)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Comentario_likeado) ENABLED START*/

        // Write here your custom code...

        UsuarioCEN usuCEN = new UsuarioCEN ();

        if (Buscar (p_comentario).Usuario_4.Contains (usuCEN.Buscar (p_usuario))) {
                return true;
        }
        else{
                return false;
        }

        /*PROTECTED REGION END*/
}
}
}
