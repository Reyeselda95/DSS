
using System;
using InariPlaysGenNHibernate.EN.Prueba;

namespace InariPlaysGenNHibernate.CAD.Prueba
{
public partial interface IVideojuegoCAD
{
VideojuegoEN ReadOIDDefault (int videojuegoId);

int New_ (VideojuegoEN videojuego);

void Modify (VideojuegoEN videojuego);


void Destroy (int videojuegoId);


System.Collections.Generic.IList<VideojuegoEN> Damevideojuegos (int first, int size);
}
}
