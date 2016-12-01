
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
 * Clase Customer:
 *
 */

namespace P2GenNHibernate.CAD.Default_
{
public partial class CustomerCAD : BasicCAD, ICustomerCAD
{
public CustomerCAD() : base ()
{
}

public CustomerCAD(ISession sessionAux) : base (sessionAux)
{
}



public CustomerEN ReadOIDDefault (string idnumber)
{
        CustomerEN customerEN = null;

        try
        {
                SessionInitializeTransaction ();
                customerEN = (CustomerEN)session.Get (typeof(CustomerEN), idnumber);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return customerEN;
}

public System.Collections.Generic.IList<CustomerEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CustomerEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CustomerEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CustomerEN>();
                        else
                                result = session.CreateCriteria (typeof(CustomerEN)).List<CustomerEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerCAD.", ex);
        }

        return result;
}

//Sin e: GetCustomerByOID
//Con e: CustomerEN
public CustomerEN GetCustomerByOID (string idnumber)
{
        CustomerEN customerEN = null;

        try
        {
                SessionInitializeTransaction ();
                customerEN = (CustomerEN)session.Get (typeof(CustomerEN), idnumber);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return customerEN;
}

public string CreateCustomer (CustomerEN customer)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (customer);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return customer.Idnumber;
}

public void DeleteCustomer (string idnumber)
{
        try
        {
                SessionInitializeTransaction ();
                CustomerEN customerEN = (CustomerEN)session.Load (typeof(CustomerEN), idnumber);
                session.Delete (customerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void ModifyCustomer (CustomerEN customer)
{
        try
        {
                SessionInitializeTransaction ();
                CustomerEN customerEN = (CustomerEN)session.Load (typeof(CustomerEN), customer.Idnumber);

                customerEN.FirstName = customer.FirstName;


                customerEN.Email = customer.Email;


                customerEN.Password = customer.Password;


                customerEN.LastName = customer.LastName;


                customerEN.Address = customer.Address;


                customerEN.Telephone = customer.Telephone;


                customerEN.Zip = customer.Zip;

                session.Update (customerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is P2GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new P2GenNHibernate.Exceptions.DataLayerException ("Error in CustomerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
