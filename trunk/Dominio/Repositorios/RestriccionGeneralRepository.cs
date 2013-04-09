using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using NHibernate;
using NHibernate.Criterion;

namespace Repositorios
{
    public class RestriccionGeneralRepository : Repository<RestriccionGeneralRepository, RestriccionGeneral>
    {
        public IList<ClassRestriccion> All<ClassRestriccion>() where ClassRestriccion : RestriccionGeneral
        {
            return _session.CreateCriteria<ClassRestriccion>().AddOrder(new Order("Orden", true)).List<ClassRestriccion>();
        }

        public IList<ClassRestriccion> FindBy<ClassRestriccion>(Dictionary<string, object> properties) where ClassRestriccion : RestriccionGeneral
        {
            return _session.CreateCriteria<ClassRestriccion>().Add(Restrictions.AllEq(properties)).List<ClassRestriccion>();
        }

        /* Crea las restricciones de objetivos si no existen en la base de datos */
        public void CrearRestriccionesObjetivos()
        {
            foreach(TipoRestriccion tipo in Enum.GetValues(typeof(TipoRestriccion)))
            {
                if (All<RestriccionObjetivo>().Where( r => r.Tipo == tipo).ToList().Count == 0)
                    RestriccionGeneralRepository.Instance.Save(new RestriccionObjetivo(tipo));
            }
        }

        public void CrearRestriccionesPerspectiva()
        {
            foreach (TipoRestriccion tipo in Enum.GetValues(typeof(TipoRestriccion)))
            {
                if (All<RestriccionPerspectiva>().Where(r => r.Tipo == tipo).ToList().Count == 0)
                    RestriccionGeneralRepository.Instance.Save(new RestriccionPerspectiva(tipo));
            }
        }
    }
}
