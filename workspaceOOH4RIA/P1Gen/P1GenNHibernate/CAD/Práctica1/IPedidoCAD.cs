
using System;
using P1GenNHibernate.EN.Práctica1;

namespace P1GenNHibernate.CAD.Práctica1
{
public partial interface IPedidoCAD
{
PedidoEN ReadOIDDefault (int PedidoId);

int CrearPedido (PedidoEN pedido);

void ModificarPedido (PedidoEN pedido);


void BorrarPedido (int PedidoId);


PedidoEN DamePorOID (int PedidoId);


System.Collections.Generic.IList<PedidoEN> DameTodosLosPedidos (int first, int size);


void AnyadirLineaPedido (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs);

void BorrarLineaPedido (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs);
}
}
