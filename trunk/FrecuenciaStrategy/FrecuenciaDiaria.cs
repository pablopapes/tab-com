using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrecuenciaStrategy
{
    class FrecuenciaDiaria : FrecuenciaEspecifica
    {
        public override bool RequiereMedicion(DateTime ultimaMedicion)
        {
           return ProximaMedicion(ultimaMedicion.Date) <= DateTime.Now.Date;

        }

        public override DateTime ProximaMedicion(DateTime ultimaMedicion)
        {
            return ultimaMedicion.AddDays(1);
        }
    }
}
