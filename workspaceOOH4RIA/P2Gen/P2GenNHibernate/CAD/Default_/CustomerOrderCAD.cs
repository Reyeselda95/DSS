
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
 * Clase CustomerOrder:
 *
 */

namespace P2GenNHibernate.CAD.Default_
{
public partial class CustomerOrderCAD : BasicCAD, ICustomerOrderCAD
{
public CustomerOrderCAD() : base ()
{
}

public CustomerOrderCAD(ISession sessionAux) : base (sessionAux)
{
}



public CustomerOrderEN ReadOIDDefault (int orderId)
{
        CustomerOrderEN customerOrderEN = null;

        try
        {
                SessionInitializeTransaction ();
                customerOrderEN = (CustomerOrderEN)session.Get (typeof(CustomerOrderEN), orderId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return customerOrderEN;
}

public System.Collections.Generic.IList<CustomerOrderEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CustomerOrderEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CustomerOrderEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CustomerOrderEN>();
                        else
                                result = session.CreateCriteria (typeof(CustomerOrderEN)).List<CustomerOrderEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }

        return result;
}

public void AddOrderLine (int p_customerorder, System.Collections.Generic.IList<int> p_orderline)
{
        P2GenNHibernate.EN.Default_.CustomerOrderEN customerOrderEN = null;
        try
        {
                SessionInitializeTransaction ();
                customerOrderEN = (CustomerOrderEN)session.Load (typeof(CustomerOrderEN), p_customerorder);
                P2GenNHibernate.EN.Default_.OrderLineEN orderLineENAux = null;
                if (customerOrderEN.OrderLine == null) {
                        customerOrderEN.OrderLine = new System.Collections.Generic.List<P2GenNHibernate.EN.Default_.OrderLineEN>();
                }

                foreach (int item in p_orderline) {
                        orderLineENAux = new P2GenNHibernate.EN.Default_.OrderLineEN ();
                        orderLineENAux = (P2GenNHibernate.EN.Default_.OrderLineEN)session.Load (typeof(P2GenNHibernate.EN.Default_.OrderLineEN), item);
                        orderLineENAux.Order = customerOrderEN;

                        customerOrderEN.OrderLine.Add (orderLineENAux);
                }


                session.Update (customerOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RderLine (int p_customerorder, System.Collections.Generic.IList<int> p_orderline)
{
        try
        {
                SessionInitializeTransaction ();
                P2GenNHibernate.EN.Default_.CustomerOrderEN customerOrderEN = null;
                customerOrderEN = (CustomerOrderEN)session.Load (typeof(CustomerOrderEN), p_customerorder);

                P2GenNHibernate.EN.Default_.OrderLineEN orderLineENAux = null;
                if (customerOrderEN.OrderLine != null) {
                        foreach (int item in p_orderline) {
                                orderLineENAux = (P2GenNHibernate.EN.Default_.OrderLineEN)session.Load (typeof(P2GenNHibernate.EN.Default_.OrderLineEN), item);
                                if (customerOrderEN.OrderLine.Contains (orderLineENAux) == true) {
                                        customerOrderEN.OrderLine.Remove (orderLineENAux);
                                        orderLineENAux.Order = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_orderline you are trying to unrelationer, doesn't exist in CustomerOrderEN");
                        }
                }

                session.Update (customerOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<CustomerOrderEN> GetAllOrders (int first, int size)
{
        System.Collections.Generic.IList<CustomerOrderEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CustomerOrderEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CustomerOrderEN>();
                else
                        result = session.CreateCriteria (typeof(CustomerOrderEN)).List<CustomerOrderEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetByOID
//Con e: CustomerOrderEN
public CustomerOrderEN GetByOID (int orderId)
{
        CustomerOrderEN customerOrderEN = null;

        try
        {
                SessionInitializeTransaction ();
                customerOrderEN = (CustomerOrderEN)session.Get (typeof(CustomerOrderEN), orderId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return customerOrderEN;
}

public int CreateOrder (CustomerOrderEN customerOrder)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (customerOrder);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return customerOrder.OrderId;
}

public void DeleteOrder (int orderId)
{
        try
        {
                SessionInitializeTransaction ();
                CustomerOrderEN customerOrderEN = (CustomerOrderEN)session.Load (typeof(CustomerOrderEN), orderId);
                session.Delete (customerOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void ModifyOrder (CustomerOrderEN customerOrder)
{
        try
        {
                SessionInitializeTransaction ();
                CustomerOrderEN customerOrderEN = (CustomerOrderEN)session.Load (typeof(CustomerOrderEN), customerOrder.OrderId);

                customerOrderEN.Date = customerOrder.Date;


                customerOrderEN.Address = customerOrder.Address;


                customerOrderEN.City = customerOrder.City;


                customerOrderEN.State = customerOrder.State;


                customerOrderEN.Zip = customerOrder.Zip;


                customerOrderEN.PaymentMethod = customerOrder.PaymentMethod;


                customerOrderEN.Status = customerOrder.Status;

                session.Update (customerOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
