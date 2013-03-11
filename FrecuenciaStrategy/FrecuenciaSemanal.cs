using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrecuenciaStrategy
{
    class FrecuenciaSemanal : FrecuenciaEspecifica
    {
        public override bool RequiereMedicion(DateTime ultimaMedicion)
        {
            return DayOfWeek.Friday == DateTime.Now.DayOfWeek || ProximaMedicion(ultimaMedicion) <= DateTime.Now;
        }

        public override DateTime ProximaMedicion(DateTime ultimaMedicion)
        {
            return ultimaMedicion.AddDays(7);
        }
    }
}
