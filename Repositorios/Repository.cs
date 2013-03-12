using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using Dominio;
using NHibernate.Criterion;
using Repositorios;

namespace TableroComando
{
    public class Repository<T> where T : Repository<T>, new()
    {
        /* Properties */
        protected static T instance;
        public ISession _session;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }

        }

        /* Constructor */
        protected Repository()
        {
            this._session = SingletonSession.Session;
        }

        public void SaveAll<T>(IEnumerable<T> objects)
        {
            foreach (object obj in objects)
            {
                T specificObject = (T)obj;
                _session.Save(specificObject);
            }
            _session.Flush();
        }

        protected void OrderBy(ICriteria criteria, KeyValuePair<string, bool> orderBy)
        {
            AddOrder(criteria, orderBy);
        }

        protected void OrderBy(ICriteria criteria, Dictionary<string, bool> orderBy)
        {
            foreach (var par in orderBy)
            {
                AddOrder(criteria, par);
            }
        }

        private static void AddOrder(ICriteria criteria, KeyValuePair<string, bool> keyValuePair)
        {
            if (keyValuePair.Key.Contains("."))
            {
                Order order = new Order(keyValuePair.Key.Split('.').Last(), keyValuePair.Value);
                criteria.CreateCriteria(keyValuePair.Key.Split('.').First()).AddOrder(order);
            }

            else
            {
                Order order = new Order(keyValuePair.Key, keyValuePair.Value);
                criteria.AddOrder(order);
            }
        }

        protected void Save<Type>(Type o)
        {
            _session.Save(o);
            _session.Flush();
        }

        protected void Delete<Type>(Type o)
        {
            _session.Delete(o);
            _session.Flush();
        }

        protected IList<Type> All<Type>() where Type : class
        {
            return _session.CreateCriteria<Type>().List<Type>();
        }
    }
}
