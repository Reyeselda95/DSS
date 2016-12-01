
using System;
using P2GenNHibernate.EN.Default_;

namespace P2GenNHibernate.CAD.Default_
{
public partial interface IProductCAD
{
ProductEN ReadOIDDefault (int productId);



System.Collections.Generic.IList<ProductEN> GetAllProducts (int first, int size);


int Create (ProductEN product);

void Delete (int productId);


void Modify (ProductEN product);
}
}
