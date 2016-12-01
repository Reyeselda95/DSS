
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
public partial class AsignaturaCEN
{
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN> Por_titulacion (int p_titulacion)
{
        /*PROTECTED REGION ID(LinkUAv1GenNHibernate.CEN.LinkUAv1_Asignatura_por_titulacion) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<AsignaturaEN> lista = get_IAsignaturaCAD().Listar(0, int.MaxValue);
        System.Collections.Generic.IList<AsignaturaEN> lista2 = get_IAsignaturaCAD().Listar(0, int.MaxValue);

        foreach (AsignaturaEN a in lista2)
        {
            if (a.Titulacion_2.Id != p_titulacion)
            {
                lista.Remove(a);
            }
        }

        return lista;

        /*PROTECTED REGION END*/
}
}
}
