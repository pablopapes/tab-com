using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableroComando.Clases.Models;
using TableroComando.Fachadas;
using NHibernate.Criterion;

namespace TableroComando.Fachadas
{
    public class IndicadorFachada : Fachada<IndicadorFachada>
    {
        public IList<Indicador> All()
        {
            return Db.Session.CreateCriteria<Indicador>().List<Indicador>();
        }

        public void Save(Indicador o)
        {
            Db.Session.Save(o);
            Db.Session.Flush();
        }

        public Indicador FindById(int indicadorId)
        {
            return Db.Session.CreateCriteria<Indicador>().Add(Restrictions.Eq("Id", indicadorId)).List<Indicador>().First() ;
        }
    }
}
