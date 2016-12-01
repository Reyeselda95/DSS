
using System;
// Definición clase AsignaturaEN
namespace LinkUAv1GenNHibernate.EN.LinkUAv1
{
public partial class AsignaturaEN
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
 *	Atributo curso
 */
private int curso;



/**
 *	Atributo titulacion_2
 */
private LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN titulacion_2;



/**
 *	Atributo material_1
 */
private System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> material_1;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Curso {
        get { return curso; } set { curso = value;  }
}



public virtual LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN Titulacion_2 {
        get { return titulacion_2; } set { titulacion_2 = value;  }
}



public virtual System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> Material_1 {
        get { return material_1; } set { material_1 = value;  }
}





public AsignaturaEN()
{
        material_1 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN>();
}



public AsignaturaEN(int id, string nombre, int curso, LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN titulacion_2, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> material_1
                    )
{
        this.init (Id, nombre, curso, titulacion_2, material_1);
}


public AsignaturaEN(AsignaturaEN asignatura)
{
        this.init (Id, asignatura.Nombre, asignatura.Curso, asignatura.Titulacion_2, asignatura.Material_1);
}

private void init (int id, string nombre, int curso, LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN titulacion_2, System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> material_1)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Curso = curso;

        this.Titulacion_2 = titulacion_2;

        this.Material_1 = material_1;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AsignaturaEN t = obj as AsignaturaEN;
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
