
using System;
using System.Text;
using LinkUAv1GenNHibernate.CEN.LinkUAv1;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LinkUAv1GenNHibernate.EN.LinkUAv1;
using LinkUAv1GenNHibernate.Exceptions;

/*
 * Clase Titulacion:
 *
 */

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial class TitulacionCAD : BasicCAD, ITitulacionCAD
{
public TitulacionCAD() : base ()
{
}

public TitulacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public TitulacionEN ReadOIDDefault (int id)
{
        TitulacionEN titulacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                titulacionEN = (TitulacionEN)session.Get (typeof(TitulacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in TitulacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return titulacionEN;
}

public System.Collections.Generic.IList<TitulacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TitulacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TitulacionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TitulacionEN>();
                        else
                                result = session.CreateCriteria (typeof(TitulacionEN)).List<TitulacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in TitulacionCAD.", ex);
        }

        return result;
}

public int New_ (TitulacionEN titulacion)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (titulacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in TitulacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return titulacion.Id;
}

public void Modify (TitulacionEN titulacion)
{
        try
        {
                SessionInitializeTransaction ();
                TitulacionEN titulacionEN = (TitulacionEN)session.Load (typeof(TitulacionEN), titulacion.Id);

                titulacionEN.Nombre = titulacion.Nombre;

                session.Update (titulacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in TitulacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id)
{
        try
        {
                SessionInitializeTransaction ();
                TitulacionEN titulacionEN = (TitulacionEN)session.Load (typeof(TitulacionEN), id);
                session.Delete (titulacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in TitulacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Buscar
//Con e: TitulacionEN
public TitulacionEN Buscar (int id)
{
        TitulacionEN titulacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                titulacionEN = (TitulacionEN)session.Get (typeof(TitulacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in TitulacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return titulacionEN;
}

public System.Collections.Generic.IList<TitulacionEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<TitulacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TitulacionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TitulacionEN>();
                else
                        result = session.CreateCriteria (typeof(TitulacionEN)).List<TitulacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in TitulacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
