
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
public partial class ProductoCEN
{
public void IncrementarStock (int id, int stockup)
{
        /*PROTECTED REGION ID(P1GenNHibernate.CEN.Práctica1_Producto_incrementarStock) ENABLED START*/
        ProductoEN producto = _IProductoCAD.ReadOIDDefault (id);

        producto.Stock += stockup;
        _IProductoCAD.Modificar (producto);
        // Write here your custom code...

        throw new NotImplementedException ("Method IncrementarStock() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
