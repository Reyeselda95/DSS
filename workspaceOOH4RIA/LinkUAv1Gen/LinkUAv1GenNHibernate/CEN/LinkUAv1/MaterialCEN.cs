

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
 *      Definition of the class MaterialCEN
 *
 */
public partial class MaterialCEN
{
private IMaterialCAD _IMaterialCAD;

public MaterialCEN()
{
        this._IMaterialCAD = new MaterialCAD ();
}

public MaterialCEN(IMaterialCAD _IMaterialCAD)
{
        this._IMaterialCAD = _IMaterialCAD;
}

public IMaterialCAD get_IMaterialCAD ()
{
        return this._IMaterialCAD;
}

public int New_ (string p_nombre, string p_descripcion, string p_url, int p_descargas, int p_asignatura_2, string p_usuario_8)
{
        MaterialEN materialEN = null;
        int oid;

        //Initialized MaterialEN
        materialEN = new MaterialEN ();
        materialEN.Nombre = p_nombre;

        materialEN.Descripcion = p_descripcion;

        materialEN.Url = p_url;

        materialEN.Descargas = p_descargas;


        if (p_asignatura_2 != -1) {
                // El argumento p_asignatura_2 -> Property asignatura_2 es oid = false
                // Lista de oids id
                materialEN.Asignatura_2 = new LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN ();
                materialEN.Asignatura_2.Id = p_asignatura_2;
        }


        if (p_usuario_8 != null) {
                // El argumento p_usuario_8 -> Property usuario_8 es oid = false
                // Lista de oids id
                materialEN.Usuario_8 = new LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN ();
                materialEN.Usuario_8.Email = p_usuario_8;
        }

        //Call to MaterialCAD

        oid = _IMaterialCAD.New_ (materialEN);
        return oid;
}

public void Modify (int p_Material_OID, string p_nombre, string p_descripcion, string p_url, int p_descargas)
{
        MaterialEN materialEN = null;

        //Initialized MaterialEN
        materialEN = new MaterialEN ();
        materialEN.Id = p_Material_OID;
        materialEN.Nombre = p_nombre;
        materialEN.Descripcion = p_descripcion;
        materialEN.Url = p_url;
        materialEN.Descargas = p_descargas;
        //Call to MaterialCAD

        _IMaterialCAD.Modify (materialEN);
}

public void Destroy (int id)
{
        _IMaterialCAD.Destroy (id);
}

public MaterialEN Buscar (int id)
{
        MaterialEN materialEN = null;

        materialEN = _IMaterialCAD.Buscar (id);
        return materialEN;
}

public System.Collections.Generic.IList<MaterialEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<MaterialEN> list = null;

        list = _IMaterialCAD.Listar (first, size);
        return list;
}
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> Por_asignatura (int p_asignatura)
{
        return _IMaterialCAD.Por_asignatura (p_asignatura);
}
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> Por_usuario (string p_usuario)
{
        return _IMaterialCAD.Por_usuario (p_usuario);
}
}
}
