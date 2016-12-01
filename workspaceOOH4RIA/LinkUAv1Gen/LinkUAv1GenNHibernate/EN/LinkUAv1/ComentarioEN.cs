
using System;
// Definición clase ComentarioEN
namespace LinkUAv1GenNHibernate.EN.LinkUAv1
{
public partial class ComentarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo likes
 */
private int likes;



/**
 *	Atributo usuario_2
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_2;



/**
 *	Atributo publicacion_3
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN publicacion_3;



/**
 *	Atributo usuario_4
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_4;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual int Likes {
        get { return likes; } set { likes = value;  }
}



public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN Usuario_2 {
        get { return usuario_2; } set { usuario_2 = value;  }
}



public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN Publicacion_3 {
        get { return publicacion_3; } set { publicacion_3 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> Usuario_4 {
        get { return usuario_4; } set { usuario_4 = value;  }
}





public ComentarioEN()
{
        usuario_4 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN>();
}



public ComentarioEN(int id, string texto, Nullable<DateTime> fecha, int likes, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_2, LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN publicacion_3, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_4
                    )
{
        this.init (Id, texto, fecha, likes, usuario_2, publicacion_3, usuario_4);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Texto, comentario.Fecha, comentario.Likes, comentario.Usuario_2, comentario.Publicacion_3, comentario.Usuario_4);
}

private void init (int id, string texto, Nullable<DateTime> fecha, int likes, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_2, LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN publicacion_3, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_4)
{
        this.Id = id;


        this.Texto = texto;

        this.Fecha = fecha;

        this.Likes = likes;

        this.Usuario_2 = usuario_2;

        this.Publicacion_3 = publicacion_3;

        this.Usuario_4 = usuario_4;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
