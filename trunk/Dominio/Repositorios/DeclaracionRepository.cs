using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorios;
using Dominio.Validations;
using NHibernate.Criterion;

namespace Dominio.Repositorios
{
    public class DeclaracionRepository : Repository<DeclaracionRepository, Declaracion>
    {
        public Declaracion FindByTipo(string tipo)
        {
            return (Declaracion)_session.CreateCriteria<Declaracion>().Add(Restrictions.Like("Tipo", tipo)).UniqueResult();
        }

        public void CrearMisionVision()
        {
            if (FindByTipo("vision") == null)
            { 
                Declaracion vision = new Declaracion { Tipo = "vision" };
                Save(vision);
            }

            if (FindByTipo("mision") == null) 
            { 
                Declaracion mision = new Declaracion { Tipo = "mision" };
                Save(mision);
            }
        }
    }
}
