
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
 * Clase Product:
 *
 */

namespace P2GenNHibernate.CAD.Default_
{
public partial class ProductCAD : BasicCAD, IProductCAD
{
public ProductCAD() : base ()
{
}

public ProductCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProductEN ReadOIDDefault (int productId)
{
        ProductEN productEN = null;

        try
        {
                SessionInitializeTransaction ();
                productEN = (ProductEN)session.Get (typeof(ProductEN), productId);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in ProductCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productEN;
}

public System.Collections.Generic.IList<ProductEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ProductEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProductEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProductEN>();
                        else
                                result = session.CreateCriteria (typeof(ProductEN)).List<ProductEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in ProductCAD.", ex);
        }

        return result;
}

public System.Collections.Generic.IList<ProductEN> GetAllProducts (int first, int size)
{
        System.Collections.Generic.IList<ProductEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProductEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProductEN>();
                else
                        result = session.CreateCriteria (typeof(ProductEN)).List<ProductEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in ProductCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public int Create (ProductEN product)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (product);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in ProductCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return product.ProductId;
}

public void Delete (int productId)
{
        try
        {
                SessionInitializeTransaction ();
                ProductEN productEN = (ProductEN)session.Load (typeof(ProductEN), productId);
                session.Delete (productEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in ProductCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Modify (ProductEN product)
{
        try
        {
                SessionInitializeTransaction ();
                ProductEN productEN = (ProductEN)session.Load (typeof(ProductEN), product.ProductId);

                productEN.Name = product.Name;


                productEN.Descripcion = product.Descripcion;


                productEN.PhotoURL = product.PhotoURL;


                productEN.Price = product.Price;


                productEN.Stock = product.Stock;

                session.Update (productEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in ProductCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
