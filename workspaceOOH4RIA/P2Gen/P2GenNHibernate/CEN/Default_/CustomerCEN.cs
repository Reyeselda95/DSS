

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using P2GenNHibernate.EN.Default_;
using P2GenNHibernate.CAD.Default_;

namespace P2GenNHibernate.CEN.Default_
{
/*
 *      Definition of the class CustomerCEN
 *
 */
public partial class CustomerCEN
{
private ICustomerCAD _ICustomerCAD;

public CustomerCEN()
{
        this._ICustomerCAD = new CustomerCAD ();
}

public CustomerCEN(ICustomerCAD _ICustomerCAD)
{
        this._ICustomerCAD = _ICustomerCAD;
}

public ICustomerCAD get_ICustomerCAD ()
{
        return this._ICustomerCAD;
}

public CustomerEN GetCustomerByOID (string idnumber)
{
        CustomerEN customerEN = null;

        customerEN = _ICustomerCAD.GetCustomerByOID (idnumber);
        return customerEN;
}

public string CreateCustomer (string p_idnumber, string p_firstName, string p_email, string p_password, string p_lastName, string p_address, string p_telephone, string p_zip)
{
        CustomerEN customerEN = null;
        string oid;

        //Initialized CustomerEN
        customerEN = new CustomerEN ();
        customerEN.Idnumber = p_idnumber;

        customerEN.FirstName = p_firstName;

        customerEN.Email = p_email;

        customerEN.Password = p_password;

        customerEN.LastName = p_lastName;

        customerEN.Address = p_address;

        customerEN.Telephone = p_telephone;

        customerEN.Zip = p_zip;

        //Call to CustomerCAD

        oid = _ICustomerCAD.CreateCustomer (customerEN);
        return oid;
}

public void DeleteCustomer (string idnumber)
{
        _ICustomerCAD.DeleteCustomer (idnumber);
}

public void ModifyCustomer (string p_oid, string p_firstName, string p_email, string p_password, string p_lastName, string p_address, string p_telephone, string p_zip)
{
        CustomerEN customerEN = null;

        //Initialized CustomerEN
        customerEN = new CustomerEN ();
        customerEN.Idnumber = p_oid;
        customerEN.FirstName = p_firstName;
        customerEN.Email = p_email;
        customerEN.Password = p_password;
        customerEN.LastName = p_lastName;
        customerEN.Address = p_address;
        customerEN.Telephone = p_telephone;
        customerEN.Zip = p_zip;
        //Call to CustomerCAD

        _ICustomerCAD.ModifyCustomer (customerEN);
}
}
}
