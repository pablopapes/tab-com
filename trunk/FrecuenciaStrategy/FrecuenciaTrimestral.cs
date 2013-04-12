using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrecuenciaStrategy
{
    class FrecuenciaTrimestral : FrecuenciaEspecifica
    {
        /**
         *  Requiere medición si el día de hoy es fin de mes y hace tres meses o más que se realizó la última medición
         * 
         * **/
        public override bool RequiereMedicion(DateTime ultimaMedicion)
        {
            int ultimoDiaMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            return ultimoDiaMes == DateTime.Now.Day && ProximaMedicion(ultimaMedicion) <= DateTime.Now; 
        }

        public override DateTime ProximaMedicion(DateTime ultimaMedicion)
        {
            return ultimaMedicion.AddMonths(3);
        }
    }
}
