
using System;
using P1GenNHibernate.EN.Práctica1;

namespace P1GenNHibernate.CAD.Práctica1
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int id);

int CrearLineaPedido (LineaPedidoEN lineaPedido);

void ModificarLinea (LineaPedidoEN lineaPedido);
}
}
