
using System;

namespace InariPlaysGenNHibernate.EN.Prueba
{
public partial class MusicaEN
{
/**
 *
 */

private int musicaId;

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

private int precio;

/**
 *
 */

private string urlFoto;





public virtual int MusicaId {
        get { return musicaId; } set { musicaId = value;  }
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


public virtual int Precio {
        get { return precio; } set { precio = value;  }
}


public virtual string UrlFoto {
        get { return urlFoto; } set { urlFoto = value;  }
}





public MusicaEN()
{
        producto = new System.Collections.Generic.List<InariPlaysGenNHibernate.EN.Prueba.ProductoEN>();
}



public MusicaEN(int musicaId, string nombre, string descripcion, System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> producto, int precio, string urlFoto)
{
        this.init (musicaId, nombre, descripcion, producto, precio, urlFoto);
}


public MusicaEN(MusicaEN musica)
{
        this.init (musica.MusicaId, musica.Nombre, musica.Descripcion, musica.Producto, musica.Precio, musica.UrlFoto);
}

private void init (int musicaId, string nombre, string descripcion, System.Collections.Generic.IList<InariPlaysGenNHibernate.EN.Prueba.ProductoEN> producto, int precio, string urlFoto)
{
        this.MusicaId = musicaId;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Producto = producto;

        this.Precio = precio;

        this.UrlFoto = urlFoto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MusicaEN t = obj as MusicaEN;
        if (t == null)
                return false;
        if (MusicaId.Equals (t.MusicaId))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.MusicaId.GetHashCode ();
        return hash;
}
}
}
