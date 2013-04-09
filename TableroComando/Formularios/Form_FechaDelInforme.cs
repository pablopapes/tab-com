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
using System.Globalization;
using TableroComando.Clases;
using System.IO;

namespace TableroComando.Formularios
{
    public partial class Form_InformeIndicador : Form
    {
        Indicador Indicador;
        System.Windows.Forms.DataVisualization.Charting.Chart chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        System.Windows.Forms.DataVisualization.Charting.Series Series1 = new Series();
        Series Series2 = new Series();
        ChartArea ChartArea1 = new ChartArea();

        public Form_InformeIndicador(Indicador indicador)
        {
            this.Indicador = indicador;
            InitializeComponent();

        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {

            Reportes.DsIndicador DsIndicador = new Reportes.DsIndicador();
            // Cargo el grafico en la carpeta Temp
            Chart chart1 = new Chart();
            chart1.Width = 600;
            chart1 = Clases.GraficoIndicador.Grafico(chart1, Indicador, dateTimePicker1.Value, dateTimePicker2.Value);
            ChartImageFormat format = ChartImageFormat.Png;
            chart1.SaveImage(Application.StartupPath + "\\TempGrafico.png", format);

            // Cargo el Indicador
                DataRow Filaindicador = DsIndicador.Tables["indicadores"].NewRow();
                Filaindicador["Id"] = Indicador.Id;
                Filaindicador["nombre"] = Indicador.Nombre;
                Filaindicador["codigo"] = Indicador.Codigo;
                Filaindicador["responsable_id"] = Indicador.Responsable.Id;
                Filaindicador["frecuencia_id"] = Indicador.Frecuencia.Id;
                Filaindicador["Grafico"] =Clases.Herramientas.ConversionImagen(Application.StartupPath + "\\TempGrafico.png");
               
              // Cargo el color segun el estado
                Color Color = VisualHelper.GetColor(Indicador.Estado);
                int? ColorInd = null;
                if (Color == System.Drawing.Color.Green) ColorInd = 1;
                else
                    if (Color == System.Drawing.Color.Yellow) ColorInd = 0;
                    else
                        if (Color == System.Drawing.Color.Red) ColorInd = -1;
                Filaindicador["Color"] = ColorInd;

                DsIndicador.Tables["indicadores"].Rows.Add(Filaindicador);
                DsIndicador.Tables["indicadores"].AcceptChanges();

            // Cargo el responsable

                 DataRow FilaResponsable = DsIndicador.Tables["responsables"].NewRow();
                 FilaResponsable["Id"] = Indicador.Responsable.Id;
                 FilaResponsable["Area"] = Indicador.Responsable.Area;
                 FilaResponsable["Persona"] = Indicador.Responsable.Persona;
                 FilaResponsable["Codigo"] = Indicador.Responsable.Codigo;

                 DsIndicador.Tables["responsables"].Rows.Add(FilaResponsable);
                 DsIndicador.Tables["responsables"].AcceptChanges();
            

            // Cargo la Frecuencia
                 DataRow FilaFrecuencia = DsIndicador.Tables["frecuencias"].NewRow();
                 FilaFrecuencia["Id"] = Indicador.Frecuencia.Id;
                 FilaFrecuencia["Periodo"] = Indicador.Frecuencia.Periodo;


                 DsIndicador.Tables["frecuencias"].Rows.Add(FilaFrecuencia);
                 DsIndicador.Tables["frecuencias"].AcceptChanges();

            


            // Cargo Las mediciones

            foreach(Medicion medicion in Indicador.Mediciones)
            {
                if ((medicion.Fecha.Date >= dateTimePicker1.Value) & (medicion.Fecha.Date <= dateTimePicker2.Value))
                {
                    DataRow FilaMedicion = DsIndicador.Tables["mediciones"].NewRow();
                    FilaMedicion["Id"] = medicion.Id;
                    FilaMedicion["Detalle"] = medicion.Detalle;
                    FilaMedicion["Fecha"] = medicion.Fecha.Date;
                    FilaMedicion["Valor"] = medicion.Valor;
                    FilaMedicion["indicador_id"] = medicion.Indicador.Id;
                    //FilaMedicion["frecuencia_id"] = medicion.Frecuencia.Id;

                    DsIndicador.Tables["mediciones"].Rows.Add(FilaMedicion);
                }
            }

            DsIndicador.Tables["mediciones"].AcceptChanges();

           
            
            Reportes.CrIndicadores reporte = new Reportes.CrIndicadores();
            reporte.SetDataSource(DsIndicador);

            // Fecha de Medición
            reporte.SetParameterValue("FechaDesde", dateTimePicker1.Value.Date);
            reporte.SetParameterValue("FechaHasta", dateTimePicker2.Value.Date);
            
         

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();

        }

        

        

        private void Form_InformeIndicador_Load(object sender, EventArgs e)
        {
           
        }

    }
}
