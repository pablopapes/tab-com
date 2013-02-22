using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Frecuencia : Modelo<Frecuencia>
    {
        public virtual string Periodo { get; set; }
        public virtual int CantidadDias { get; set; }
        public virtual IList<Indicador> Indicadores { get; protected set; }
        
        public virtual DateTime ProximaFechaMedicion(DateTime fecha)
        {
            return fecha.AddDays(CantidadDias);
        }
    }
}
