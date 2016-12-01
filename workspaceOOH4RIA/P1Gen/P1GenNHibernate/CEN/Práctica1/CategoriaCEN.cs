

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using P1GenNHibernate.EN.Práctica1;
using P1GenNHibernate.CAD.Práctica1;

namespace P1GenNHibernate.CEN.Práctica1
{
/*
 *      Definition of the class CategoriaCEN
 *
 */
public partial class CategoriaCEN
{
private ICategoriaCAD _ICategoriaCAD;

public CategoriaCEN()
{
        this._ICategoriaCAD = new CategoriaCAD ();
}

public CategoriaCEN(ICategoriaCAD _ICategoriaCAD)
{
        this._ICategoriaCAD = _ICategoriaCAD;
}

public ICategoriaCAD get_ICategoriaCAD ()
{
        return this._ICategoriaCAD;
}

public int Crear (string p_nombre, string p_descripcion)
{
        CategoriaEN categoriaEN = null;
        int oid;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_nombre;

        categoriaEN.Descripcion = p_descripcion;

        //Call to CategoriaCAD

        oid = _ICategoriaCAD.Crear (categoriaEN);
        return oid;
}

public void Modificar (int p_Categoria_OID, string p_nombre, string p_descripcion)
{
        CategoriaEN categoriaEN = null;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.CategoriaId = p_Categoria_OID;
        categoriaEN.Nombre = p_nombre;
        categoriaEN.Descripcion = p_descripcion;
        //Call to CategoriaCAD

        _ICategoriaCAD.Modificar (categoriaEN);
}

public void Borrar (int categoriaId)
{
        _ICategoriaCAD.Borrar (categoriaId);
}
}
}
