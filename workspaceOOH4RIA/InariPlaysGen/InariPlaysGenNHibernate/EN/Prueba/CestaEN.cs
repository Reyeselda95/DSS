
using System;

namespace InariPlaysGenNHibernate.EN.Prueba
{
public partial class CestaEN
{
/**
 *
 */

private int iden;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private InariPlaysGenNHibernate.EN.Prueba.ClienteEN cliente;

/**
 *
 */

private System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> producto;

/**
 *
 */

private System.Collections.Generic.IList<string> productos;





public virtual int Iden {
        get { return iden; } set { iden = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual InariPlaysGenNHibernate.EN.Prueba.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}


public virtual System.Collections.Generic.IList<string> Productos {
        get { return productos; } set { productos = value;  }
}





public CestaEN()
{
        producto = new System.Collections.Generic.List<InariPlaysGenNHibernate.EN.Prueba.ProductoEN>();
}



public CestaEN(int iden, Nullable<DateTime> fecha, InariPlaysGenNHibernate.EN.Prueba.ClienteEN cliente, System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> producto, System.Collections.Generic.IList<string> productos)
{
        this.init (iden, fecha, cliente, producto, productos);
}


public CestaEN(CestaEN cesta)
{
        this.init (cesta.Iden, cesta.Fecha, cesta.Cliente, cesta.Producto, cesta.Productos);
}

private void init (int iden, Nullable<DateTime> fecha, InariPlaysGenNHibernate.EN.Prueba.ClienteEN cliente, System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> producto, System.Collections.Generic.IList<string> productos)
{
        this.Iden = Iden;


        this.Fecha = fecha;

        this.Cliente = cliente;

        this.Producto = producto;

        this.Productos = productos;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CestaEN t = obj as CestaEN;
        if (t == null)
                return false;
        if (Iden.Equals (t.Iden))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Iden.GetHashCode ();
        return hash;
}
}
}
