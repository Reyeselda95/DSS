
using System;
// Definición clase ClienteEN
namespace P1GenNHibernate.EN.Práctica1
{
public partial class ClienteEN
{
/**
 *	Atributo nIF
 */
private string nIF;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo password
 */
private string password;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo direccion
 */
private string direccion;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo cp
 */
private string cp;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.PedidoEN> pedido;






public virtual string NIF {
        get { return nIF; } set { nIF = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Password {
        get { return password; } set { password = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual string Cp {
        get { return cp; } set { cp = value;  }
}



public virtual System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}





public ClienteEN()
{
        pedido = new System.Collections.Generic.List<P1GenNHibernate.EN.Práctica1.PedidoEN>();
}



public ClienteEN(string nIF, string nombre, string email, string password, string apellidos, string direccion, string telefono, string cp, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.PedidoEN> pedido
                 )
{
        this.init (NIF, nombre, email, password, apellidos, direccion, telefono, cp, pedido);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (NIF, cliente.Nombre, cliente.Email, cliente.Password, cliente.Apellidos, cliente.Direccion, cliente.Telefono, cliente.Cp, cliente.Pedido);
}

private void init (string NIF, string nombre, string email, string password, string apellidos, string direccion, string telefono, string cp, System.Collections.Generic.IList<P1GenNHibernate.EN.Práctica1.PedidoEN> pedido)
{
        this.NIF = NIF;


        this.Nombre = nombre;

        this.Email = email;

        this.Password = password;

        this.Apellidos = apellidos;

        this.Direccion = direccion;

        this.Telefono = telefono;

        this.Cp = cp;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
        if (t == null)
                return false;
        if (NIF.Equals (t.NIF))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.NIF.GetHashCode ();
        return hash;
}
}
}
