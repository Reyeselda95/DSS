
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
public void DecreaseStock (int p_oid, int stockdown)
{
        /*PROTECTED REGION ID(P2GenNHibernate.CEN.Default__Product_decreaseStock) ENABLED START*/

        // Write here your custom code...
    ProductEN producto = _IProductCAD.ReadOIDDefault(p_oid);
    producto.Stock -= stockdown;
    _IProductCAD.Modify(producto);
        throw new NotImplementedException ("Method DecreaseStock() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
