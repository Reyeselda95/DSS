
using System;
using P2GenNHibernate.EN.Default_;

namespace P2GenNHibernate.CAD.Default_
{
public partial interface ICategoryCAD
{
CategoryEN ReadOIDDefault (int categoryId);

int Create (CategoryEN category);

void Delete (int categoryId);


void Modify (CategoryEN category);
}
}
