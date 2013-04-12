using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using TableroComando.Dominio;
using NHibernate.Criterion;
using Repositorios;
using Dominio.Validations;

namespace TableroComando.Dominio
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

        public bool IsCodigoUnico(string codigo)
        {
            return (_session.CreateCriteria<Indicador>().Add(Restrictions.Like("Codigo", codigo)).UniqueResult() != null) ? false : true;
        }

        public bool ValidateCodigoUnico(Indicador indicadorToBeUpdate)
        {
            Indicador indicadorExistente = (Indicador)_session.CreateCriteria<Indicador>()
                .Add(Restrictions.Like("Codigo", indicadorToBeUpdate.Codigo))
                .UniqueResult();
            if (indicadorExistente == null || indicadorToBeUpdate == indicadorExistente) return true;
            return false;
        }
    }
}

