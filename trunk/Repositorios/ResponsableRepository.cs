using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorios;

namespace TableroComando.Fachadas
{
    public class ResponsableRepository : Repository<ResponsableRepository>
    {
        public void Save(Responsable r)
        {
            base.Save<Responsable>(r);
        }

        public IList<Responsable> All()
        {
            return All<Responsable>();
        }

        public void Delete(Responsable r)
        {
            Delete<Responsable>(r);
        }
    }
}
