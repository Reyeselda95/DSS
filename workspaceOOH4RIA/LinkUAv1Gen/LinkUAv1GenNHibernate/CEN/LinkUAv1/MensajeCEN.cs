

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
 *      Definition of the class MensajeCEN
 *
 */
public partial class MensajeCEN
{
private IMensajeCAD _IMensajeCAD;

public MensajeCEN()
{
        this._IMensajeCAD = new MensajeCAD ();
}

public MensajeCEN(IMensajeCAD _IMensajeCAD)
{
        this._IMensajeCAD = _IMensajeCAD;
}

public IMensajeCAD get_IMensajeCAD ()
{
        return this._IMensajeCAD;
}

public int New_ (string p_usuario_5, string p_usuario_6, string p_texto, Nullable<DateTime> p_fecha)
{
        MensajeEN mensajeEN = null;
        int oid;

        //Initialized MensajeEN
        mensajeEN = new MensajeEN ();

        if (p_usuario_5 != null) {
                // El argumento p_usuario_5 -> Property usuario_5 es oid = false
                // Lista de oids id
                mensajeEN.Usuario_5 = new LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN ();
                mensajeEN.Usuario_5.Email = p_usuario_5;
        }


        if (p_usuario_6 != null) {
                // El argumento p_usuario_6 -> Property usuario_6 es oid = false
                // Lista de oids id
                mensajeEN.Usuario_6 = new LinkUAv1GenNHibernate.EN.LinkUAv1.UsuarioEN ();
                mensajeEN.Usuario_6.Email = p_usuario_6;
        }

        mensajeEN.Texto = p_texto;

        mensajeEN.Fecha = p_fecha;

        //Call to MensajeCAD

        oid = _IMensajeCAD.New_ (mensajeEN);
        return oid;
}

public void Modify (int p_Mensaje_OID, string p_texto, Nullable<DateTime> p_fecha)
{
        MensajeEN mensajeEN = null;

        //Initialized MensajeEN
        mensajeEN = new MensajeEN ();
        mensajeEN.Id = p_Mensaje_OID;
        mensajeEN.Texto = p_texto;
        mensajeEN.Fecha = p_fecha;
        //Call to MensajeCAD

        _IMensajeCAD.Modify (mensajeEN);
}

public void Destroy (int id)
{
        _IMensajeCAD.Destroy (id);
}

public MensajeEN Buscar (int id)
{
        MensajeEN mensajeEN = null;

        mensajeEN = _IMensajeCAD.Buscar (id);
        return mensajeEN;
}

public System.Collections.Generic.IList<MensajeEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<MensajeEN> list = null;

        list = _IMensajeCAD.Listar (first, size);
        return list;
}
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> Por_emisor (string p_usuario1, string p_usuario2)
{
        return _IMensajeCAD.Por_emisor (p_usuario1, p_usuario2);
}
public System.Collections.Generic.IList<LinkUAv1GenNHibernate.EN.LinkUAv1.MensajeEN> Por_texto (string p_texto)
{
        return _IMensajeCAD.Por_texto (p_texto);
}
}
}
