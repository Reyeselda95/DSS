
using System;
using P2GenNHibernate.EN.Default_;

namespace P2GenNHibernate.CAD.Default_
{
public partial interface IOrderLineCAD
{
OrderLineEN ReadOIDDefault (int id);

int CreateOrderLine (OrderLineEN orderLine);

void ModifyLine (OrderLineEN orderLine);
}
}
