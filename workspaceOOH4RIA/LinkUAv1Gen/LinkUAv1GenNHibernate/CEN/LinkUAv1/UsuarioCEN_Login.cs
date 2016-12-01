
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
public bool Login (string p_Usuario_OID, string p_pass)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Usuario_login) ENABLED START*/

        // Write here your custom code...


        bool logueado = false;
        UsuarioEN usuen = get_IUsuarioCAD ().ReadOIDDefault (p_Usuario_OID);

        if (Exists (p_Usuario_OID)) {
                if (usuen.Pass.Equals (p_pass)) {
                        logueado = true;
                }
        }

        return logueado;

        /*PROTECTED REGION END*/
}
}
}
