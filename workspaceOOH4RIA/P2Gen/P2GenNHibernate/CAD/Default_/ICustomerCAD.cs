
using System;
using P2GenNHibernate.EN.Default_;

namespace P2GenNHibernate.CAD.Default_
{
public partial interface ICustomerCAD
{
CustomerEN ReadOIDDefault (string idnumber);


CustomerEN GetCustomerByOID (string idnumber);


string CreateCustomer (CustomerEN customer);

void DeleteCustomer (string idnumber);


void ModifyCustomer (CustomerEN customer);
}
}
