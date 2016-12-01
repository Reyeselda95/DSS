

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
 *      Definition of the class CustomerOrderCEN
 *
 */
public partial class CustomerOrderCEN
{
private ICustomerOrderCAD _ICustomerOrderCAD;

public CustomerOrderCEN()
{
        this._ICustomerOrderCAD = new CustomerOrderCAD ();
}

public CustomerOrderCEN(ICustomerOrderCAD _ICustomerOrderCAD)
{
        this._ICustomerOrderCAD = _ICustomerOrderCAD;
}

public ICustomerOrderCAD get_ICustomerOrderCAD ()
{
        return this._ICustomerOrderCAD;
}

public void AddOrderLine (int p_customerorder, System.Collections.Generic.IList<int> p_orderline)
{
        //Call to CustomerOrderCAD

        _ICustomerOrderCAD.AddOrderLine (p_customerorder, p_orderline);
}
public void RderLine (int p_customerorder, System.Collections.Generic.IList<int> p_orderline)
{
        //Call to CustomerOrderCAD

        _ICustomerOrderCAD.RderLine (p_customerorder, p_orderline);
}
public System.Collections.Generic.IList<CustomerOrderEN> GetAllOrders (int first, int size)
{
        System.Collections.Generic.IList<CustomerOrderEN> list = null;

        list = _ICustomerOrderCAD.GetAllOrders (first, size);
        return list;
}
public CustomerOrderEN GetByOID (int orderId)
{
        CustomerOrderEN customerOrderEN = null;

        customerOrderEN = _ICustomerOrderCAD.GetByOID (orderId);
        return customerOrderEN;
}

public int CreateOrder (int p_orderId, Nullable<DateTime> p_date, string p_address, string p_city, string p_state, string p_zip, string p_paymentMethod, P2GenNHibernate.Enumerated.Default_.OrderStatusEnum p_status)
{
        CustomerOrderEN customerOrderEN = null;
        int oid;

        //Initialized CustomerOrderEN
        customerOrderEN = new CustomerOrderEN ();
        customerOrderEN.OrderId = p_orderId;

        customerOrderEN.Date = p_date;

        customerOrderEN.Address = p_address;

        customerOrderEN.City = p_city;

        customerOrderEN.State = p_state;

        customerOrderEN.Zip = p_zip;

        customerOrderEN.PaymentMethod = p_paymentMethod;

        customerOrderEN.Status = p_status;

        //Call to CustomerOrderCAD

        oid = _ICustomerOrderCAD.CreateOrder (customerOrderEN);
        return oid;
}

public void DeleteOrder (int orderId)
{
        _ICustomerOrderCAD.DeleteOrder (orderId);
}

public void ModifyOrder (int p_oid, Nullable<DateTime> p_date, string p_address, string p_city, string p_state, string p_zip, string p_paymentMethod, P2GenNHibernate.Enumerated.Default_.OrderStatusEnum p_status)
{
        CustomerOrderEN customerOrderEN = null;

        //Initialized CustomerOrderEN
        customerOrderEN = new CustomerOrderEN ();
        customerOrderEN.OrderId = p_oid;
        customerOrderEN.Date = p_date;
        customerOrderEN.Address = p_address;
        customerOrderEN.City = p_city;
        customerOrderEN.State = p_state;
        customerOrderEN.Zip = p_zip;
        customerOrderEN.PaymentMethod = p_paymentMethod;
        customerOrderEN.Status = p_status;
        //Call to CustomerOrderCAD

        _ICustomerOrderCAD.ModifyOrder (customerOrderEN);
}
}
}
