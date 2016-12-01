
using System;
// Definición clase UsuarioEN
namespace LinkUAv1GenNHibernate.EN.LinkUAv1
{
public partial class UsuarioEN
{
/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo nick
 */
private string nick;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo fnac
 */
private Nullable<DateTime> fnac;



/**
 *	Atributo tfno
 */
private string tfno;



/**
 *	Atributo pass
 */
private string pass;



/**
 *	Atributo comentario_1
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_1;



/**
 *	Atributo publicacion_1
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> publicacion_1;



/**
 *	Atributo estado
 */
private LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum estado;



/**
 *	Atributo publicacion_2
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> publicacion_2;



/**
 *	Atributo comentario_2
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_2;



/**
 *	Atributo titulacion_1
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN titulacion_1;



/**
 *	Atributo material_2
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> material_2;



/**
 *	Atributo mensaje_1
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> mensaje_1;



/**
 *	Atributo mensaje_2
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> mensaje_2;






public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Nick {
        get { return nick; } set { nick = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual Nullable<DateTime> Fnac {
        get { return fnac; } set { fnac = value;  }
}



public virtual string Tfno {
        get { return tfno; } set { tfno = value;  }
}



public virtual string Pass {
        get { return pass; } set { pass = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> Comentario_1 {
        get { return comentario_1; } set { comentario_1 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> Publicacion_1 {
        get { return publicacion_1; } set { publicacion_1 = value;  }
}



public virtual LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> Publicacion_2 {
        get { return publicacion_2; } set { publicacion_2 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> Comentario_2 {
        get { return comentario_2; } set { comentario_2 = value;  }
}



public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN Titulacion_1 {
        get { return titulacion_1; } set { titulacion_1 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> Material_2 {
        get { return material_2; } set { material_2 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> Mensaje_1 {
        get { return mensaje_1; } set { mensaje_1 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> Mensaje_2 {
        get { return mensaje_2; } set { mensaje_2 = value;  }
}





public UsuarioEN()
{
        comentario_1 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN>();
        publicacion_1 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN>();
        publicacion_2 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN>();
        comentario_2 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN>();
        material_2 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN>();
        mensaje_1 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN>();
        mensaje_2 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN>();
}



public UsuarioEN(string email, string nick, string nombre, string apellidos, Nullable<DateTime> fnac, string tfno, string pass, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> publicacion_1, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum estado, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> publicacion_2, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_2, LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN titulacion_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> material_2, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> mensaje_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> mensaje_2
                 )
{
        this.init (Email, nick, nombre, apellidos, fnac, tfno, pass, comentario_1, publicacion_1, estado, publicacion_2, comentario_2, titulacion_1, material_2, mensaje_1, mensaje_2);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Email, usuario.Nick, usuario.Nombre, usuario.Apellidos, usuario.Fnac, usuario.Tfno, usuario.Pass, usuario.Comentario_1, usuario.Publicacion_1, usuario.Estado, usuario.Publicacion_2, usuario.Comentario_2, usuario.Titulacion_1, usuario.Material_2, usuario.Mensaje_1, usuario.Mensaje_2);
}

private void init (string email, string nick, string nombre, string apellidos, Nullable<DateTime> fnac, string tfno, string pass, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> publicacion_1, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum estado, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> publicacion_2, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN> comentario_2, LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN titulacion_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> material_2, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> mensaje_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> mensaje_2)
{
        this.Email = email;


        this.Nick = nick;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Fnac = fnac;

        this.Tfno = tfno;

        this.Pass = pass;

        this.Comentario_1 = comentario_1;

        this.Publicacion_1 = publicacion_1;

        this.Estado = estado;

        this.Publicacion_2 = publicacion_2;

        this.Comentario_2 = comentario_2;

        this.Titulacion_1 = titulacion_1;

        this.Material_2 = material_2;

        this.Mensaje_1 = mensaje_1;

        this.Mensaje_2 = mensaje_2;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Email.Equals (t.Email))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Email.GetHashCode ();
        return hash;
}
}
}
