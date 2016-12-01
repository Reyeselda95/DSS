using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate;
using NHibernate.Cfg;

using LinkUAv1GenNHibernate.EN.LinkUAv1;


namespace LinkUAv1GenNHibernate.CAD.LinkUAv1
{
public static class NHibernateHelper
{
private static ISessionFactory _sessionFactory;

private static ISessionFactory SessionFactory
{
        get
        {
                if (_sessionFactory == null) {
                        var configuration = new Configuration ();
                        configuration.Configure ();
                        configuration.AddAssembly (typeof(UsuarioEN).Assembly);
                        _sessionFactory = configuration.BuildSessionFactory ();
                }

                return _sessionFactory;
        }
}

public static ISession OpenSession ()
{
        return SessionFactory.OpenSession ();
}
}
}
