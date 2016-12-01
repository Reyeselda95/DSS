
using System;
// Definición clase ProductoEN
namespace P1GenNHibernate.EN.Práctica1
{
public partial class ProductoEN
{
/**
 *	Atributo productioId
 */
private int productioId;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo urlFoto
 */
private string urlFoto;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo stock
 */
private int stock;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.LineaPedidoEN> lineaPedido;



/**
 *	Atributo categoria
 */
private P1GenNHibernate.EN.Práctica1.CategoriaEN categoria;






public virtual int ProductioId {
        get { return productioId; } set { productioId = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string UrlFoto {
        get { return urlFoto; } set { urlFoto = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}



public virtual System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual P1GenNHibernate.EN.Práctica1.CategoriaEN Categoria {
        get { return categoria; } set { categoria = value;  }
}





public ProductoEN()
{
        lineaPedido = new System.Collections.Generic.List<P1GenNHibernate.EN.Práctica1.LineaPedidoEN>();
}



public ProductoEN(int productioId, string nombre, string descripcion, string urlFoto, float precio, int stock, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.LineaPedidoEN> lineaPedido, P1GenNHibernate.EN.Práctica1.CategoriaEN categoria
                  )
{
        this.init (ProductioId, nombre, descripcion, urlFoto, precio, stock, lineaPedido, categoria);
}


public ProductoEN(ProductoEN producto)
{
        this.init (ProductioId, producto.Nombre, producto.Descripcion, producto.UrlFoto, producto.Precio, producto.Stock, producto.LineaPedido, producto.Categoria);
}

private void init (int ProductioId, string nombre, string descripcion, string urlFoto, float precio, int stock, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.LineaPedidoEN> lineaPedido, P1GenNHibernate.EN.Práctica1.CategoriaEN categoria)
{
        this.ProductioId = ProductioId;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.UrlFoto = urlFoto;

        this.Precio = precio;

        this.Stock = stock;

        this.LineaPedido = lineaPedido;

        this.Categoria = categoria;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
        if (t == null)
                return false;
        if (ProductioId.Equals (t.ProductioId))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.ProductioId.GetHashCode ();
        return hash;
}
}
}
