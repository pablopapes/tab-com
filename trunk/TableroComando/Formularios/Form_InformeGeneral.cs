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
using Repositorios;
using TableroComando.Clases;
using Repositorios;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;
using Dataweb.NShape.GeneralShapes;
using Dataweb.NShape.Layouters;

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
            Diagram diagram = new Diagram("D1");
            //Project project = new Project();
            //XmlStore xml = new XmlStore();
            diagram = Clases.MapaEstrategico.CrearMapa(project1, diagram, xmlStore1);

            Image ImageMapa = diagram.CreateImage(ImageFileFormat.Png);
            ImageMapa.Save( Application.StartupPath + "\\TempMapa.png", System.Drawing.Imaging.ImageFormat.Png);

            ImageMapa = Clases.Herramientas.resizeImage(650, 600, Application.StartupPath + "\\TempMapa.png");

            ImageMapa.Save(Application.StartupPath + "\\TempMapa1.png", System.Drawing.Imaging.ImageFormat.Png);

            Reportes.DSPerspectiva DsPerspectiva = new Reportes.DSPerspectiva();

            // Cargo el Mapa
            DataRow FilaMapa = DsPerspectiva.Tables["Mapa"].NewRow();
            FilaMapa["Mapa"] = Clases.Herramientas.ConversionImagen(Application.StartupPath + "\\TempMapa1.png");
            DsPerspectiva.Tables["Mapa"].Rows.Add(FilaMapa);
            DsPerspectiva.Tables["Mapa"].AcceptChanges();


            // Restricciones
            IList<RestriccionObjetivo> restriccionesObj = RestriccionGeneralRepository.Instance.All<RestriccionObjetivo>();
            IList<RestriccionPerspectiva> restriccionesPersp = RestriccionGeneralRepository.Instance.All<RestriccionPerspectiva>();

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
            IList<Frecuencia> ListaFrecuencias = FrecuenciaRepository.Instance.All();
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
                // Cargo el color segun el estado
                Color Color = VisualHelper.GetColor(Perspectiva.Estado(restriccionesPersp));
                int? ColorPersp = null;
                if (Color == System.Drawing.Color.Green) ColorPersp = 1;
                else
                    if (Color == System.Drawing.Color.Yellow) ColorPersp = 0;
                    else
                        if (Color == System.Drawing.Color.Red) ColorPersp = -1;
                        else
                            if (Color == System.Drawing.Color.White) ColorPersp = 2;

                FilaPerspectiva["Color"] = ColorPersp;

                DsPerspectiva.Tables["Perspectivas"].Rows.Add(FilaPerspectiva);

                DsPerspectiva.Tables["Perspectivas"].AcceptChanges();


                // Cargo el Objetivo
                foreach (Objetivo Objetivo in Perspectiva.Objetivos)
                {
                    DataRow FilaObjetivo = DsPerspectiva.Tables["Objetivos"].NewRow();
                    FilaObjetivo["Id"] = Objetivo.Id;
                    FilaObjetivo["Nombre"] = Objetivo.Nombre;
                    FilaObjetivo["perspectiva_id"] = Objetivo.Perspectiva.Id;
                    
                    // Cargo el color segun el estado
                     Color = VisualHelper.GetColor(Objetivo.Estado(restriccionesObj));

                    int? ColorObj = null;
                    if (Color == System.Drawing.Color.Green) ColorObj = 1;
                    else
                        if (Color == System.Drawing.Color.Yellow) ColorObj = 0;
                        else
                            if (Color == System.Drawing.Color.Red) ColorObj = -1;
                            else
                                if (Color == System.Drawing.Color.White) ColorObj = 2;

                    FilaObjetivo["Color"] = ColorObj;

                    DsPerspectiva.Tables["Objetivos"].Rows.Add(FilaObjetivo);
                    DsPerspectiva.Tables["Objetivos"].AcceptChanges();

                    // Cargo el Indicador

                    foreach (Indicador Indicador in Objetivo.Indicadores)
                    {
                        DataRow Filaindicador = DsPerspectiva.Tables["indicadores"].NewRow();
                        Filaindicador["Id"] = Indicador.Id;
                        Filaindicador["nombre"] = Indicador.Nombre;
                        Filaindicador["codigo"] = Indicador.Codigo;
                        Filaindicador["ValorEsperado"] = Indicador.ValorEsperado;
                        Filaindicador["objetivo_id"] = Indicador.Objetivo.Id;
                        Filaindicador["responsable_id"] = Indicador.Responsable.Id;
                        Filaindicador["frecuencia_id"] = Indicador.Frecuencia.Id;

                         // Cargo el color segun el estado
                         Color =VisualHelper.GetColor(Indicador.Estado);
                        int? ColorInd = null;
                        if (Color == System.Drawing.Color.Green) ColorInd = 1; else
                            if (Color == System.Drawing.Color.Yellow) ColorInd = 0;
                            else
                                if (Color == System.Drawing.Color.Red) ColorInd = -1;
                                else
                                    if (Color == System.Drawing.Color.White) ColorInd = 2;

                        Filaindicador["Color"] = ColorInd;

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
