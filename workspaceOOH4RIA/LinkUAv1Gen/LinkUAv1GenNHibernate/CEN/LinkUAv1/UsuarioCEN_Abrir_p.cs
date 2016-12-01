
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
public partial class UsuarioCEN
{
public void Abrir_p (int p_oid)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Usuario_abrir_p) ENABLED START*/

        // Write here your custom code...

        PublicacionCEN publiCEN = new PublicacionCEN ();
        PublicacionEN publiEN = publiCEN.get_IPublicacionCAD ().ReadOIDDefault (p_oid);

        publiEN.Cerrado = false;
        publiCEN.get_IPublicacionCAD ().Modify (publiEN);

        /*PROTECTED REGION END*/
}
}
}
