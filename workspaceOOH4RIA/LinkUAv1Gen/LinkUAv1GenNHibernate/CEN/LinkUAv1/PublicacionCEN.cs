

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
 *      Definition of the class PublicacionCEN
 *
 */
public partial class PublicacionCEN
{
private IPublicacionCAD _IPublicacionCAD;

public PublicacionCEN()
{
        this._IPublicacionCAD = new PublicacionCAD ();
}

public PublicacionCEN(IPublicacionCAD _IPublicacionCAD)
{
        this._IPublicacionCAD = _IPublicacionCAD;
}

public IPublicacionCAD get_IPublicacionCAD ()
{
        return this._IPublicacionCAD;
}

public int New_ (string p_titulo, string p_texto, bool p_anonimo, bool p_cerrado, Nullable<DateTime> p_fecha, int p_likes, string p_usuario_1, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum p_categoria)
{
        PublicacionEN publicacionEN = null;
        int oid;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Titulo = p_titulo;

        publicacionEN.Texto = p_texto;

        publicacionEN.Anonimo = p_anonimo;

        publicacionEN.Cerrado = p_cerrado;

        publicacionEN.Fecha = p_fecha;

        publicacionEN.Likes = p_likes;


        if (p_usuario_1 != null) {
                // El argumento p_usuario_1 -> Property usuario_1 es oid = false
                // Lista de oids id
                publicacionEN.Usuario_1 = new LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN ();
                publicacionEN.Usuario_1.Email = p_usuario_1;
        }

        publicacionEN.Categoria = p_categoria;

        //Call to PublicacionCAD

        oid = _IPublicacionCAD.New_ (publicacionEN);
        return oid;
}

public void Modify (int p_Publicacion_OID, string p_titulo, string p_texto, bool p_anonimo, bool p_cerrado, Nullable<DateTime> p_fecha, int p_likes, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum p_categoria)
{
        PublicacionEN publicacionEN = null;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Id = p_Publicacion_OID;
        publicacionEN.Titulo = p_titulo;
        publicacionEN.Texto = p_texto;
        publicacionEN.Anonimo = p_anonimo;
        publicacionEN.Cerrado = p_cerrado;
        publicacionEN.Fecha = p_fecha;
        publicacionEN.Likes = p_likes;
        publicacionEN.Categoria = p_categoria;
        //Call to PublicacionCAD

        _IPublicacionCAD.Modify (publicacionEN);
}

public void Destroy (int id)
{
        _IPublicacionCAD.Destroy (id);
}

public void Like (int p_Publicacion_OID, System.Collections.Generic.IList<string> p_usuario_3_OIDs)
{
        //Call to PublicacionCAD

        _IPublicacionCAD.Like (p_Publicacion_OID, p_usuario_3_OIDs);
}
public PublicacionEN Buscar (int id)
{
        PublicacionEN publicacionEN = null;

        publicacionEN = _IPublicacionCAD.Buscar (id);
        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> list = null;

        list = _IPublicacionCAD.Listar (first, size);
        return list;
}
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.PublicacionEN> Por_likes ()
{
        return _IPublicacionCAD.Por_likes ();
}
public void Unlike (int p_Publicacion_OID, System.Collections.Generic.IList<string> p_usuario_3_OIDs)
{
        //Call to PublicacionCAD

        _IPublicacionCAD.Unlike (p_Publicacion_OID, p_usuario_3_OIDs);
}
}
}
