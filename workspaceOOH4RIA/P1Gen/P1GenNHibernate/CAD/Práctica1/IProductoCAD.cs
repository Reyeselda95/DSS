
using System;
using P1GenNHibernate.EN.Práctica1;

namespace P1GenNHibernate.CAD.Práctica1
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (int ProductioId);

int Crear (ProductoEN producto);

void Modificar (ProductoEN producto);


void Borrar (int ProductioId);


System.Collections.Generic.IList<ProductoEN> DameTodosLosProductos (int first, int size);
}
}
