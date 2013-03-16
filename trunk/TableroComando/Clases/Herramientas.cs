using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace TableroComando.Clases
{
    class Herramientas
    {

        public static Chart PropiedadesDelGrafico(String Titulo, String EjeX, String EjeY, Chart Grafico, SeriesChartType tipo)
        {
            Grafico.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            Grafico.BorderlineDashStyle = ChartDashStyle.Solid;
            Grafico.BorderlineColor = Color.CadetBlue;
            Grafico.BorderlineWidth = 3;

            Grafico.Series["Series1"].Points.Clear();
            Grafico.Titles.Add(Titulo);
            Grafico.Titles[0].Text = Titulo;
            Grafico.Titles[0].Font = new Font("Calibri", 14, FontStyle.Bold);
            Grafico.Series["Series2"].LegendText = "Valor Esperado";
            Grafico.Series["Series1"].LegendText = "Mediciones";
            Grafico.Series["Series1"]["LabelStyle"] = "Bottom";
            Grafico.Series["Series1"].ChartType = tipo;
            Grafico.Series["Series1"].Label = "#VALY";
            Grafico.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
            Grafico.Series["Series1"].MarkerSize = 8;
            Grafico.Series["Series1"].MarkerColor = Color.Magenta;
            Grafico.Series["Series1"].MarkerBorderColor = Color.Red;
            Grafico.Series["Series1"].MarkerBorderWidth = 1;
            Grafico.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            Grafico.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            Grafico.ChartAreas["ChartArea1"].AxisX.Title = EjeX;
            Grafico.ChartAreas["ChartArea1"].AxisY.Title = EjeY;

            return Grafico;
        }
    
    }
}
