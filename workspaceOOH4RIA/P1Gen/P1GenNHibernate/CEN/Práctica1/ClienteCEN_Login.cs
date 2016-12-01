
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using P1GenNHibernate.EN.Práctica1;
using P1GenNHibernate.CAD.Práctica1;

namespace P1GenNHibernate.CEN.Práctica1
{
public partial class ClienteCEN
{
public bool Login (string nIF, string pass)
{
        /*PROTECTED REGION ID(P1GenNHibernate.CEN.Práctica1_Cliente_login) ENABLED START*/
        ClienteEN cliente = _IClienteCAD.DameClientePorOID (nIF);

        if (cliente.Password.Equals (pass)) {
                return true;
        }
        else { return false; }
        // Write here your custom code...

        throw new NotImplementedException ("Method Login() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
