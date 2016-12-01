

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using InariPlaysGenNHibernate.EN.Prueba;
using InariPlaysGenNHibernate.CAD.Prueba;

namespace InariPlaysGenNHibernate.CEN.Prueba
{
public partial class MusicaCEN
{
private IMusicaCAD _IMusicaCAD;

public MusicaCEN()
{
        this._IMusicaCAD = new MusicaCAD ();
}

public MusicaCEN(IMusicaCAD _IMusicaCAD)
{
        this._IMusicaCAD = _IMusicaCAD;
}

public IMusicaCAD get_IMusicaCAD ()
{
        return this._IMusicaCAD;
}

public int New_ (string p_nombre, string p_descripcion, int p_precio, string p_urlFoto)
{
        MusicaEN musicaEN = null;
        int oid;

        //Initialized MusicaEN
        musicaEN = new MusicaEN ();
        musicaEN.Nombre = p_nombre;

        musicaEN.Descripcion = p_descripcion;

        musicaEN.Precio = p_precio;

        musicaEN.UrlFoto = p_urlFoto;

        //Call to MusicaCAD

        oid = _IMusicaCAD.New_ (musicaEN);
        return oid;
}

public void Modify (int p_musica_OID, string p_nombre, string p_descripcion, int p_precio, string p_urlFoto)
{
        MusicaEN musicaEN = null;

        //Initialized MusicaEN
        musicaEN = new MusicaEN ();
        musicaEN.MusicaId = p_musica_OID;
        musicaEN.Nombre = p_nombre;
        musicaEN.Descripcion = p_descripcion;
        musicaEN.Precio = p_precio;
        musicaEN.UrlFoto = p_urlFoto;
        //Call to MusicaCAD

        _IMusicaCAD.Modify (musicaEN);
}

public void Destroy (int musicaId)
{
        _IMusicaCAD.Destroy (musicaId);
}

public System.Collections.Generic.IList<MusicaEN> Damemusica (int first, int size)
{
        System.Collections.Generic.IList<MusicaEN> list = null;

        list = _IMusicaCAD.Damemusica (first, size);
        return list;
}
}
}
