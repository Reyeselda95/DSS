
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
 * Clase Material:
 *
 */

namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public partial class MaterialCAD : BasicCAD, IMaterialCAD
{
public MaterialCAD() : base ()
{
}

public MaterialCAD(ISession sessionAux) : base (sessionAux)
{
}



public MaterialEN ReadOIDDefault (int id)
{
        MaterialEN materialEN = null;

        try
        {
                SessionInitializeTransaction ();
                materialEN = (MaterialEN)session.Get (typeof(MaterialEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return materialEN;
}

public System.Collections.Generic.IList<MaterialEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MaterialEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MaterialEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MaterialEN>();
                        else
                                result = session.CreateCriteria (typeof(MaterialEN)).List<MaterialEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
        }

        return result;
}

public int New_ (MaterialEN material)
{
        try
        {
                SessionInitializeTransaction ();
                if (material.Asignatura_2 != null) {
                        // Argumento OID y no colección.
                        material.Asignatura_2 = (LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.AsignaturaEN), material.Asignatura_2.Id);

                        material.Asignatura_2.Material_1
                        .Add (material);
                }
                if (material.Usuario_8 != null) {
                        // Argumento OID y no colección.
                        material.Usuario_8 = (LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN)session.Load (typeof(LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN), material.Usuario_8.Email);

                        material.Usuario_8.Material_2
                        .Add (material);
                }

                session.Save (material);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return material.Id;
}

public void Modify (MaterialEN material)
{
        try
        {
                SessionInitializeTransaction ();
                MaterialEN materialEN = (MaterialEN)session.Load (typeof(MaterialEN), material.Id);

                materialEN.Nombre = material.Nombre;


                materialEN.Descripcion = material.Descripcion;


                materialEN.Url = material.Url;


                materialEN.Descargas = material.Descargas;

                session.Update (materialEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
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
                MaterialEN materialEN = (MaterialEN)session.Load (typeof(MaterialEN), id);
                session.Delete (materialEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Buscar
//Con e: MaterialEN
public MaterialEN Buscar (int id)
{
        MaterialEN materialEN = null;

        try
        {
                SessionInitializeTransaction ();
                materialEN = (MaterialEN)session.Get (typeof(MaterialEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return materialEN;
}

public System.Collections.Generic.IList<MaterialEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<MaterialEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MaterialEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MaterialEN>();
                else
                        result = session.CreateCriteria (typeof(MaterialEN)).List<MaterialEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> Por_asignatura (int p_asignatura)
{
        System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MaterialEN self where FROM MaterialEN WHERE Asignatura_2.Id = p_asignatura";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MaterialENpor_asignaturaHQL");
                query.SetParameter ("p_asignatura", p_asignatura);

                result = query.List<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> Por_usuario (string p_usuario)
{
        System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MaterialEN self where FROM MaterialEN WHERE Usuario_8.Email = p_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MaterialENpor_usuarioHQL");
                query.SetParameter ("p_usuario", p_usuario);

                result = query.List<LinkUAv1GenNHibernate.EN.LinkUAv1.MaterialEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LinkUAv1GenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LinkUAv1GenNHibernate.Exceptions.DataLayerException ("Error in MaterialCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
