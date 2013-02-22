using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using Dominio;

namespace TableroComando
{
    public class Repository
    {
        /* Properties */
        private static Repository instance;
        private ISession _Session;
        public static Repository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Repository();
                }
                return instance;
            }

        }

        public ISession Session
        {
            get { return this._Session; }
        }

        /* Constructor */
        private Repository()
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
                this._Session = sessions.OpenSession();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void SaveAll<T>(IEnumerable<T> objects)
        {
            foreach (object obj in objects)
            {
                T specificObject = (T)obj;
                Session.Save(specificObject);
            }
            Session.Flush();
        }
    }
}
