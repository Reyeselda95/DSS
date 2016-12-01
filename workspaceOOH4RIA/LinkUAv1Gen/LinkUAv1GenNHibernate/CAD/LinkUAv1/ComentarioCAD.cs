
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
 * Clase Comentario:
 *
 */

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial class ComentarioCAD : BasicCAD, IComentarioCAD
{
public ComentarioCAD() : base ()
{
}

public ComentarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ComentarioEN ReadOIDDefault (int id)
{
        ComentarioEN comentarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Get (typeof(ComentarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ComentarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ComentarioEN>();
                        else
                                result = session.CreateCriteria (typeof(ComentarioEN)).List<ComentarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }

        return result;
}

public int New_ (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                if (comentario.Usuario_2 != null) {
                        // Argumento OID y no colección.
                        comentario.Usuario_2 = (LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN), comentario.Usuario_2.Email);

                        comentario.Usuario_2.Comentario_1
                        .Add (comentario);
                }
                if (comentario.Publicacion_3 != null) {
                        // Argumento OID y no colección.
                        comentario.Publicacion_3 = (LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN), comentario.Publicacion_3.Id);

                        comentario.Publicacion_3.Comentario_3
                        .Add (comentario);
                }

                session.Save (comentario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentario.Id;
}

public void Modify (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), comentario.Id);

                comentarioEN.Texto = comentario.Texto;


                comentarioEN.Fecha = comentario.Fecha;


                comentarioEN.Likes = comentario.Likes;

                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
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
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), id);
                session.Delete (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Like (int p_Comentario_OID, System.Collections.Generic.IList<string> p_usuario_4_OIDs)
{
        LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN comentarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), p_Comentario_OID);
                LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_4ENAux = null;
                if (comentarioEN.Usuario_4 == null) {
                        comentarioEN.Usuario_4 = new System.Collections.Generic.List<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN>();
                }

                foreach (string item in p_usuario_4_OIDs) {
                        usuario_4ENAux = new LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN ();
                        usuario_4ENAux = (LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN), item);
                        usuario_4ENAux.Comentario_2.Add (comentarioEN);

                        comentarioEN.Usuario_4.Add (usuario_4ENAux);
                }


                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Buscar
//Con e: ComentarioEN
public ComentarioEN Buscar (int id)
{
        ComentarioEN comentarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Get (typeof(ComentarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ComentarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ComentarioEN>();
                else
                        result = session.CreateCriteria (typeof(ComentarioEN)).List<ComentarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void Unlike (int p_Comentario_OID, System.Collections.Generic.IList<string> p_usuario_4_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                LinkUAv1GenNHibernate.EN.LinkUAv1.ComentarioEN comentarioEN = null;
                comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), p_Comentario_OID);

                LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN usuario_4ENAux = null;
                if (comentarioEN.Usuario_4 != null) {
                        foreach (string item in p_usuario_4_OIDs) {
                                usuario_4ENAux = (LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN), item);
                                if (comentarioEN.Usuario_4.Contains (usuario_4ENAux) == true) {
                                        comentarioEN.Usuario_4.Remove (usuario_4ENAux);
                                        usuario_4ENAux.Comentario_2.Remove (comentarioEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_usuario_4_OIDs you are trying to unrelationer, doesn't exist in ComentarioEN");
                        }
                }

                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
