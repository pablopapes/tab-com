using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace FrecuenciaStrategy
{
    class FrecuenciaAnual : FrecuenciaEspecifica
    {
        public override bool RequiereMedicion(DateTime ultimaMedicion)
        {
            DateTime lastDayYear = new DateTime(DateTime.Now.Year, 12, 31);
            // Obtengo el número de la última semana del año
            int lastWeekNumber = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(lastDayYear, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            // Obtengo el número de la semana actual del año
            int currentWeekNumber = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            return (lastWeekNumber - currentWeekNumber) <= 1;

        }

        public override DateTime ProximaMedicion(DateTime ultimaMedicion)
        {
            return ultimaMedicion.AddYears(1);
        }
    }
}
