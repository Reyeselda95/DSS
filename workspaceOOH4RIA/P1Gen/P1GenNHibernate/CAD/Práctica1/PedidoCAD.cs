
using System;
using System.Text;
using P1GenNHibernate.CEN.Práctica1;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using P1GenNHibernate.EN.Práctica1;
using P1GenNHibernate.Exceptions;

/*
 * Clase Pedido:
 *
 */

namespace P1GenNHibernate.CAD.Práctica1
{
public partial class PedidoCAD : BasicCAD, IPedidoCAD
{
public PedidoCAD() : base ()
{
}

public PedidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PedidoEN ReadOIDDefault (int PedidoId)
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoEN), PedidoId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PedidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PedidoEN>();
                        else
                                result = session.CreateCriteria (typeof(PedidoEN)).List<PedidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }

        return result;
}

public int CrearPedido (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedido.Cliente != null) {
                        // Argumento OID y no colección.
                        pedido.Cliente = (P1GenNHibernate.EN.Práctica1.ClienteEN)session.Load (typeof(P1GenNHibernate.EN.Práctica1.ClienteEN), pedido.Cliente.NIF);

                        pedido.Cliente.Pedido
                        .Add (pedido);
                }

                session.Save (pedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedido.PedidoId;
}

public void ModificarPedido (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), pedido.PedidoId);

                pedidoEN.Fecha = pedido.Fecha;


                pedidoEN.Direccion = pedido.Direccion;


                pedidoEN.Localidad = pedido.Localidad;


                pedidoEN.Provincia = pedido.Provincia;


                pedidoEN.Cp = pedido.Cp;


                pedidoEN.TipoPago = pedido.TipoPago;


                pedidoEN.Estado = pedido.Estado;

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarPedido (int PedidoId)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), PedidoId);
                session.Delete (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: DamePorOID
//Con e: PedidoEN
public PedidoEN DamePorOID (int PedidoId)
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoEN), PedidoId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> DameTodosLosPedidos (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PedidoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PedidoEN>();
                else
                        result = session.CreateCriteria (typeof(PedidoEN)).List<PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AnyadirLineaPedido (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        P1GenNHibernate.EN.Práctica1.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);
                P1GenNHibernate.EN.Práctica1.LineaPedidoEN lineaPedidoENAux = null;
                if (pedidoEN.LineaPedido == null) {
                        pedidoEN.LineaPedido = new System.Collections.Generic.List<P1GenNHibernate.EN.Práctica1.LineaPedidoEN>();
                }

                foreach (int item in p_lineaPedido_OIDs) {
                        lineaPedidoENAux = new P1GenNHibernate.EN.Práctica1.LineaPedidoEN ();
                        lineaPedidoENAux = (P1GenNHibernate.EN.Práctica1.LineaPedidoEN)session.Load (typeof(P1GenNHibernate.EN.Práctica1.LineaPedidoEN), item);
                        lineaPedidoENAux.Pedido = pedidoEN;

                        pedidoEN.LineaPedido.Add (lineaPedidoENAux);
                }


                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void BorrarLineaPedido (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                P1GenNHibernate.EN.Práctica1.PedidoEN pedidoEN = null;
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);

                P1GenNHibernate.EN.Práctica1.LineaPedidoEN lineaPedidoENAux = null;
                if (pedidoEN.LineaPedido != null) {
                        foreach (int item in p_lineaPedido_OIDs) {
                                lineaPedidoENAux = (P1GenNHibernate.EN.Práctica1.LineaPedidoEN)session.Load (typeof(P1GenNHibernate.EN.Práctica1.LineaPedidoEN), item);
                                if (pedidoEN.LineaPedido.Contains (lineaPedidoENAux) == true) {
                                        pedidoEN.LineaPedido.Remove (lineaPedidoENAux);
                                        lineaPedidoENAux.Pedido = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_lineaPedido_OIDs you are trying to unrelationer, doesn't exist in PedidoEN");
                        }
                }

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
