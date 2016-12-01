
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
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> Por_usuario (string p_usuario)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Publicacion_por_usuario) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<PublicacionEN> lista = get_IPublicacionCAD ().Listar (0, int.MaxValue);
        System.Collections.Generic.IList<PublicacionEN> lista2 = get_IPublicacionCAD ().Listar (0, int.MaxValue);

        foreach (PublicacionEN p in lista2) {
                if (p.Usuario_1.Email != p_usuario) {
                        lista.Remove (p); //Puede que de una excepcion, en tal caso arreglar el c?digo
                }
        }

        return lista;

        /*PROTECTED REGION END*/
}
}
}
