
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
public bool Exists (string p_Usuario_OID)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Usuario_exists) ENABLED START*/

        // Write here your custom code...



        bool existe = false;
        UsuarioEN usuen = get_IUsuarioCAD ().ReadOIDDefault (p_Usuario_OID);

        if (usuen != null) {
                existe = true;
        }

        return existe;



        /*PROTECTED REGION END*/
}
}
}
