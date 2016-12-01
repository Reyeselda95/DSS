
using System;
// Definición clase PedidoEN
namespace P1GenNHibernate.EN.Práctica1
{
public partial class PedidoEN
{
/**
 *	Atributo pedidoId
 */
private int pedidoId;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo direccion
 */
private string direccion;



/**
 *	Atributo localidad
 */
private string localidad;



/**
 *	Atributo provincia
 */
private string provincia;



/**
 *	Atributo cp
 */
private string cp;



/**
 *	Atributo tipoPago
 */
private string tipoPago;



/**
 *	Atributo estado
 */
private P1GenNHibernate.Enumerated.Práctica1.EstadoPedidoEnum estado;



/**
 *	Atributo cliente
 */
private P1GenNHibernate.EN.Práctica1.ClienteEN cliente;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.LineaPedidoEN> lineaPedido;






public virtual int PedidoId {
        get { return pedidoId; } set { pedidoId = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}



public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}



public virtual string Cp {
        get { return cp; } set { cp = value;  }
}



public virtual string TipoPago {
        get { return tipoPago; } set { tipoPago = value;  }
}



public virtual P1GenNHibernate.Enumerated.Práctica1.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual P1GenNHibernate.EN.Práctica1.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}





public PedidoEN()
{
        lineaPedido = new System.Collections.Generic.List<P1GenNHibernate.EN.Práctica1.LineaPedidoEN>();
}



public PedidoEN(int pedidoId, Nullable<DateTime> fecha, string direccion, string localidad, string provincia, string cp, string tipoPago, P1GenNHibernate.Enumerated.Práctica1.EstadoPedidoEnum estado, P1GenNHibernate.EN.Práctica1.ClienteEN cliente, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.LineaPedidoEN> lineaPedido
                )
{
        this.init (PedidoId, fecha, direccion, localidad, provincia, cp, tipoPago, estado, cliente, lineaPedido);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (PedidoId, pedido.Fecha, pedido.Direccion, pedido.Localidad, pedido.Provincia, pedido.Cp, pedido.TipoPago, pedido.Estado, pedido.Cliente, pedido.LineaPedido);
}

private void init (int PedidoId, Nullable<DateTime> fecha, string direccion, string localidad, string provincia, string cp, string tipoPago, P1GenNHibernate.Enumerated.Práctica1.EstadoPedidoEnum estado, P1GenNHibernate.EN.Práctica1.ClienteEN cliente, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.LineaPedidoEN> lineaPedido)
{
        this.PedidoId = PedidoId;


        this.Fecha = fecha;

        this.Direccion = direccion;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Cp = cp;

        this.TipoPago = tipoPago;

        this.Estado = estado;

        this.Cliente = cliente;

        this.LineaPedido = lineaPedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
        if (t == null)
                return false;
        if (PedidoId.Equals (t.PedidoId))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.PedidoId.GetHashCode ();
        return hash;
}
}
}
