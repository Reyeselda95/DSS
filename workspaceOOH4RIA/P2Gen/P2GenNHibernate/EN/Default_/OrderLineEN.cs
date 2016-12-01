
using System;
// Definición clase OrderLineEN
namespace P2GenNHibernate.EN.Default_
{
public partial class OrderLineEN
{
/**
 *	Atributo order
 */
private P2GenNHibernate.EN.Default_.CustomerOrderEN order;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo quantity
 */
private int quantity;



/**
 *	Atributo number
 */
private int number;



/**
 *	Atributo product
 */
private P2GenNHibernate.EN.Default_.ProductEN product;






public virtual P2GenNHibernate.EN.Default_.CustomerOrderEN Order {
        get { return order; } set { order = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Quantity {
        get { return quantity; } set { quantity = value;  }
}



public virtual int Number {
        get { return number; } set { number = value;  }
}



public virtual P2GenNHibernate.EN.Default_.ProductEN Product {
        get { return product; } set { product = value;  }
}





public OrderLineEN()
{
}



public OrderLineEN(int id, P2GenNHibernate.EN.Default_.CustomerOrderEN order, int quantity, int number, P2GenNHibernate.EN.Default_.ProductEN product
                   )
{
        this.init (Id, order, quantity, number, product);
}


public OrderLineEN(OrderLineEN orderLine)
{
        this.init (Id, orderLine.Order, orderLine.Quantity, orderLine.Number, orderLine.Product);
}

private void init (int id, P2GenNHibernate.EN.Default_.CustomerOrderEN order, int quantity, int number, P2GenNHibernate.EN.Default_.ProductEN product)
{
        this.Id = id;


        this.Order = order;

        this.Quantity = quantity;

        this.Number = number;

        this.Product = product;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        OrderLineEN t = obj as OrderLineEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
