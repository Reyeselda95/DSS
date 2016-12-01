

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
 *      Definition of the class LineaPedidoCEN
 *
 */
public partial class LineaPedidoCEN
{
private ILineaPedidoCAD _ILineaPedidoCAD;

public LineaPedidoCEN()
{
        this._ILineaPedidoCAD = new LineaPedidoCAD ();
}

public LineaPedidoCEN(ILineaPedidoCAD _ILineaPedidoCAD)
{
        this._ILineaPedidoCAD = _ILineaPedidoCAD;
}

public ILineaPedidoCAD get_ILineaPedidoCAD ()
{
        return this._ILineaPedidoCAD;
}

public int CrearLineaPedido (int p_cantidad, int p_numero, int p_pedido, int p_producto)
{
        LineaPedidoEN lineaPedidoEN = null;
        int oid;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Cantidad = p_cantidad;

        lineaPedidoEN.Numero = p_numero;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                lineaPedidoEN.Pedido = new P1GenNHibernate.EN.Práctica1.PedidoEN ();
                lineaPedidoEN.Pedido.PedidoId = p_pedido;
        }


        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids id
                lineaPedidoEN.Producto = new P1GenNHibernate.EN.Práctica1.ProductoEN ();
                lineaPedidoEN.Producto.ProductioId = p_producto;
        }

        //Call to LineaPedidoCAD

        oid = _ILineaPedidoCAD.CrearLineaPedido (lineaPedidoEN);
        return oid;
}

public void ModificarLinea (int p_LineaPedido_OID, int p_cantidad, int p_numero)
{
        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Id = p_LineaPedido_OID;
        lineaPedidoEN.Cantidad = p_cantidad;
        lineaPedidoEN.Numero = p_numero;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.ModificarLinea (lineaPedidoEN);
}
}
}
