using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Criterion;

namespace TableroComando.Fachadas
{
    public abstract class Fachada<T> where T : Fachada<T>, new()
    {
        protected Repository Db;
        public static readonly T Instance = new T();

        protected Fachada()
        {
            Db = Repository.Instance;
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

        protected void Save<T>(T o)
        {
            Db.Session.Save(o);
            Db.Session.Flush();
        }

    }
}
