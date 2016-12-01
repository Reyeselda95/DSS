
using System;
// Definición clase ProductEN
namespace P2GenNHibernate.EN.Default_
{
public partial class ProductEN
{
/**
 *	Atributo orderline
 */
private System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.OrderLineEN> orderline;



/**
 *	Atributo productId
 */
private int productId;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo photoURL
 */
private string photoURL;



/**
 *	Atributo price
 */
private float price;



/**
 *	Atributo stock
 */
private int stock;



/**
 *	Atributo category
 */
private P2GenNHibernate.EN.Default_.CategoryEN category;






public virtual System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.OrderLineEN> Orderline {
        get { return orderline; } set { orderline = value;  }
}



public virtual int ProductId {
        get { return productId; } set { productId = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string PhotoURL {
        get { return photoURL; } set { photoURL = value;  }
}



public virtual float Price {
        get { return price; } set { price = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}



public virtual P2GenNHibernate.EN.Default_.CategoryEN Category {
        get { return category; } set { category = value;  }
}





public ProductEN()
{
        orderline = new System.Collections.Generic.List<P2GenNHibernate.EN.Default_.OrderLineEN>();
}



public ProductEN(int productId, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.OrderLineEN> orderline, string name, string descripcion, string photoURL, float price, int stock, P2GenNHibernate.EN.Default_.CategoryEN category
                 )
{
        this.init (ProductId, orderline, name, descripcion, photoURL, price, stock, category);
}


public ProductEN(ProductEN product)
{
        this.init (ProductId, product.Orderline, product.Name, product.Descripcion, product.PhotoURL, product.Price, product.Stock, product.Category);
}

private void init (int productId, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.OrderLineEN> orderline, string name, string descripcion, string photoURL, float price, int stock, P2GenNHibernate.EN.Default_.CategoryEN category)
{
        this.ProductId = productId;


        this.Orderline = orderline;

        this.Name = name;

        this.Descripcion = descripcion;

        this.PhotoURL = photoURL;

        this.Price = price;

        this.Stock = stock;

        this.Category = category;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductEN t = obj as ProductEN;
        if (t == null)
                return false;
        if (ProductId.Equals (t.ProductId))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.ProductId.GetHashCode ();
        return hash;
}
}
}
