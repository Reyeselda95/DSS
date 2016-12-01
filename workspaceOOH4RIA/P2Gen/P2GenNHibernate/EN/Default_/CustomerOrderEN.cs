
using System;
// Definición clase CustomerOrderEN
namespace P2GenNHibernate.EN.Default_
{
public partial class CustomerOrderEN
{
/**
 *	Atributo customer
 */
private P2GenNHibernate.EN.Default_.CustomerEN customer;



/**
 *	Atributo orderId
 */
private int orderId;



/**
 *	Atributo date
 */
private Nullable<DateTime> date;



/**
 *	Atributo address
 */
private string address;



/**
 *	Atributo city
 */
private string city;



/**
 *	Atributo state
 */
private string state;



/**
 *	Atributo zip
 */
private string zip;



/**
 *	Atributo paymentMethod
 */
private string paymentMethod;



/**
 *	Atributo status
 */
private P2GenNHibernate.Enumerated.Default_.OrderStatusEnum status;



/**
 *	Atributo orderLine
 */
private System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.OrderLineEN> orderLine;






public virtual P2GenNHibernate.EN.Default_.CustomerEN Customer {
        get { return customer; } set { customer = value;  }
}



public virtual int OrderId {
        get { return orderId; } set { orderId = value;  }
}



public virtual Nullable<DateTime> Date {
        get { return date; } set { date = value;  }
}



public virtual string Address {
        get { return address; } set { address = value;  }
}



public virtual string City {
        get { return city; } set { city = value;  }
}



public virtual string State {
        get { return state; } set { state = value;  }
}



public virtual string Zip {
        get { return zip; } set { zip = value;  }
}



public virtual string PaymentMethod {
        get { return paymentMethod; } set { paymentMethod = value;  }
}



public virtual P2GenNHibernate.Enumerated.Default_.OrderStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.OrderLineEN> OrderLine {
        get { return orderLine; } set { orderLine = value;  }
}





public CustomerOrderEN()
{
        orderLine = new System.Collections.Generic.List<P2GenNHibernate.EN.Default_.OrderLineEN>();
}



public CustomerOrderEN(int orderId, P2GenNHibernate.EN.Default_.CustomerEN customer, Nullable<DateTime> date, string address, string city, string state, string zip, string paymentMethod, P2GenNHibernate.Enumerated.Default_.OrderStatusEnum status, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.OrderLineEN> orderLine
                       )
{
        this.init (OrderId, customer, date, address, city, state, zip, paymentMethod, status, orderLine);
}


public CustomerOrderEN(CustomerOrderEN customerOrder)
{
        this.init (OrderId, customerOrder.Customer, customerOrder.Date, customerOrder.Address, customerOrder.City, customerOrder.State, customerOrder.Zip, customerOrder.PaymentMethod, customerOrder.Status, customerOrder.OrderLine);
}

private void init (int orderId, P2GenNHibernate.EN.Default_.CustomerEN customer, Nullable<DateTime> date, string address, string city, string state, string zip, string paymentMethod, P2GenNHibernate.Enumerated.Default_.OrderStatusEnum status, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.OrderLineEN> orderLine)
{
        this.OrderId = orderId;


        this.Customer = customer;

        this.Date = date;

        this.Address = address;

        this.City = city;

        this.State = state;

        this.Zip = zip;

        this.PaymentMethod = paymentMethod;

        this.Status = status;

        this.OrderLine = orderLine;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CustomerOrderEN t = obj as CustomerOrderEN;
        if (t == null)
                return false;
        if (OrderId.Equals (t.OrderId))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.OrderId.GetHashCode ();
        return hash;
}
}
}
