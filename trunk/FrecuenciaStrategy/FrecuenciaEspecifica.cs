using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrecuenciaStrategy
{
    public abstract class FrecuenciaEspecifica
    {
        public abstract bool RequiereMedicion(DateTime ultimaMedicion);
        public abstract DateTime ProximaMedicion(DateTime ultimaMedicion);

    }
}
