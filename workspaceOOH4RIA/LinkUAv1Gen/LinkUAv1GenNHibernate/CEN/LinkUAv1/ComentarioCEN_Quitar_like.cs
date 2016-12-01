
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
public void Quitar_like (int p_comentario, string p_usuario)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Comentario_quitar_like) ENABLED START*/

        // Write here your custom code...

        ComentarioEN comentarioEN = get_IComentarioCAD ().Buscar (p_comentario);
        UsuarioCEN usuCEN = new UsuarioCEN ();

        comentarioEN.Likes -= 1;
        comentarioEN.Usuario_4.Remove (usuCEN.Buscar (p_usuario));
        get_IComentarioCAD ().Modify (comentarioEN);

        System.Collections.Generic.List<string> lista = new System.Collections.Generic.List<string>();

        lista.Add (p_usuario);
        get_IComentarioCAD ().Unlike (p_comentario, lista);

        /*PROTECTED REGION END*/
}
}
}
