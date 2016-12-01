
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using RetappGenNHibernate.EN.Retapp;
using RetappGenNHibernate.CAD.Retapp;

namespace RetappGenNHibernate.CEN.Retapp
{
public partial class ParticipacionCEN
{
public void Ganar (int id, int pos, string premio)
{
        /*PROTECTED REGION ID(RetappGenNHibernate.CEN.Retapp_Participacion_Ganar) ENABLED START*/

        // Write here your custom code...
        try
        {
                ParticipacionCEN parcen = new ParticipacionCEN ();
                ParticipacionEN par = parcen._IParticipacionCAD.ReadOID (id);

                VictoriaCEN viccen = new VictoriaCEN ();
                viccen.New_ (par.Usuario_0.Id, par.Fecha, par.Valor, par.Prueba, par.Votos, par.Reportes, par.Reto.Id, pos, premio);
        }
        catch (Exception ex) { Console.WriteLine ("Se ha producido una excepci�n al crear una victoria a partir de una participacion: " + ex); }


        /*PROTECTED REGION END*/
}
}
}
