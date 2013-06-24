using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrecuenciaStrategy
{
    public class FrecuenciaMensual : FrecuenciaEspecifica
    {
        public override bool RequiereMedicion(DateTime ultimaMedicion)
        {
            //int ultimoDiaMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            //return ultimoDiaMes == DateTime.Now.Day || ProximaMedicion(ultimaMedicion) <= DateTime.Now;
            return (ProximaMedicion(ultimaMedicion) <= DateTime.Now) && (ProximaMedicion(ultimaMedicion).Year <= DateTime.Now.Year);
        }

        public override DateTime ProximaMedicion(DateTime ultimaMedicion)
        {
            return ultimaMedicion.AddMonths(1);
        }
    }
}
