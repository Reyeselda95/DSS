
using System;
// Definición clase MaterialEN
namespace LinkUAv1GenNHibernate.EN.LinkUAv1
{
public partial class MaterialEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo url
 */
private string url;



/**
 *	Atributo descargas
 */
private int descargas;



/**
 *	Atributo asignatura_2
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN asignatura_2;



/**
 *	Atributo usuario_8
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_8;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Url {
        get { return url; } set { url = value;  }
}



public virtual int Descargas {
        get { return descargas; } set { descargas = value;  }
}



public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN Asignatura_2 {
        get { return asignatura_2; } set { asignatura_2 = value;  }
}



public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN Usuario_8 {
        get { return usuario_8; } set { usuario_8 = value;  }
}





public MaterialEN()
{
}



public MaterialEN(int id, string nombre, string descripcion, string url, int descargas, LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN asignatura_2, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_8
                  )
{
        this.init (Id, nombre, descripcion, url, descargas, asignatura_2, usuario_8);
}


public MaterialEN(MaterialEN material)
{
        this.init (Id, material.Nombre, material.Descripcion, material.Url, material.Descargas, material.Asignatura_2, material.Usuario_8);
}

private void init (int id, string nombre, string descripcion, string url, int descargas, LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN asignatura_2, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_8)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Url = url;

        this.Descargas = descargas;

        this.Asignatura_2 = asignatura_2;

        this.Usuario_8 = usuario_8;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MaterialEN t = obj as MaterialEN;
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
