using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableroComando.Dominio;
using NHibernate.Criterion;
using Dominio;
using Repositorios;

namespace TableroComando.Dominio
{
    public class ObjetivoRepository : Repository<ObjetivoRepository, Objetivo>
    {
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
    }
}
