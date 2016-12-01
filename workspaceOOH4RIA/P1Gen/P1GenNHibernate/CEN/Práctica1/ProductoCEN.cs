

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
 *      Definition of the class ProductoCEN
 *
 */
public partial class ProductoCEN
{
private IProductoCAD _IProductoCAD;

public ProductoCEN()
{
        this._IProductoCAD = new ProductoCAD ();
}

public ProductoCEN(IProductoCAD _IProductoCAD)
{
        this._IProductoCAD = _IProductoCAD;
}

public IProductoCAD get_IProductoCAD ()
{
        return this._IProductoCAD;
}

public int Crear (int p_ProductioId, string p_nombre, string p_descripcion, string p_urlFoto, float p_precio, int p_stock, int p_categoria)
{
        ProductoEN productoEN = null;
        int oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.ProductioId = p_ProductioId;

        productoEN.Nombre = p_nombre;

        productoEN.Descripcion = p_descripcion;

        productoEN.UrlFoto = p_urlFoto;

        productoEN.Precio = p_precio;

        productoEN.Stock = p_stock;


        if (p_categoria != -1) {
                // El argumento p_categoria -> Property categoria es oid = false
                // Lista de oids ProductioId
                productoEN.Categoria = new P1GenNHibernate.EN.Práctica1.CategoriaEN ();
                productoEN.Categoria.CategoriaId = p_categoria;
        }

        //Call to ProductoCAD

        oid = _IProductoCAD.Crear (productoEN);
        return oid;
}

public void Modificar (int p_Producto_OID, string p_nombre, string p_descripcion, string p_urlFoto, float p_precio, int p_stock)
{
        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.ProductioId = p_Producto_OID;
        productoEN.Nombre = p_nombre;
        productoEN.Descripcion = p_descripcion;
        productoEN.UrlFoto = p_urlFoto;
        productoEN.Precio = p_precio;
        productoEN.Stock = p_stock;
        //Call to ProductoCAD

        _IProductoCAD.Modificar (productoEN);
}

public void Borrar (int ProductioId)
{
        _IProductoCAD.Borrar (ProductioId);
}

public System.Collections.Generic.IList<ProductoEN> DameTodosLosProductos (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> list = null;

        list = _IProductoCAD.DameTodosLosProductos (first, size);
        return list;
}
}
}
