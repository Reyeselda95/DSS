
using System;
using System.Text;
using InariPlaysGenNHibernate.CEN.Prueba;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using InariPlaysGenNHibernate.EN.Prueba;
using InariPlaysGenNHibernate.Exceptions;

namespace InariPlaysGenNHibernate.CAD.Prueba
{
public partial class VideojuegoCAD : BasicCAD, IVideojuegoCAD
{
public VideojuegoCAD() : base ()
{
}

public VideojuegoCAD(ISession sessionAux) : base (sessionAux)
{
}



public VideojuegoEN ReadOIDDefault (int videojuegoId)
{
        VideojuegoEN videojuegoEN = null;

        try
        {
                SessionInitializeTransaction ();
                videojuegoEN = (VideojuegoEN)session.Get (typeof(VideojuegoEN), videojuegoId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in VideojuegoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return videojuegoEN;
}


public int New_ (VideojuegoEN videojuego)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (videojuego);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in VideojuegoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return videojuego.VideojuegoId;
}

public void Modify (VideojuegoEN videojuego)
{
        try
        {
                SessionInitializeTransaction ();
                VideojuegoEN videojuegoEN = (VideojuegoEN)session.Load (typeof(VideojuegoEN), videojuego.VideojuegoId);

                videojuegoEN.Nombre = videojuego.Nombre;


                videojuegoEN.Descripcion = videojuego.Descripcion;


                videojuegoEN.Companyia = videojuego.Companyia;


                videojuegoEN.Precio = videojuego.Precio;


                videojuegoEN.UrlFoto = videojuego.UrlFoto;

                session.Update (videojuegoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in VideojuegoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int videojuegoId)
{
        try
        {
                SessionInitializeTransaction ();
                VideojuegoEN videojuegoEN = (VideojuegoEN)session.Load (typeof(VideojuegoEN), videojuegoId);
                session.Delete (videojuegoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in VideojuegoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<VideojuegoEN> Damevideojuegos (int first, int size)
{
        System.Collections.Generic.IList<VideojuegoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(VideojuegoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<VideojuegoEN>();
                else
                        result = session.CreateCriteria (typeof(VideojuegoEN)).List<VideojuegoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in VideojuegoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
