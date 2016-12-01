
using System;
// Definición clase LineaPedidoEN
namespace P1GenNHibernate.EN.Práctica1
{
public partial class LineaPedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo numero
 */
private int numero;



/**
 *	Atributo pedido
 */
private P1GenNHibernate.EN.Práctica1.PedidoEN pedido;



/**
 *	Atributo producto
 */
private P1GenNHibernate.EN.Práctica1.ProductoEN producto;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual int Numero {
        get { return numero; } set { numero = value;  }
}



public virtual P1GenNHibernate.EN.Práctica1.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual P1GenNHibernate.EN.Práctica1.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int id, int cantidad, int numero, P1GenNHibernate.EN.Práctica1.PedidoEN pedido, P1GenNHibernate.EN.Práctica1.ProductoEN producto
                     )
{
        this.init (Id, cantidad, numero, pedido, producto);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (Id, lineaPedido.Cantidad, lineaPedido.Numero, lineaPedido.Pedido, lineaPedido.Producto);
}

private void init (int id, int cantidad, int numero, P1GenNHibernate.EN.Práctica1.PedidoEN pedido, P1GenNHibernate.EN.Práctica1.ProductoEN producto)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Numero = numero;

        this.Pedido = pedido;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
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
