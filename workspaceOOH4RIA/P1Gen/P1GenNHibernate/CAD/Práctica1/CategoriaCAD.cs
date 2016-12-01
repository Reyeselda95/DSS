
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
 * Clase Categoria:
 *
 */

namespace P1GenNHibernate.CAD.Práctica1
{
public partial class CategoriaCAD : BasicCAD, ICategoriaCAD
{
public CategoriaCAD() : base ()
{
}

public CategoriaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CategoriaEN ReadOIDDefault (int categoriaId)
{
        CategoriaEN categoriaEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoriaEN = (CategoriaEN)session.Get (typeof(CategoriaEN), categoriaId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoriaEN;
}

public System.Collections.Generic.IList<CategoriaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CategoriaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CategoriaEN>();
                        else
                                result = session.CreateCriteria (typeof(CategoriaEN)).List<CategoriaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }

        return result;
}

public int Crear (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (categoria);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoria.CategoriaId;
}

public void Modificar (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaEN categoriaEN = (CategoriaEN)session.Load (typeof(CategoriaEN), categoria.CategoriaId);

                categoriaEN.Nombre = categoria.Nombre;


                categoriaEN.Descripcion = categoria.Descripcion;

                session.Update (categoriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Borrar (int categoriaId)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaEN categoriaEN = (CategoriaEN)session.Load (typeof(CategoriaEN), categoriaId);
                session.Delete (categoriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P1GenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
