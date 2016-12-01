
using System;
using P1GenNHibernate.EN.Práctica1;

namespace P1GenNHibernate.CAD.Práctica1
{
public partial interface ICategoriaCAD
{
CategoriaEN ReadOIDDefault (int categoriaId);

int Crear (CategoriaEN categoria);

void Modificar (CategoriaEN categoria);


void Borrar (int categoriaId);
}
}
