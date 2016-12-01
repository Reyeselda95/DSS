
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using RetappGenNHibernate.EN.Retapp;
using RetappGenNHibernate.CAD.Retapp;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
namespace RetappGenNHibernate.CEN.Retapp
{
public partial class ConcursoCEN
{
public System.Collections.Generic.IList<RetappGenNHibernate.EN.Retapp.RetoEN> ReadRetos (int concurso)
{
        /*PROTECTED REGION ID(RetappGenNHibernate.CEN.Retapp_Concurso_ReadRetos) ENABLED START*/

        // Write here your custom code...
        string ConnectionString = "Data Source=ARA65;Initial Catalog=RetappGenNHibernate;Persist Security Info=True;User ID=nhibernateUser;Password=nhibernatePass";

        List<RetoEN> lista = new List<RetoEN>();
        try
        {
                SqlConnection c = new SqlConnection (ConnectionString);
                c.Open ();
                SqlCommand com = new SqlCommand ("Select idConcurso from Reto where FK_idConcurso_idConcurso = " + concurso + " ; ", c);
                SqlDataReader dr = com.ExecuteReader ();
                RetoCEN retcen = new RetoCEN ();
                while (dr.Read ()) {
                        RetoEN ret = retcen.ReadOID (dr.GetInt32 (0));
                        lista.Add (ret);
                }
                dr.Close ();
                c.Close ();
        }

        catch (Exception ex)
        {
                Console.WriteLine ("Se ha producido una excepcion al leer los retos de un concurso: " + ex);
        }

        return lista;

        /*PROTECTED REGION END*/
}
}
}
