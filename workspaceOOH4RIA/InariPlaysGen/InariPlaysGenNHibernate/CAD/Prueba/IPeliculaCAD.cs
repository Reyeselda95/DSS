
using System;
using InariPlaysGenNHibernate.EN.Prueba;

namespace InariPlaysGenNHibernate.CAD.Prueba
{
public partial interface IPeliculaCAD
{
PeliculaEN ReadOIDDefault (int peliculaId);

int New_ (PeliculaEN pelicula);

void Modify (PeliculaEN pelicula);


void Destroy (int peliculaId);


System.Collections.Generic.IList<PeliculaEN> Damepeliculas (int first, int size);
}
}
