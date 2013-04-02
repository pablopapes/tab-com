using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using TableroComando.Fachadas;
using NHibernate.Criterion;
using Repositorios;

namespace TableroComando.Fachadas
{
    public class IndicadorRepository : Repository<IndicadorRepository, Indicador>
    {
        public IList<Indicador> All(string propertyName = "")
        {
            return _session.CreateCriteria<Indicador>().AddOrder(Order.Asc("Codigo")).List<Indicador>();
        }

        public IList<Indicador> FindByRequiereMedicion()
        {
            return All().Where(i => i.RequiereMedicion).ToList();
        }

        public IList<Frecuencia> AllFrecuencias()
        {
            return _session.CreateCriteria<Frecuencia>().List<Frecuencia>();
        }

    }
}
