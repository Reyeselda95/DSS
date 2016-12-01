

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using LinkUAv1GenNHibernate.EN.LinkUAv1;
using LinkUAv1GenNHibernate.CAD.LinkUAv1;

namespace LinkUAv1GenNHibernate.CEN.LinkUAv1
{
/*
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int New_ (string p_texto, Nullable<DateTime> p_fecha, int p_likes, string p_usuario_2, int p_publicacion_3)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Texto = p_texto;

        comentarioEN.Fecha = p_fecha;

        comentarioEN.Likes = p_likes;


        if (p_usuario_2 != null) {
                // El argumento p_usuario_2 -> Property usuario_2 es oid = false
                // Lista de oids id
                comentarioEN.Usuario_2 = new LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN ();
                comentarioEN.Usuario_2.Email = p_usuario_2;
        }


        if (p_publicacion_3 != -1) {
                // El argumento p_publicacion_3 -> Property publicacion_3 es oid = false
                // Lista de oids id
                comentarioEN.Publicacion_3 = new LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN ();
                comentarioEN.Publicacion_3.Id = p_publicacion_3;
        }

        //Call to ComentarioCAD

        oid = _IComentarioCAD.New_ (comentarioEN);
        return oid;
}

public void Modify (int p_Comentario_OID, string p_texto, Nullable<DateTime> p_fecha, int p_likes)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Texto = p_texto;
        comentarioEN.Fecha = p_fecha;
        comentarioEN.Likes = p_likes;
        //Call to ComentarioCAD

        _IComentarioCAD.Modify (comentarioEN);
}

public void Destroy (int id)
{
        _IComentarioCAD.Destroy (id);
}

public void Like (int p_Comentario_OID, System.Collections.Generic.IList<string> p_usuario_4_OIDs)
{
        //Call to ComentarioCAD

        _IComentarioCAD.Like (p_Comentario_OID, p_usuario_4_OIDs);
}
public ComentarioEN Buscar (int id)
{
        ComentarioEN comentarioEN = null;

        comentarioEN = _IComentarioCAD.Buscar (id);
        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> list = null;

        list = _IComentarioCAD.Listar (first, size);
        return list;
}
public void Unlike (int p_Comentario_OID, System.Collections.Generic.IList<string> p_usuario_4_OIDs)
{
        //Call to ComentarioCAD

        _IComentarioCAD.Unlike (p_Comentario_OID, p_usuario_4_OIDs);
}
}
}
