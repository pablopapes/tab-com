using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableroComando.Clases.Models;

namespace TableroComando.Fachadas
{
    public class PerspectivaFachada : Fachada<PerspectivaFachada>
    {

        public IList<Perspectiva> All()
        {
            return Db.Session.CreateCriteria<Perspectiva>().List<Perspectiva>();
        }

        public void Save(Perspectiva p)
        {
            Db.Session.Save(p);
            Db.Session.Flush();
        }
    }
}
