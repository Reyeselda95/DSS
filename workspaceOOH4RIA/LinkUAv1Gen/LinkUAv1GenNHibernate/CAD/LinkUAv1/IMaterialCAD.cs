
using System;
using LinkUAv1GenNHibernate.EN.LinkUAv1;

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial interface IMaterialCAD
{
MaterialEN ReadOIDDefault (int id);

int New_ (MaterialEN material);

void Modify (MaterialEN material);


void Destroy (int id);



MaterialEN Buscar (int id);


System.Collections.Generic.IList<MaterialEN> Listar (int first, int size);


System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> Por_asignatura (int p_asignatura);


System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> Por_usuario (string p_usuario);
}
}
