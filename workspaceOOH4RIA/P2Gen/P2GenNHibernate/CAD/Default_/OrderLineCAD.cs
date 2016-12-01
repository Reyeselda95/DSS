
using System;
using System.Text;
using P2GenNHibernate.CEN.Default_;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using P2GenNHibernate.EN.Default_;
using P2GenNHibernate.Exceptions;

/*
 * Clase OrderLine:
 *
 */

namespace P2GenNHibernate.CAD.Default_
{
public partial class OrderLineCAD : BasicCAD, IOrderLineCAD
{
public OrderLineCAD() : base ()
{
}

public OrderLineCAD(ISession sessionAux) : base (sessionAux)
{
}



public OrderLineEN ReadOIDDefault (int id)
{
        OrderLineEN orderLineEN = null;

        try
        {
                SessionInitializeTransaction ();
                orderLineEN = (OrderLineEN)session.Get (typeof(OrderLineEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in OrderLineCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return orderLineEN;
}

public System.Collections.Generic.IList<OrderLineEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<OrderLineEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(OrderLineEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<OrderLineEN>();
                        else
                                result = session.CreateCriteria (typeof(OrderLineEN)).List<OrderLineEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in OrderLineCAD.", ex);
        }

        return result;
}

public int CreateOrderLine (OrderLineEN orderLine)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (orderLine);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in OrderLineCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return orderLine.Id;
}

public void ModifyLine (OrderLineEN orderLine)
{
        try
        {
                SessionInitializeTransaction ();
                OrderLineEN orderLineEN = (OrderLineEN)session.Load (typeof(OrderLineEN), orderLine.Id);

                orderLineEN.Quantity = orderLine.Quantity;


                orderLineEN.Number = orderLine.Number;

                session.Update (orderLineEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in OrderLineCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
