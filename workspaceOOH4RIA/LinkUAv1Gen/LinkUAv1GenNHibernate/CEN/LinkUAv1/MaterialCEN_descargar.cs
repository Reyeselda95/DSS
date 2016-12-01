
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
public string Descargar (int p_Material_OID, int p_descargas)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Material_descargar) ENABLED START*/

        // Write here your custom code...

        MaterialCEN matCEN = new MaterialCEN ();
        MaterialEN matEN = matCEN.Buscar (p_Material_OID);

        matEN.Descargas++;
        get_IMaterialCAD ().Modify (matEN);

        return matEN.Url;

        /*PROTECTED REGION END*/
}
}
}
