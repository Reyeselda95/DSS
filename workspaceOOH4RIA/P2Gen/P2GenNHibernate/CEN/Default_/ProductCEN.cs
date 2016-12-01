

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
 *      Definition of the class ProductCEN
 *
 */
public partial class ProductCEN
{
private IProductCAD _IProductCAD;

public ProductCEN()
{
        this._IProductCAD = new ProductCAD ();
}

public ProductCEN(IProductCAD _IProductCAD)
{
        this._IProductCAD = _IProductCAD;
}

public IProductCAD get_IProductCAD ()
{
        return this._IProductCAD;
}

public System.Collections.Generic.IList<ProductEN> GetAllProducts (int first, int size)
{
        System.Collections.Generic.IList<ProductEN> list = null;

        list = _IProductCAD.GetAllProducts (first, size);
        return list;
}
public int Create (int p_productId, string p_name, string p_descripcion, string p_photoURL, float p_price, int p_stock)
{
        ProductEN productEN = null;
        int oid;

        //Initialized ProductEN
        productEN = new ProductEN ();
        productEN.ProductId = p_productId;

        productEN.Name = p_name;

        productEN.Descripcion = p_descripcion;

        productEN.PhotoURL = p_photoURL;

        productEN.Price = p_price;

        productEN.Stock = p_stock;

        //Call to ProductCAD

        oid = _IProductCAD.Create (productEN);
        return oid;
}

public void Delete (int productId)
{
        _IProductCAD.Delete (productId);
}

public void Modify (int p_oid, string p_name, string p_descripcion, string p_photoURL, float p_price, int p_stock)
{
        ProductEN productEN = null;

        //Initialized ProductEN
        productEN = new ProductEN ();
        productEN.ProductId = p_oid;
        productEN.Name = p_name;
        productEN.Descripcion = p_descripcion;
        productEN.PhotoURL = p_photoURL;
        productEN.Price = p_price;
        productEN.Stock = p_stock;
        //Call to ProductCAD

        _IProductCAD.Modify (productEN);
}
}
}
