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

namespace Repositorios
{
    public class Repository<RepositoryClass, ModelClass> where RepositoryClass : Repository<RepositoryClass, ModelClass>, new()
                                                            where ModelClass: class
    {
        /* Properties */
        protected static RepositoryClass instance;
        protected ISession _session;
        public static RepositoryClass Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RepositoryClass();
                }
                return instance;
            }

        }

        /* Constructor */
        protected Repository()
        {
            this._session = SingletonSession.Session;
        }

        public void SaveAll(IEnumerable<ModelClass> objects)
        {
            foreach (object obj in objects)
            {
                ModelClass specificObject = (ModelClass)obj;
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

        public void Save(ModelClass o)
        {
            _session.Save(o);
            _session.Flush();
        }

        public void Delete(ModelClass o)
        {
            _session.Delete(o);
            _session.Flush();
        }

        public IList<ModelClass> All(params string[] args)
        {
            ICriteria criteria = _session.CreateCriteria<ModelClass>();
            foreach (string orderBy in args) criteria.AddOrder(new Order(orderBy, true));
            return criteria.List<ModelClass>();
        }

        public void SaveOrUpdate(ModelClass i)
        {
            _session.SaveOrUpdate(i);
            _session.Flush();
        }

        public ModelClass FindById(int indicadorId)
        {
            return _session.Get<ModelClass>(indicadorId);
        }
    }
}
