
using System;
using LinkUAv1GenNHibernate.EN.LinkUAv1;

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string email);

string New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (string email);





UsuarioEN Buscar (string email);


System.Collections.Generic.IList<UsuarioEN> Listar (int first, int size);


System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> Por_titulacion (int p_titulacion);
}
}
