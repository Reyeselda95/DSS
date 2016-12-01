
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
 * Clase Usuario:
 *
 */

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (string email)
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }

        return result;
}

public string New_ (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                if (usuario.Titulacion_1 != null) {
                        // Argumento OID y no colección.
                        usuario.Titulacion_1 = (LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN), usuario.Titulacion_1.Id);

                        usuario.Titulacion_1.Usuario_7
                        .Add (usuario);
                }

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.Email;
}

public void Modify (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Email);

                usuarioEN.Nick = usuario.Nick;


                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Apellidos = usuario.Apellidos;


                usuarioEN.Fnac = usuario.Fnac;


                usuarioEN.Tfno = usuario.Tfno;


                usuarioEN.Pass = usuario.Pass;


                usuarioEN.Estado = usuario.Estado;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string email)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), email);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Buscar
//Con e: UsuarioEN
public UsuarioEN Buscar (string email)
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> Por_titulacion (int p_titulacion)
{
        System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where FROM UsuarioEN WHERE Titulacion_1.Id = p_titulacion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENpor_titulacionHQL");
                query.SetParameter ("p_titulacion", p_titulacion);

                result = query.List<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
