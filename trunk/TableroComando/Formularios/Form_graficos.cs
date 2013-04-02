using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Fachadas;
using Dominio;
using TableroComando.GUIWrapper;
using System.Windows.Forms.DataVisualization.Charting;
using TableroComando.Clases;
using System.Globalization;

namespace TableroComando.Formularios
{
    public partial class Form_graficos : Form
    {
        public Indicador Indicador { get; set; }

        public Form_graficos()
        {
            InitializeComponent();
        }

        private void Form_graficos_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = true;
            chart1.Printing.Print(true);
        }

        private void MetasGrafico(decimal x , decimal y, Color color)
        {
            StripLine stripLow = new StripLine();
            stripLow.IntervalOffset = Convert.ToInt32(x);
            stripLow.StripWidth = Convert.ToInt32(y);
            stripLow.BackColor = Color.FromArgb(64, color);
            Axis axisY = chart1.ChartAreas["ChartArea1"].AxisY;
            axisY.StripLines.Add(stripLow);

        }

        private void CalcularMetas()
        {
      
            foreach (Restriccion restriccion in Indicador.Restricciones)
            {
                switch (restriccion.Tipo)
                {
                    case TipoRestriccion.Mayor: MetasGrafico(restriccion.ValorMayor, restriccion.ValorMayor * 10, VisualHelper.GetColor(restriccion.Estado));
                        break;
                    case TipoRestriccion.Menor: MetasGrafico(restriccion.ValorMayor, restriccion.ValorMenor, VisualHelper.GetColor(restriccion.Estado));
                        break;
                    case TipoRestriccion.Rango: MetasGrafico(restriccion.ValorMenor, restriccion.ValorMayor - restriccion.ValorMenor, VisualHelper.GetColor(restriccion.Estado));
                        break;
                }
            }
        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            
        }

        private string LabelGrafico(Indicador indicador,Medicion medicion)
        {
            switch (indicador.Frecuencia.Periodo)
            {
                case "Diaria": return medicion.Fecha.ToShortDateString();
                    break;
                case "Semanal": return "Sem " + GetWeekNumber(medicion.Fecha).ToString();
                    break;
                case "Mensual": 
                    System.Globalization.DateTimeFormatInfo mes = new 
                    System.Globalization.DateTimeFormatInfo();
                    return mes.GetAbbreviatedMonthName(medicion.Fecha.Month).ToString();  
                    break;
                case "Trimestral": 
                    System.Globalization.DateTimeFormatInfo trimestre = new
                   System.Globalization.DateTimeFormatInfo();
                    return trimestre.GetAbbreviatedMonthName(medicion.Fecha.Month).ToString();  
                    break;
                case "Anual": return medicion.Fecha.Year.ToString();
                    break;
                default: return medicion.Fecha.ToShortDateString();
                    break;
            }

        }

             public static int GetWeekNumber(DateTime dtPassed)
            {
          CultureInfo ciCurr = CultureInfo.CurrentCulture;
          int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
          return weekNum;
            }

        private void BtnGenerarGrafico_Click(object sender, EventArgs e)
        {
            
            chart1 = Clases.Herramientas.PropiedadesDelGrafico(Indicador.Nombre, "Fechas", "Valores", chart1, SeriesChartType.Line);

            CalcularMetas();

            int i = 0;
            foreach (Medicion medicion in Indicador.Mediciones)
            {
                if ((medicion.Fecha.Date >= dateTimePicker1.Value) & (medicion.Fecha.Date <= dateTimePicker2.Value))
                {

                    chart1.Series["Series1"].Points.Add((double)medicion.Valor);
                    chart1.Series["Series1"].Points[i].AxisLabel = LabelGrafico(Indicador, medicion);
                    chart1.Series["Series2"].Points.Add((double)Indicador.ValorEsperado);
                    i++;
                }
            }
        }

    }
}
