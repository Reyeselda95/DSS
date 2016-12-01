
using System;

namespace InariPlaysGenNHibernate.EN.Prueba
{
public partial class VideojuegoEN
{
/**
 *
 */

private int videojuegoId;

/**
 *
 */

private string nombre;

/**
 *
 */

private string descripcion;

/**
 *
 */

private System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> producto;

/**
 *
 */

private string companyia;

/**
 *
 */

private int precio;

/**
 *
 */

private string urlFoto;





public virtual int VideojuegoId {
        get { return videojuegoId; } set { videojuegoId = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}


public virtual string Companyia {
        get { return companyia; } set { companyia = value;  }
}


public virtual int Precio {
        get { return precio; } set { precio = value;  }
}


public virtual string UrlFoto {
        get { return urlFoto; } set { urlFoto = value;  }
}





public VideojuegoEN()
{
        producto = new System.Collections.Generic.List<InariPlaysGenNHibernate.EN.Prueba.ProductoEN>();
}



public VideojuegoEN(int videojuegoId, string nombre, string descripcion, System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> producto, string companyia, int precio, string urlFoto)
{
        this.init (videojuegoId, nombre, descripcion, producto, companyia, precio, urlFoto);
}


public VideojuegoEN(VideojuegoEN videojuego)
{
        this.init (videojuego.VideojuegoId, videojuego.Nombre, videojuego.Descripcion, videojuego.Producto, videojuego.Companyia, videojuego.Precio, videojuego.UrlFoto);
}

private void init (int videojuegoId, string nombre, string descripcion, System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> producto, string companyia, int precio, string urlFoto)
{
        this.VideojuegoId = videojuegoId;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Producto = producto;

        this.Companyia = companyia;

        this.Precio = precio;

        this.UrlFoto = urlFoto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VideojuegoEN t = obj as VideojuegoEN;
        if (t == null)
                return false;
        if (VideojuegoId.Equals (t.VideojuegoId))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.VideojuegoId.GetHashCode ();
        return hash;
}
}
}
