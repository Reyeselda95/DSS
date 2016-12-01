
using System;
// Definición clase TitulacionEN
namespace LinkUAv1GenNHibernate.EN.LinkUAv1
{
public partial class TitulacionEN
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
 *	Atributo asignatura_1
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN> asignatura_1;



/**
 *	Atributo usuario_7
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_7;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN> Asignatura_1 {
        get { return asignatura_1; } set { asignatura_1 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> Usuario_7 {
        get { return usuario_7; } set { usuario_7 = value;  }
}





public TitulacionEN()
{
        asignatura_1 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN>();
        usuario_7 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN>();
}



public TitulacionEN(int id, string nombre, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN> asignatura_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_7
                    )
{
        this.init (Id, nombre, asignatura_1, usuario_7);
}


public TitulacionEN(TitulacionEN titulacion)
{
        this.init (Id, titulacion.Nombre, titulacion.Asignatura_1, titulacion.Usuario_7);
}

private void init (int id, string nombre, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN> asignatura_1, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> usuario_7)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Asignatura_1 = asignatura_1;

        this.Usuario_7 = usuario_7;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TitulacionEN t = obj as TitulacionEN;
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
