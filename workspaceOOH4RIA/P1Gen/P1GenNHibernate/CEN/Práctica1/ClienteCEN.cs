

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
/*
 *      Definition of the class ClienteCEN
 *
 */
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string CrearCliente (string p_NIF, string p_nombre, string p_email, string p_password, string p_apellidos, string p_direccion, string p_telefono, string p_cp)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.NIF = p_NIF;

        clienteEN.Nombre = p_nombre;

        clienteEN.Email = p_email;

        clienteEN.Password = p_password;

        clienteEN.Apellidos = p_apellidos;

        clienteEN.Direccion = p_direccion;

        clienteEN.Telefono = p_telefono;

        clienteEN.Cp = p_cp;

        //Call to ClienteCAD

        oid = _IClienteCAD.CrearCliente (clienteEN);
        return oid;
}

public void ModificarCliente (string p_Cliente_OID, string p_nombre, string p_email, string p_password, string p_apellidos, string p_direccion, string p_telefono, string p_cp)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.NIF = p_Cliente_OID;
        clienteEN.Nombre = p_nombre;
        clienteEN.Email = p_email;
        clienteEN.Password = p_password;
        clienteEN.Apellidos = p_apellidos;
        clienteEN.Direccion = p_direccion;
        clienteEN.Telefono = p_telefono;
        clienteEN.Cp = p_cp;
        //Call to ClienteCAD

        _IClienteCAD.ModificarCliente (clienteEN);
}

public void BorrarCliente (string NIF)
{
        _IClienteCAD.BorrarCliente (NIF);
}

public ClienteEN DameClientePorOID (string NIF)
{
        ClienteEN clienteEN = null;

        clienteEN = _IClienteCAD.DameClientePorOID (NIF);
        return clienteEN;
}
}
}
