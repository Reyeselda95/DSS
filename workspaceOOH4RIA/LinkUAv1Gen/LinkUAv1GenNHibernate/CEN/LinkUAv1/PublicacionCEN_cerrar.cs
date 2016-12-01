
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
public void Cerrar (int p_oid)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Publicacion_cerrar) ENABLED START*/

        // Write here your custom code...


        PublicacionEN publiEN = get_IPublicacionCAD ().ReadOIDDefault (p_oid);

        publiEN.Cerrado = true;
        get_IPublicacionCAD ().Modify (publiEN);


        /*PROTECTED REGION END*/
}
}
}
