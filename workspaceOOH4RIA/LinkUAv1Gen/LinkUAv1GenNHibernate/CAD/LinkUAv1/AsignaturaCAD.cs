
using System;
using System.Text;
using LinkUAv1GenNHibernate.CEN.LinkUAv1;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LinkUAv1GenNHibernate.EN.LinkUAv1;
using LinkUAv1GenNHibernate.Exceptions;

/*
 * Clase Asignatura:
 *
 */

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial class AsignaturaCAD : BasicCAD, IAsignaturaCAD
{
public AsignaturaCAD() : base ()
{
}

public AsignaturaCAD(ISession sessionAux) : base (sessionAux)
{
}



public AsignaturaEN ReadOIDDefault (int id)
{
        AsignaturaEN asignaturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                asignaturaEN = (AsignaturaEN)session.Get (typeof(AsignaturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in AsignaturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return asignaturaEN;
}

public System.Collections.Generic.IList<AsignaturaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AsignaturaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AsignaturaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AsignaturaEN>();
                        else
                                result = session.CreateCriteria (typeof(AsignaturaEN)).List<AsignaturaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in AsignaturaCAD.", ex);
        }

        return result;
}

public int New_ (AsignaturaEN asignatura)
{
        try
        {
                SessionInitializeTransaction ();
                if (asignatura.Titulacion_2 != null) {
                        // Argumento OID y no colección.
                        asignatura.Titulacion_2 = (LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN), asignatura.Titulacion_2.Id);

                        asignatura.Titulacion_2.Asignatura_1
                        .Add (asignatura);
                }

                session.Save (asignatura);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in AsignaturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return asignatura.Id;
}

public void Modify (AsignaturaEN asignatura)
{
        try
        {
                SessionInitializeTransaction ();
                AsignaturaEN asignaturaEN = (AsignaturaEN)session.Load (typeof(AsignaturaEN), asignatura.Id);

                asignaturaEN.Nombre = asignatura.Nombre;


                asignaturaEN.Curso = asignatura.Curso;

                session.Update (asignaturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in AsignaturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id)
{
        try
        {
                SessionInitializeTransaction ();
                AsignaturaEN asignaturaEN = (AsignaturaEN)session.Load (typeof(AsignaturaEN), id);
                session.Delete (asignaturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in AsignaturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Buscar
//Con e: AsignaturaEN
public AsignaturaEN Buscar (int id)
{
        AsignaturaEN asignaturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                asignaturaEN = (AsignaturaEN)session.Get (typeof(AsignaturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in AsignaturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return asignaturaEN;
}

public System.Collections.Generic.IList<AsignaturaEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<AsignaturaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AsignaturaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AsignaturaEN>();
                else
                        result = session.CreateCriteria (typeof(AsignaturaEN)).List<AsignaturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in AsignaturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
