

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
 *      Definition of the class TitulacionCEN
 *
 */
public partial class TitulacionCEN
{
private ITitulacionCAD _ITitulacionCAD;

public TitulacionCEN()
{
        this._ITitulacionCAD = new TitulacionCAD ();
}

public TitulacionCEN(ITitulacionCAD _ITitulacionCAD)
{
        this._ITitulacionCAD = _ITitulacionCAD;
}

public ITitulacionCAD get_ITitulacionCAD ()
{
        return this._ITitulacionCAD;
}

public int New_ (string p_nombre)
{
        TitulacionEN titulacionEN = null;
        int oid;

        //Initialized TitulacionEN
        titulacionEN = new TitulacionEN ();
        titulacionEN.Nombre = p_nombre;

        //Call to TitulacionCAD

        oid = _ITitulacionCAD.New_ (titulacionEN);
        return oid;
}

public void Modify (int p_Titulacion_OID, string p_nombre)
{
        TitulacionEN titulacionEN = null;

        //Initialized TitulacionEN
        titulacionEN = new TitulacionEN ();
        titulacionEN.Id = p_Titulacion_OID;
        titulacionEN.Nombre = p_nombre;
        //Call to TitulacionCAD

        _ITitulacionCAD.Modify (titulacionEN);
}

public void Destroy (int id)
{
        _ITitulacionCAD.Destroy (id);
}

public TitulacionEN Buscar (int id)
{
        TitulacionEN titulacionEN = null;

        titulacionEN = _ITitulacionCAD.Buscar (id);
        return titulacionEN;
}

public System.Collections.Generic.IList<TitulacionEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<TitulacionEN> list = null;

        list = _ITitulacionCAD.Listar (first, size);
        return list;
}
}
}
