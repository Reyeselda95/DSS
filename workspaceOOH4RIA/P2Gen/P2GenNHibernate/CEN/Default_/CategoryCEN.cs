

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using P2GenNHibernate.EN.Default_;
using P2GenNHibernate.CAD.Default_;

namespace P2GenNHibernate.CEN.Default_
{
/*
 *      Definition of the class CategoryCEN
 *
 */
public partial class CategoryCEN
{
private ICategoryCAD _ICategoryCAD;

public CategoryCEN()
{
        this._ICategoryCAD = new CategoryCAD ();
}

public CategoryCEN(ICategoryCAD _ICategoryCAD)
{
        this._ICategoryCAD = _ICategoryCAD;
}

public ICategoryCAD get_ICategoryCAD ()
{
        return this._ICategoryCAD;
}

public int Create (int p_categoryId, string p_name, string p_descripcion)
{
        CategoryEN categoryEN = null;
        int oid;

        //Initialized CategoryEN
        categoryEN = new CategoryEN ();
        categoryEN.CategoryId = p_categoryId;

        categoryEN.Name = p_name;

        categoryEN.Descripcion = p_descripcion;

        //Call to CategoryCAD

        oid = _ICategoryCAD.Create (categoryEN);
        return oid;
}

public void Delete (int categoryId)
{
        _ICategoryCAD.Delete (categoryId);
}

public void Modify (int p_oid, string p_name, string p_descripcion)
{
        CategoryEN categoryEN = null;

        //Initialized CategoryEN
        categoryEN = new CategoryEN ();
        categoryEN.CategoryId = p_oid;
        categoryEN.Name = p_name;
        categoryEN.Descripcion = p_descripcion;
        //Call to CategoryCAD

        _ICategoryCAD.Modify (categoryEN);
}
}
}
