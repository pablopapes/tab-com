using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableroComando.Fachadas;
using NHibernate.Criterion;
using Dominio;

namespace TableroComando.Fachadas
{
    public class ObjetivoRepository : Repository<ObjetivoRepository>
    {
        public IList<Objetivo> All()
        {
            return _session.CreateCriteria<Objetivo>().List<Objetivo>();
        }

        /* Traer todos los objetivos ordenados por un solo campo */
        public IList<Objetivo> All(Dictionary<string, bool> orderBy)
        {
            var criteria = _session.CreateCriteria<Objetivo>();
            if (orderBy != null)
            {
                OrderBy(criteria, orderBy);
            }

            return criteria.List<Objetivo>();
        }

        /* Traer todos los objetivos ordenados por varios campos */
        public IList<Objetivo> All(KeyValuePair<string, bool> orderBy)
        {
            var criteria = _session.CreateCriteria<Objetivo>();
            OrderBy(criteria, orderBy);
            
            return criteria.List<Objetivo>();

        }
        /* Buscar por id de perspectiva */
        public IList<Objetivo> FindByPerspectiva(int IdPerspectiva)
        {
           return 
               _session.CreateCriteria<Objetivo>()
               .CreateCriteria("Perspectiva").Add(Restrictions.Eq("Id", IdPerspectiva)).List<Objetivo>();
        }

        public void Save(Objetivo o)
        {
            _session.Save(o);
            _session.Flush();
        }

        public Objetivo FindById(int indicadorId)
        {
            return _session.CreateCriteria<Objetivo>().Add(Restrictions.Eq("Id", indicadorId)).List<Objetivo>().First();
        }

        public void SaveOrUpdate(Objetivo o)
        {
            _session.SaveOrUpdate(o);
            _session.Flush();
        }

        public void Delete(Objetivo o)
        {
            Delete<Objetivo>(o);
        }
    }
}
