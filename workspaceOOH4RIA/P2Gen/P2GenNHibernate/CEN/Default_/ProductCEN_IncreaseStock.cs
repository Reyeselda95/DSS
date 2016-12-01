
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
public partial class ProductCEN
{
public void IncreaseStock (int p_oid, int stockup)
{
        /*PROTECTED REGION ID(P2GenNHibernate.CEN.Default__Product_increaseStock) ENABLED START*/
    ProductEN producto = _IProductCAD.ReadOIDDefault(p_oid);
    producto.Stock += stockup;
    _IProductCAD.Modify(producto);
        // Write here your custom code...

        throw new NotImplementedException ("Method IncreaseStock() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
