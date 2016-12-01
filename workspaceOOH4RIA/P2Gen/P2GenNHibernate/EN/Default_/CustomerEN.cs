
using System;
// Definición clase CustomerEN
namespace P2GenNHibernate.EN.Default_
{
public partial class CustomerEN
{
/**
 *	Atributo idnumber
 */
private string idnumber;



/**
 *	Atributo firstName
 */
private string firstName;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo password
 */
private string password;



/**
 *	Atributo lastName
 */
private string lastName;



/**
 *	Atributo address
 */
private string address;



/**
 *	Atributo telephone
 */
private string telephone;



/**
 *	Atributo zip
 */
private string zip;



/**
 *	Atributo order
 */
private System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.CustomerOrderEN> order;






public virtual string Idnumber {
        get { return idnumber; } set { idnumber = value;  }
}



public virtual string FirstName {
        get { return firstName; } set { firstName = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Password {
        get { return password; } set { password = value;  }
}



public virtual string LastName {
        get { return lastName; } set { lastName = value;  }
}



public virtual string Address {
        get { return address; } set { address = value;  }
}



public virtual string Telephone {
        get { return telephone; } set { telephone = value;  }
}



public virtual string Zip {
        get { return zip; } set { zip = value;  }
}



public virtual System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.CustomerOrderEN> Order {
        get { return order; } set { order = value;  }
}





public CustomerEN()
{
        order = new System.Collections.Generic.List<P2GenNHibernate.EN.Default_.CustomerOrderEN>();
}



public CustomerEN(string idnumber, string firstName, string email, string password, string lastName, string address, string telephone, string zip, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.CustomerOrderEN> order
                  )
{
        this.init (Idnumber, firstName, email, password, lastName, address, telephone, zip, order);
}


public CustomerEN(CustomerEN customer)
{
        this.init (Idnumber, customer.FirstName, customer.Email, customer.Password, customer.LastName, customer.Address, customer.Telephone, customer.Zip, customer.Order);
}

private void init (string idnumber, string firstName, string email, string password, string lastName, string address, string telephone, string zip, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.CustomerOrderEN> order)
{
        this.Idnumber = idnumber;


        this.FirstName = firstName;

        this.Email = email;

        this.Password = password;

        this.LastName = lastName;

        this.Address = address;

        this.Telephone = telephone;

        this.Zip = zip;

        this.Order = order;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CustomerEN t = obj as CustomerEN;
        if (t == null)
                return false;
        if (Idnumber.Equals (t.Idnumber))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idnumber.GetHashCode ();
        return hash;
}
}
}
