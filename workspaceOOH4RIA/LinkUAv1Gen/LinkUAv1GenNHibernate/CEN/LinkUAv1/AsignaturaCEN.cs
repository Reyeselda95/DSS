

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using LinkUAv1GenNHibernate.EN.LinkUAv1;
using LinkUAv1GenNHibernate.CAD.LinkUAv1;

namespace LinkUAv1GenNHibernate.CEN.LinkUAv1
{
/*
 *      Definition of the class AsignaturaCEN
 *
 */
public partial class AsignaturaCEN
{
private IAsignaturaCAD _IAsignaturaCAD;

public AsignaturaCEN()
{
        this._IAsignaturaCAD = new AsignaturaCAD ();
}

public AsignaturaCEN(IAsignaturaCAD _IAsignaturaCAD)
{
        this._IAsignaturaCAD = _IAsignaturaCAD;
}

public IAsignaturaCAD get_IAsignaturaCAD ()
{
        return this._IAsignaturaCAD;
}

public int New_ (string p_nombre, int p_curso, int p_titulacion_2)
{
        AsignaturaEN asignaturaEN = null;
        int oid;

        //Initialized AsignaturaEN
        asignaturaEN = new AsignaturaEN ();
        asignaturaEN.Nombre = p_nombre;

        asignaturaEN.Curso = p_curso;


        if (p_titulacion_2 != -1) {
                // El argumento p_titulacion_2 -> Property titulacion_2 es oid = false
                // Lista de oids id
                asignaturaEN.Titulacion_2 = new LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN ();
                asignaturaEN.Titulacion_2.Id = p_titulacion_2;
        }

        //Call to AsignaturaCAD

        oid = _IAsignaturaCAD.New_ (asignaturaEN);
        return oid;
}

public void Modify (int p_Asignatura_OID, string p_nombre, int p_curso)
{
        AsignaturaEN asignaturaEN = null;

        //Initialized AsignaturaEN
        asignaturaEN = new AsignaturaEN ();
        asignaturaEN.Id = p_Asignatura_OID;
        asignaturaEN.Nombre = p_nombre;
        asignaturaEN.Curso = p_curso;
        //Call to AsignaturaCAD

        _IAsignaturaCAD.Modify (asignaturaEN);
}

public void Destroy (int id)
{
        _IAsignaturaCAD.Destroy (id);
}

public AsignaturaEN Buscar (int id)
{
        AsignaturaEN asignaturaEN = null;

        asignaturaEN = _IAsignaturaCAD.Buscar (id);
        return asignaturaEN;
}

public System.Collections.Generic.IList<AsignaturaEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<AsignaturaEN> list = null;

        list = _IAsignaturaCAD.Listar (first, size);
        return list;
}
}
}
