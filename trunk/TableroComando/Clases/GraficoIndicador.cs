using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using Dominio;
using TableroComando.GUIWrapper;
using TableroComando.Clases;
using System.Globalization;
using System.Threading;
using System.Drawing;


namespace TableroComando.Clases
{
    class GraficoIndicador
    {
        public static Chart Grafico(Chart chart1,Indicador Indicador,DateTime Fecha1,DateTime Fecha2 )
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            Series Series1 = new Series();
            Series Series2 = new Series();
            ChartArea ChartArea1 = new ChartArea();

            chart1.Series.Add(Series1);
            chart1.Series.Add(Series2);
            chart1.ChartAreas.Add(ChartArea1);

            chart1 = Clases.Herramientas.PropiedadesDelGrafico(Indicador.Nombre, "Fechas", "Valores (" + Indicador.Unidad + ")", chart1, SeriesChartType.Line);

            CalcularMetas(chart1,Indicador);

            int i = 0;
            foreach (Medicion medicion in Indicador.Mediciones)
            {
                if ((medicion.Fecha.Date >= Fecha1) & (medicion.Fecha.Date <= Fecha2))
                {
                    chart1.Series["Series1"].Points.Add((double)medicion.Valor);
                    chart1.Series["Series1"].Points[i].AxisLabel = LabelGrafico(Indicador, medicion);
                    chart1.Series["Series2"].Points.Add((double)Indicador.ValorEsperado);
                    i++;
                }
            }

            return chart1;
        }


        private static string LabelGrafico(Indicador indicador, Medicion medicion)
        {
            switch (indicador.Frecuencia.Periodo)
            {
                case "Diaria": return medicion.Fecha.ToShortDateString();
                case "Semanal": return "Sem " + GetWeekNumber(medicion.Fecha).ToString();
                case "Mensual":
                    return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(medicion.Fecha.Month).ToString();
                case "Trimestral":
                    return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(medicion.Fecha.Month).ToString();
                case "Anual": return medicion.Fecha.Year.ToString();
                default: return medicion.Fecha.ToShortDateString();
            }

        }

        public static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }


        private static void MetasGrafico(decimal x, decimal y, Color color, Chart chart1)
        {
            StripLine stripLow = new StripLine();
            stripLow.IntervalOffset = Convert.ToInt32(x);
            stripLow.StripWidth = Convert.ToInt32(y);
            stripLow.BackColor = Color.FromArgb(64, color);
            Axis axisY = chart1.ChartAreas["ChartArea1"].AxisY;
            axisY.StripLines.Add(stripLow);

        }

        private static void CalcularMetas(Chart chart1,Indicador Indicador)
        {

            foreach (Restriccion restriccion in Indicador.Restricciones)
            {
                switch (restriccion.Tipo)
                {
                    case TipoRestriccion.Mayor: MetasGrafico(restriccion.ValorMayor, restriccion.ValorMayor * 10, VisualHelper.GetColor(restriccion.Estado), chart1);
                        break;
                    case TipoRestriccion.Menor: MetasGrafico(restriccion.ValorMayor, restriccion.ValorMenor, VisualHelper.GetColor(restriccion.Estado), chart1);
                        break;
                    case TipoRestriccion.Rango: MetasGrafico(restriccion.ValorMenor, restriccion.ValorMayor - restriccion.ValorMenor, VisualHelper.GetColor(restriccion.Estado), chart1);
                        break;
                }
            }
        }


    }
}
