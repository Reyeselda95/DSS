

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
 *      Definition of the class PedidoCEN
 *
 */
public partial class PedidoCEN
{
private IPedidoCAD _IPedidoCAD;

public PedidoCEN()
{
        this._IPedidoCAD = new PedidoCAD ();
}

public PedidoCEN(IPedidoCAD _IPedidoCAD)
{
        this._IPedidoCAD = _IPedidoCAD;
}

public IPedidoCAD get_IPedidoCAD ()
{
        return this._IPedidoCAD;
}

public int CrearPedido (int p_PedidoId, Nullable<DateTime> p_fecha, string p_direccion, string p_localidad, string p_provincia, string p_cp, string p_tipoPago, P1GenNHibernate.Enumerated.Práctica1.EstadoPedidoEnum p_Estado, string p_cliente)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.PedidoId = p_PedidoId;

        pedidoEN.Fecha = p_fecha;

        pedidoEN.Direccion = p_direccion;

        pedidoEN.Localidad = p_localidad;

        pedidoEN.Provincia = p_provincia;

        pedidoEN.Cp = p_cp;

        pedidoEN.TipoPago = p_tipoPago;

        pedidoEN.Estado = p_Estado;


        if (p_cliente != null) {
                // El argumento p_cliente -> Property cliente es oid = false
                // Lista de oids PedidoId
                pedidoEN.Cliente = new P1GenNHibernate.EN.Práctica1.ClienteEN ();
                pedidoEN.Cliente.NIF = p_cliente;
        }

        //Call to PedidoCAD

        oid = _IPedidoCAD.CrearPedido (pedidoEN);
        return oid;
}

public void ModificarPedido (int p_Pedido_OID, Nullable<DateTime> p_fecha, string p_direccion, string p_localidad, string p_provincia, string p_cp, string p_tipoPago, P1GenNHibernate.Enumerated.Práctica1.EstadoPedidoEnum p_Estado)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.PedidoId = p_Pedido_OID;
        pedidoEN.Fecha = p_fecha;
        pedidoEN.Direccion = p_direccion;
        pedidoEN.Localidad = p_localidad;
        pedidoEN.Provincia = p_provincia;
        pedidoEN.Cp = p_cp;
        pedidoEN.TipoPago = p_tipoPago;
        pedidoEN.Estado = p_Estado;
        //Call to PedidoCAD

        _IPedidoCAD.ModificarPedido (pedidoEN);
}

public void BorrarPedido (int PedidoId)
{
        _IPedidoCAD.BorrarPedido (PedidoId);
}

public PedidoEN DamePorOID (int PedidoId)
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoCAD.DamePorOID (PedidoId);
        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> DameTodosLosPedidos (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> list = null;

        list = _IPedidoCAD.DameTodosLosPedidos (first, size);
        return list;
}
public void AnyadirLineaPedido (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        //Call to PedidoCAD

        _IPedidoCAD.AnyadirLineaPedido (p_Pedido_OID, p_lineaPedido_OIDs);
}
public void BorrarLineaPedido (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        //Call to PedidoCAD

        _IPedidoCAD.BorrarLineaPedido (p_Pedido_OID, p_lineaPedido_OIDs);
}
}
}
