﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableroComando;
using Dominio;

namespace Repositorios
{
    public class AccionCorrectivaRepository : Repository<AccionCorrectivaRepository>
    {
        public IList<AccionCorrectiva> All()
        {
            return All<AccionCorrectiva>();
        }

        public void Save(AccionCorrectiva accionCorrectiva)
        {
            Save<AccionCorrectiva>(accionCorrectiva);
        }
    }
}
