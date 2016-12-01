
using System;
using LinkUAv1GenNHibernate.EN.LinkUAv1;

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int id);

int New_ (ComentarioEN comentario);

void Modify (ComentarioEN comentario);


void Destroy (int id);


void Like (int p_Comentario_OID, System.Collections.Generic.IList<string> p_usuario_4_OIDs);

ComentarioEN Buscar (int id);


System.Collections.Generic.IList<ComentarioEN> Listar (int first, int size);




void Unlike (int p_Comentario_OID, System.Collections.Generic.IList<string> p_usuario_4_OIDs);
}
}
