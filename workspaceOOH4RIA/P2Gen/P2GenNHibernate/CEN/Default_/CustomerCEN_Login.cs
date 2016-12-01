
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
public partial class CustomerCEN
{
public bool Login (string p_oid, string pass)
{
        /*PROTECTED REGION ID(P2GenNHibernate.CEN.Default__Customer_login) ENABLED START*/
    CustomerEN cliente = _ICustomerCAD.GetCustomerByOID(p_oid);
    if (cliente.Password.Equals(pass)) { return true; }
    else { return false; }
        // Write here your custom code...

        throw new NotImplementedException ("Method Login() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
