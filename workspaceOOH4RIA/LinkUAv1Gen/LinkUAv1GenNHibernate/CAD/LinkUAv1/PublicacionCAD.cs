
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
 * Clase Publicacion:
 *
 */

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial class PublicacionCAD : BasicCAD, IPublicacionCAD
{
public PublicacionCAD() : base ()
{
}

public PublicacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public PublicacionEN ReadOIDDefault (int id)
{
        PublicacionEN publicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                publicacionEN = (PublicacionEN)session.Get (typeof(PublicacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PublicacionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PublicacionEN>();
                        else
                                result = session.CreateCriteria (typeof(PublicacionEN)).List<PublicacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }

        return result;
}

public int New_ (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                if (publicacion.Usuario_1 != null) {
                        // Argumento OID y no colección.
                        publicacion.Usuario_1 = (LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN), publicacion.Usuario_1.Email);

                        publicacion.Usuario_1.Publicacion_1
                        .Add (publicacion);
                }

                session.Save (publicacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacion.Id;
}

public void Modify (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                PublicacionEN publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), publicacion.Id);

                publicacionEN.Titulo = publicacion.Titulo;


                publicacionEN.Texto = publicacion.Texto;


                publicacionEN.Anonimo = publicacion.Anonimo;


                publicacionEN.Cerrado = publicacion.Cerrado;


                publicacionEN.Fecha = publicacion.Fecha;


                publicacionEN.Likes = publicacion.Likes;


                publicacionEN.Categoria = publicacion.Categoria;

                session.Update (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
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
                PublicacionEN publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), id);
                session.Delete (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Like (int p_Publicacion_OID, System.Collections.Generic.IList<string> p_usuario_3_OIDs)
{
        LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN publicacionEN = null;
        try
        {
                SessionInitializeTransaction ();
                publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), p_Publicacion_OID);
                LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_3ENAux = null;
                if (publicacionEN.Usuario_3 == null) {
                        publicacionEN.Usuario_3 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN>();
                }

                foreach (string item in p_usuario_3_OIDs) {
                        usuario_3ENAux = new LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN ();
                        usuario_3ENAux = (LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN), item);
                        usuario_3ENAux.Publicacion_2.Add (publicacionEN);

                        publicacionEN.Usuario_3.Add (usuario_3ENAux);
                }


                session.Update (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Buscar
//Con e: PublicacionEN
public PublicacionEN Buscar (int id)
{
        PublicacionEN publicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                publicacionEN = (PublicacionEN)session.Get (typeof(PublicacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PublicacionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PublicacionEN>();
                else
                        result = session.CreateCriteria (typeof(PublicacionEN)).List<PublicacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> Por_likes ()
{
        System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PublicacionEN self where FROM PublicacionEN ORDER BY likes DESC";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PublicacionENpor_likesHQL");

                result = query.List<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Unlike (int p_Publicacion_OID, System.Collections.Generic.IList<string> p_usuario_3_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN publicacionEN = null;
                publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), p_Publicacion_OID);

                LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_3ENAux = null;
                if (publicacionEN.Usuario_3 != null) {
                        foreach (string item in p_usuario_3_OIDs) {
                                usuario_3ENAux = (LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN), item);
                                if (publicacionEN.Usuario_3.Contains (usuario_3ENAux) == true) {
                                        publicacionEN.Usuario_3.Remove (usuario_3ENAux);
                                        usuario_3ENAux.Publicacion_2.Remove (publicacionEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_usuario_3_OIDs you are trying to unrelationer, doesn't exist in PublicacionEN");
                        }
                }

                session.Update (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
