
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
public partial class MusicaCAD : BasicCAD, IMusicaCAD
{
public MusicaCAD() : base ()
{
}

public MusicaCAD(ISession sessionAux) : base (sessionAux)
{
}



public MusicaEN ReadOIDDefault (int musicaId)
{
        MusicaEN musicaEN = null;

        try
        {
                SessionInitializeTransaction ();
                musicaEN = (MusicaEN)session.Get (typeof(MusicaEN), musicaId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return musicaEN;
}


public int New_ (MusicaEN musica)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (musica);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return musica.MusicaId;
}

public void Modify (MusicaEN musica)
{
        try
        {
                SessionInitializeTransaction ();
                MusicaEN musicaEN = (MusicaEN)session.Load (typeof(MusicaEN), musica.MusicaId);

                musicaEN.Nombre = musica.Nombre;


                musicaEN.Descripcion = musica.Descripcion;


                musicaEN.Precio = musica.Precio;


                musicaEN.UrlFoto = musica.UrlFoto;

                session.Update (musicaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int musicaId)
{
        try
        {
                SessionInitializeTransaction ();
                MusicaEN musicaEN = (MusicaEN)session.Load (typeof(MusicaEN), musicaId);
                session.Delete (musicaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<MusicaEN> Damemusica (int first, int size)
{
        System.Collections.Generic.IList<MusicaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MusicaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MusicaEN>();
                else
                        result = session.CreateCriteria (typeof(MusicaEN)).List<MusicaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InariPlaysGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InariPlaysGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
