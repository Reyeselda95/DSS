
using System;
using P1GenNHibernate.EN.Práctica1;

namespace P1GenNHibernate.CAD.Práctica1
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string NIF);

string CrearCliente (ClienteEN cliente);

void ModificarCliente (ClienteEN cliente);


void BorrarCliente (string NIF);



ClienteEN DameClientePorOID (string NIF);
}
}
