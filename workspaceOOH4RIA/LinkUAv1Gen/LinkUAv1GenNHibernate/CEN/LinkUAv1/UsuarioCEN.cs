

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string New_ (string p_email, string p_nick, string p_nombre, string p_apellidos, Nullable<DateTime> p_fnac, string p_tfno, string p_pass, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum p_estado, int p_titulacion_1)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_email;

        usuarioEN.Nick = p_nick;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Fnac = p_fnac;

        usuarioEN.Tfno = p_tfno;

        usuarioEN.Pass = p_pass;

        usuarioEN.Estado = p_estado;


        if (p_titulacion_1 != -1) {
                // El argumento p_titulacion_1 -> Property titulacion_1 es oid = false
                // Lista de oids email
                usuarioEN.Titulacion_1 = new LinkUAv1GenNHibernate.EN.LinkUAv1.TitulacionEN ();
                usuarioEN.Titulacion_1.Id = p_titulacion_1;
        }

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (string p_Usuario_OID, string p_nick, string p_nombre, string p_apellidos, Nullable<DateTime> p_fnac, string p_tfno, string p_pass, LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum p_estado)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Usuario_OID;
        usuarioEN.Nick = p_nick;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Fnac = p_fnac;
        usuarioEN.Tfno = p_tfno;
        usuarioEN.Pass = p_pass;
        usuarioEN.Estado = p_estado;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (string email)
{
        _IUsuarioCAD.Destroy (email);
}

public UsuarioEN Buscar (string email)
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.Buscar (email);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.Listar (first, size);
        return list;
}
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN> Por_titulacion (int p_titulacion)
{
        return _IUsuarioCAD.Por_titulacion (p_titulacion);
}
}
}
