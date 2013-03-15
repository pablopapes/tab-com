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

namespace TableroComando.Formularios
{
    public partial class Form_graficos : Form
    {
        private ObjetivoRepository _objetivoFachada = ObjetivoRepository.Instance;
        private BindingSource _sourceMediciones;
        public Indicador Indicador { get; set; }

        public Form_graficos()
        {
            InitializeComponent();
        }

        private void Form_graficos_Load(object sender, EventArgs e)
        {
            //ConfigurarObjetivosCB();
            chart1 = Clases.Herramientas.PropiedadesDelGrafico(Indicador.Nombre, "Fechas", "Valores", chart1, SeriesChartType.Line);
           
            int i = 0;
            foreach (Medicion medicion in Indicador.Mediciones)
            {

                chart1.Series["Series1"].Points.Add((double)medicion.Valor);
                chart1.Series["Series1"].Points[i].AxisLabel = medicion.Fecha.ToShortDateString();
                chart1.Series["Series2"].Points.Add(230000/*(double)Indicador.ValorEsperado*/);
                i++;
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = true;
            chart1.Printing.Print(true);
          

        }

    }
}
