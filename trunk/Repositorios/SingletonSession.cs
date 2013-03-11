using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using Dominio;
using NHibernate.Tool.hbm2ddl;

namespace Repositorios
{
    class SingletonSession
    {
        protected static ISession _session;
        public static ISession Session
        {
            get
            {
                if (_session == null)
                {
                    try
                    {
                        var cfg = new Configuration();
                        cfg.Configure();
                        cfg.AddAssembly(typeof(Objetivo).Assembly);
                        var schema = new SchemaUpdate(cfg);
                        schema.Execute(true, true);
                        // Get ourselves an NHibernate Session
                        var sessions = cfg.BuildSessionFactory();
                        _session = sessions.OpenSession();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return _session;
            }

        }

    }
}
