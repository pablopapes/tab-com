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

namespace TableroComando.Formularios
{
    public partial class Form_InformeIndicador : Form
    {
        Indicador Indicador;

        public Form_InformeIndicador(Indicador indicador)
        {
            this.Indicador = indicador;
            InitializeComponent();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {

            Reportes.DsIndicador DsIndicador = new Reportes.DsIndicador();
            
            // Cargo el Indicador
                DataRow Filaindicador = DsIndicador.Tables["indicadores"].NewRow();
                Filaindicador["Id"] = Indicador.Id;
                Filaindicador["nombre"] = Indicador.Nombre;
                Filaindicador["codigo"] = Indicador.Codigo;
                Filaindicador["responsable_id"] = Indicador.Responsable.Id;
                Filaindicador["frecuencia_id"] = Indicador.Frecuencia.Id;

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
                    // FilaMedicion["frecuencia_id"] = medicion.Frecuencia.Id;

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
    }
}
