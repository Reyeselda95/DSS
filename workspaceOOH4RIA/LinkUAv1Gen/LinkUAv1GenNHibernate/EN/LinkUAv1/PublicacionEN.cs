
using System;
// Definición clase PublicacionEN
namespace LinkUAv1GenNHibernate.EN.LinkUAv1
{
public partial class PublicacionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo anonimo
 */
private bool anonimo;



/**
 *	Atributo cerrado
 */
private bool cerrado;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo likes
 */
private int likes;



/**
 *	Atributo usuario_1
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_1;



/**
 *	Atributo comentario_3
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_3;



/**
 *	Atributo usuario_3
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_3;



/**
 *	Atributo categoria
 */
private LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum categoria;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual bool Anonimo {
        get { return anonimo; } set { anonimo = value;  }
}



public virtual bool Cerrado {
        get { return cerrado; } set { cerrado = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual int Likes {
        get { return likes; } set { likes = value;  }
}



public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN Usuario_1 {
        get { return usuario_1; } set { usuario_1 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> Comentario_3 {
        get { return comentario_3; } set { comentario_3 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> Usuario_3 {
        get { return usuario_3; } set { usuario_3 = value;  }
}



public virtual LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum Categoria {
        get { return categoria; } set { categoria = value;  }
}





public PublicacionEN()
{
        comentario_3 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN>();
        usuario_3 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN>();
}



public PublicacionEN(int id, string titulo, string texto, bool anonimo, bool cerrado, Nullable<DateTime> fecha, int likes, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_3, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_3, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum categoria
                     )
{
        this.init (Id, titulo, texto, anonimo, cerrado, fecha, likes, usuario_1, comentario_3, usuario_3, categoria);
}


public PublicacionEN(PublicacionEN publicacion)
{
        this.init (Id, publicacion.Titulo, publicacion.Texto, publicacion.Anonimo, publicacion.Cerrado, publicacion.Fecha, publicacion.Likes, publicacion.Usuario_1, publicacion.Comentario_3, publicacion.Usuario_3, publicacion.Categoria);
}

private void init (int id, string titulo, string texto, bool anonimo, bool cerrado, Nullable<DateTime> fecha, int likes, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_3, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_3, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum categoria)
{
        this.Id = id;


        this.Titulo = titulo;

        this.Texto = texto;

        this.Anonimo = anonimo;

        this.Cerrado = cerrado;

        this.Fecha = fecha;

        this.Likes = likes;

        this.Usuario_1 = usuario_1;

        this.Comentario_3 = comentario_3;

        this.Usuario_3 = usuario_3;

        this.Categoria = categoria;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PublicacionEN t = obj as PublicacionEN;
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
