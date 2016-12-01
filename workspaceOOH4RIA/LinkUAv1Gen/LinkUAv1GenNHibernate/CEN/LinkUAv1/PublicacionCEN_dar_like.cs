
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
public partial class PublicacionCEN
{
public void Dar_like (int p_publicacion, string p_usuario)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Publicacion_dar_like) ENABLED START*/

        // Write here your custom code...

        PublicacionEN publiEN = Buscar (p_publicacion);
        UsuarioCEN usuCEN = new UsuarioCEN ();

        System.Collections.Generic.List<string> lista = new System.Collections.Generic.List<string>();

        publiEN.Likes += 1;
        publiEN.Usuario_3.Add (usuCEN.Buscar (p_usuario));
        get_IPublicacionCAD ().Modify (publiEN);

        lista.Add (p_usuario);
        get_IPublicacionCAD ().Like (p_publicacion, lista);

        /*PROTECTED REGION END*/
}
}
}
