using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Dominio;
using Dominio;
using TableroComando.GUIWrapper;
using System.Windows.Forms.DataVisualization.Charting;
using TableroComando.Clases;
using System.Globalization;
using System.Threading;

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

        

        private void BtnGenerarGrafico_Click(object sender, EventArgs e)
        {

            chart1 = Clases.GraficoIndicador.Grafico(chart1,Indicador, dateTimePicker1.Value, dateTimePicker2.Value);
        }

    }
}
