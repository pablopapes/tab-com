using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableroComando.Fachadas;
using TableroComando.Clases.Models;
using NHibernate.Criterion;

namespace TableroComando.Fachadas
{
    public class ObjetivoFachada : Fachada<ObjetivoFachada>
    {
        public IList<Objetivo> All()
        {
            return Db.Session.CreateCriteria<Objetivo>().List<Objetivo>();
        }

        public IList<Objetivo> FindByPerspectiva(int IdPerspectiva)
        {
           return 
               Db.Session.CreateCriteria<Objetivo>()
               .CreateCriteria("Perspectiva").Add(Restrictions.Eq("Id", IdPerspectiva)).List<Objetivo>();
        }

        public void Save(Objetivo o)
        {
            Db.Session.Save(o);
            Db.Session.Flush();
        }

        public Objetivo FindById(int indicadorId)
        {
            return Db.Session.CreateCriteria<Objetivo>().Add(Restrictions.Eq("Id", indicadorId)).List<Objetivo>().First();
        }
    }
}
