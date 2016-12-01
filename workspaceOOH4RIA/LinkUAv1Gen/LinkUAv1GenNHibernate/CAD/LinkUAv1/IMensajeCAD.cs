
using System;
using LinkUAv1GenNHibernate.EN.LinkUAv1;

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial interface IMensajeCAD
{
MensajeEN ReadOIDDefault (int id);

int New_ (MensajeEN mensaje);

void Modify (MensajeEN mensaje);


void Destroy (int id);


MensajeEN Buscar (int id);


System.Collections.Generic.IList<MensajeEN> Listar (int first, int size);


System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> Por_emisor (string p_usuario1, string p_usuario2);


System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> Por_texto (string p_texto);
}
}
