
using System;
using LinkUAv1GenNHibernate.EN.LinkUAv1;

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial interface IAsignaturaCAD
{
AsignaturaEN ReadOIDDefault (int id);

int New_ (AsignaturaEN asignatura);

void Modify (AsignaturaEN asignatura);


void Destroy (int id);


AsignaturaEN Buscar (int id);


System.Collections.Generic.IList<AsignaturaEN> Listar (int first, int size);
}
}
