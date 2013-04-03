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
    public partial class Form_InformeGeneral : Form
    {

        IList<Perspectiva> ListaPerspectiva;

        public Form_InformeGeneral(IList<Perspectiva> ListaPerspectiva)
        {
            this.ListaPerspectiva = ListaPerspectiva;
            InitializeComponent();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            Reportes.DSPerspectiva DsPerspectiva = new Reportes.DSPerspectiva();

            // Cargo el responsable
            IList<Responsable> ListaResponsable = ResponsableRepository.Instance.All();
            foreach (Responsable Responsable in ListaResponsable)
            {
                DataRow FilaResponsable = DsPerspectiva.Tables["responsables"].NewRow();
                FilaResponsable["Id"] = Responsable.Id;
                FilaResponsable["Area"] = Responsable.Area;
                FilaResponsable["Persona"] = Responsable.Persona;
                FilaResponsable["Codigo"] = Responsable.Codigo;

                DsPerspectiva.Tables["responsables"].Rows.Add(FilaResponsable);
            }
            DsPerspectiva.Tables["responsables"].AcceptChanges();


            // Cargo la Frecuencia
            IList<Frecuencia> ListaFrecuencias = IndicadorRepository.Instance.AllFrecuencias();
            foreach (Frecuencia Frecuencia in ListaFrecuencias)
            {
                DataRow FilaFrecuencia = DsPerspectiva.Tables["frecuencias"].NewRow();
                FilaFrecuencia["Id"] = Frecuencia.Id;
                FilaFrecuencia["Periodo"] = Frecuencia.Periodo;
                DsPerspectiva.Tables["frecuencias"].Rows.Add(FilaFrecuencia);
            }
            DsPerspectiva.Tables["frecuencias"].AcceptChanges();


            // Cargo la perspectiva
            foreach (Perspectiva Perspectiva in ListaPerspectiva)
            {
                DataRow FilaPerspectiva = DsPerspectiva.Tables["Perspectivas"].NewRow();
                FilaPerspectiva["Id"] = Perspectiva.Id;
                FilaPerspectiva["Nombre"] = Perspectiva.Nombre;

                DsPerspectiva.Tables["Perspectivas"].Rows.Add(FilaPerspectiva);

                DsPerspectiva.Tables["Perspectivas"].AcceptChanges();


                // Cargo el Objetivo
                foreach (Objetivo Objetivo in Perspectiva.Objetivos)
                {
                    DataRow FilaObjetivo = DsPerspectiva.Tables["Objetivos"].NewRow();
                    FilaObjetivo["Id"] = Objetivo.Id;
                    FilaObjetivo["Nombre"] = Objetivo.Nombre;
                    FilaObjetivo["perspectiva_id"] = Objetivo.Perspectiva.Id;
                    DsPerspectiva.Tables["Objetivos"].Rows.Add(FilaObjetivo);
                    DsPerspectiva.Tables["Objetivos"].AcceptChanges();

                    // Cargo el Indicador
                    foreach (Indicador Indicador in Objetivo.Indicadores)
                    {
                        DataRow Filaindicador = DsPerspectiva.Tables["indicadores"].NewRow();
                        Filaindicador["Id"] = Indicador.Id;
                        Filaindicador["nombre"] = Indicador.Nombre;
                        Filaindicador["codigo"] = Indicador.Codigo;
                        Filaindicador["objetivo_id"] = Indicador.Objetivo.Id;
                        Filaindicador["responsable_id"] = Indicador.Responsable.Id;
                        Filaindicador["frecuencia_id"] = Indicador.Frecuencia.Id;

                        DsPerspectiva.Tables["indicadores"].Rows.Add(Filaindicador);
                        DsPerspectiva.Tables["indicadores"].AcceptChanges();

                        // Cargo Las mediciones

                        foreach (Medicion medicion in Indicador.Mediciones)
                        {
                            if ((medicion.Fecha.Date >= dateTimePicker1.Value) & (medicion.Fecha.Date <= dateTimePicker2.Value))
                            {
                                DataRow FilaMedicion = DsPerspectiva.Tables["mediciones"].NewRow();
                                FilaMedicion["Id"] = medicion.Id;
                                FilaMedicion["Detalle"] = medicion.Detalle;
                                FilaMedicion["Fecha"] = medicion.Fecha.Date;
                                FilaMedicion["Valor"] = medicion.Valor;
                                FilaMedicion["indicador_id"] = medicion.Indicador.Id;
                                // FilaMedicion["frecuencia_id"] = medicion.Frecuencia.Id;

                                DsPerspectiva.Tables["mediciones"].Rows.Add(FilaMedicion);

                            }
                        }

                        DsPerspectiva.Tables["mediciones"].AcceptChanges();
                    }
                }
            }
            Reportes.CRInformeGeneral reporte = new Reportes.CRInformeGeneral();
            reporte.SetDataSource(DsPerspectiva);

            /* Fecha de Medición
            reporte.SetParameterValue("FechaDesde", dateTimePicker1.Value.Date);
            reporte.SetParameterValue("FechaHasta", dateTimePicker2.Value.Date);
            */

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();
        }

        private void Form_InformeGeneral_Load(object sender, EventArgs e)
        {
        
        }
    }
}
