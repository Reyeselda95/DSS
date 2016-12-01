
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
public partial class MaterialCEN
{
public bool Propietaro (int p_material, string p_usuario)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Material_propietaro) ENABLED START*/

        // Write here your custom code...

        if (Buscar (p_material).Usuario_8.Email == p_usuario) {
                return true;
        }
        else{
                return false;
        }


        /*PROTECTED REGION END*/
}
}
}
