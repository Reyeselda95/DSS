
using System;
using LinkUAv1GenNHibernate.EN.LinkUAv1;

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial interface IPublicacionCAD
{
PublicacionEN ReadOIDDefault (int id);

int New_ (PublicacionEN publicacion);

void Modify (PublicacionEN publicacion);


void Destroy (int id);




void Like (int p_Publicacion_OID, System.Collections.Generic.IList<string> p_usuario_3_OIDs);

PublicacionEN Buscar (int id);


System.Collections.Generic.IList<PublicacionEN> Listar (int first, int size);




System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> Por_likes ();




void Unlike (int p_Publicacion_OID, System.Collections.Generic.IList<string> p_usuario_3_OIDs);
}
}
