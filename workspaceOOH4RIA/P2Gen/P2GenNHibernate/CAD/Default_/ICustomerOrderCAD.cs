
using System;
using P2GenNHibernate.EN.Default_;

namespace P2GenNHibernate.CAD.Default_
{
public partial interface ICustomerOrderCAD
{
CustomerOrderEN ReadOIDDefault (int orderId);

void AddOrderLine (int p_customerorder, System.Collections.Generic.IList<int> p_orderline);

void RderLine (int p_customerorder, System.Collections.Generic.IList<int> p_orderline);

System.Collections.Generic.IList<CustomerOrderEN> GetAllOrders (int first, int size);


CustomerOrderEN GetByOID (int orderId);


int CreateOrder (CustomerOrderEN customerOrder);

void DeleteOrder (int orderId);


void ModifyOrder (CustomerOrderEN customerOrder);
}
}
