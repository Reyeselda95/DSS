

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using P2GenNHibernate.EN.Default_;
using P2GenNHibernate.CAD.Default_;

namespace P2GenNHibernate.CEN.Default_
{
/*
 *      Definition of the class OrderLineCEN
 *
 */
public partial class OrderLineCEN
{
private IOrderLineCAD _IOrderLineCAD;

public OrderLineCEN()
{
        this._IOrderLineCAD = new OrderLineCAD ();
}

public OrderLineCEN(IOrderLineCAD _IOrderLineCAD)
{
        this._IOrderLineCAD = _IOrderLineCAD;
}

public IOrderLineCAD get_IOrderLineCAD ()
{
        return this._IOrderLineCAD;
}

public int CreateOrderLine (int p_quantity, int p_number)
{
        OrderLineEN orderLineEN = null;
        int oid;

        //Initialized OrderLineEN
        orderLineEN = new OrderLineEN ();
        orderLineEN.Quantity = p_quantity;

        orderLineEN.Number = p_number;

        //Call to OrderLineCAD

        oid = _IOrderLineCAD.CreateOrderLine (orderLineEN);
        return oid;
}

public void ModifyLine (int p_oid, int p_quantity, int p_number)
{
        OrderLineEN orderLineEN = null;

        //Initialized OrderLineEN
        orderLineEN = new OrderLineEN ();
        orderLineEN.Id = p_oid;
        orderLineEN.Quantity = p_quantity;
        orderLineEN.Number = p_number;
        //Call to OrderLineCAD

        _IOrderLineCAD.ModifyLine (orderLineEN);
}
}
}
