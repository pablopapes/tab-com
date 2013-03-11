using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using TableroComando.Fachadas;
using NHibernate.Criterion;

namespace TableroComando.Fachadas
{
    public class IndicadorRepository : Repository<IndicadorRepository>
    {
        public IList<Indicador> All(string propertyName = "")
        {
            return _session.CreateCriteria<Indicador>().AddOrder(Order.Asc("Codigo")).List<Indicador>();
        }

        public void Save(Indicador o)
        {
            base.Save<Indicador>(o);
        }

        public void SaveOrUpdate(Indicador i)
        {
            _session.SaveOrUpdate(i);
            _session.Flush();
        }

        public Indicador FindById(int indicadorId)
        {
            return _session.Get<Indicador>(indicadorId);
        }


        public IList<Indicador> FindByRequiereMedicion()
        {
            return All().Where(i => i.RequiereMedicion).ToList<Indicador>();
        }

        public IList<Frecuencia> AllFrecuencias()
        {
            return _session.CreateCriteria<Frecuencia>().List<Frecuencia>();
        }

        public void Delete(Indicador i)
        {
            Delete<Indicador>(i);            
        }
    }
}
