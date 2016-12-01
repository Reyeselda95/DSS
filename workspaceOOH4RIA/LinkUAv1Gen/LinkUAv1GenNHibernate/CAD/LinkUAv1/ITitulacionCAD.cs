
using System;
using LinkUAv1GenNHibernate.EN.LinkUAv1;

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial interface ITitulacionCAD
{
TitulacionEN ReadOIDDefault (int id);

int New_ (TitulacionEN titulacion);

void Modify (TitulacionEN titulacion);


void Destroy (int id);


TitulacionEN Buscar (int id);


System.Collections.Generic.IList<TitulacionEN> Listar (int first, int size);
}
}
