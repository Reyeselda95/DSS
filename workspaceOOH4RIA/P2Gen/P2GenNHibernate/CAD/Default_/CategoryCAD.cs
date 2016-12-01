
using System;
using System.Text;
using P2GenNHibernate.CEN.Default_;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using P2GenNHibernate.EN.Default_;
using P2GenNHibernate.Exceptions;

/*
 * Clase Category:
 *
 */

namespace P2GenNHibernate.CAD.Default_
{
public partial class CategoryCAD : BasicCAD, ICategoryCAD
{
public CategoryCAD() : base ()
{
}

public CategoryCAD(ISession sessionAux) : base (sessionAux)
{
}



public CategoryEN ReadOIDDefault (int categoryId)
{
        CategoryEN categoryEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoryEN = (CategoryEN)session.Get (typeof(CategoryEN), categoryId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoryEN;
}

public System.Collections.Generic.IList<CategoryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CategoryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CategoryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CategoryEN>();
                        else
                                result = session.CreateCriteria (typeof(CategoryEN)).List<CategoryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CategoryCAD.", ex);
        }

        return result;
}

public int Create (CategoryEN category)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (category);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return category.CategoryId;
}

public void Delete (int categoryId)
{
        try
        {
                SessionInitializeTransaction ();
                CategoryEN categoryEN = (CategoryEN)session.Load (typeof(CategoryEN), categoryId);
                session.Delete (categoryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Modify (CategoryEN category)
{
        try
        {
                SessionInitializeTransaction ();
                CategoryEN categoryEN = (CategoryEN)session.Load (typeof(CategoryEN), category.CategoryId);

                categoryEN.Name = category.Name;


                categoryEN.Descripcion = category.Descripcion;

                session.Update (categoryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
