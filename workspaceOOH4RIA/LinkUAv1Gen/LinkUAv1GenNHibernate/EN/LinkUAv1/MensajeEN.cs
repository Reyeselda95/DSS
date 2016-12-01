
using System;
// Definición clase MensajeEN
namespace LinkUAv1GenNHibernate.EN.LinkUAv1
{
public partial class MensajeEN
{
/**
 *	Atributo usuario_5
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_5;



/**
 *	Atributo usuario_6
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_6;



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






public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN Usuario_5 {
        get { return usuario_5; } set { usuario_5 = value;  }
}



public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN Usuario_6 {
        get { return usuario_6; } set { usuario_6 = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}





public MensajeEN()
{
}



public MensajeEN(int id, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_5, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_6, string texto, Nullable<DateTime> fecha
                 )
{
        this.init (Id, usuario_5, usuario_6, texto, fecha);
}


public MensajeEN(MensajeEN mensaje)
{
        this.init (Id, mensaje.Usuario_5, mensaje.Usuario_6, mensaje.Texto, mensaje.Fecha);
}

private void init (int id, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_5, LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_6, string texto, Nullable<DateTime> fecha)
{
        this.Id = id;


        this.Usuario_5 = usuario_5;

        this.Usuario_6 = usuario_6;

        this.Texto = texto;

        this.Fecha = fecha;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MensajeEN t = obj as MensajeEN;
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
