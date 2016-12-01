
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
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> Por_publicacion (int p_publicacion)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Comentario_por_publicacion) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<ComentarioEN> lista = get_IComentarioCAD ().Listar (0, int.MaxValue);
        System.Collections.Generic.IList<ComentarioEN> lista2 = get_IComentarioCAD ().Listar (0, int.MaxValue);

        foreach (ComentarioEN c in lista2) {
                if (c.Publicacion_3.Id != p_publicacion) {
                        lista.Remove (c);
                }
        }

        return lista;
        /*PROTECTED REGION END*/
}
}
}
