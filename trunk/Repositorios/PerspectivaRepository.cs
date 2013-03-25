using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorios;

namespace TableroComando.Fachadas
{
    public class PerspectivaRepository : Repository<PerspectivaRepository>
    {

        public IList<Perspectiva> All()
        {
            return _session.CreateCriteria<Perspectiva>().List<Perspectiva>();
        }

        public void Save(Perspectiva p)
        {
            _session.Save(p);
            _session.Flush();
        }
    }
}
