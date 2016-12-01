
using System;
// Definición clase CategoriaEN
namespace P1GenNHibernate.EN.Práctica1
{
public partial class CategoriaEN
{
/**
 *	Atributo categoriaId
 */
private int categoriaId;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo subcategoria
 */
private System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.CategoriaEN> subcategoria;



/**
 *	Atributo supercategoria
 */
private P1GenNHibernate.EN.Práctica1.CategoriaEN supercategoria;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.ProductoEN> producto;






public virtual int CategoriaId {
        get { return categoriaId; } set { categoriaId = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.CategoriaEN> Subcategoria {
        get { return subcategoria; } set { subcategoria = value;  }
}



public virtual P1GenNHibernate.EN.Práctica1.CategoriaEN Supercategoria {
        get { return supercategoria; } set { supercategoria = value;  }
}



public virtual System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}





public CategoriaEN()
{
        subcategoria = new System.Collections.Generic.List<P1GenNHibernate.EN.Práctica1.CategoriaEN>();
        producto = new System.Collections.Generic.List<P1GenNHibernate.EN.Práctica1.ProductoEN>();
}



public CategoriaEN(int categoriaId, string nombre, string descripcion, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.CategoriaEN> subcategoria, P1GenNHibernate.EN.Práctica1.CategoriaEN supercategoria, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.ProductoEN> producto
                   )
{
        this.init (CategoriaId, nombre, descripcion, subcategoria, supercategoria, producto);
}


public CategoriaEN(CategoriaEN categoria)
{
        this.init (CategoriaId, categoria.Nombre, categoria.Descripcion, categoria.Subcategoria, categoria.Supercategoria, categoria.Producto);
}

private void init (int categoriaId, string nombre, string descripcion, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.CategoriaEN> subcategoria, P1GenNHibernate.EN.Práctica1.CategoriaEN supercategoria, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.ProductoEN> producto)
{
        this.CategoriaId = categoriaId;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Subcategoria = subcategoria;

        this.Supercategoria = supercategoria;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoriaEN t = obj as CategoriaEN;
        if (t == null)
                return false;
        if (CategoriaId.Equals (t.CategoriaId))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.CategoriaId.GetHashCode ();
        return hash;
}
}
}
