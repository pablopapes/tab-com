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

namespace TableroComando.Formularios
{
    public partial class Form_Monitoreo : Form
    {
        public ObjetivoRepository ObjetivoFachada = ObjetivoRepository.Instance;
            
        public Form_Monitoreo()
        {
            InitializeComponent();
        }

        private void Form_Indicadores_Load(object sender, EventArgs e)
        {
            // Finanzas
            CargarObjetivosDataGridView(FinanzasGridView, ObjetivoFachada.FindByPerspectiva(4));
            
            // Clientes
            CargarObjetivosDataGridView(ClientesGridView, ObjetivoFachada.FindByPerspectiva(3));

            // Procesos Internos
            CargarObjetivosDataGridView(ProcesosGridView, ObjetivoFachada.FindByPerspectiva(2));
           
            // Aprendizaje y Crecimiento
            CargarObjetivosDataGridView(AprendizajeGridView, ObjetivoFachada.FindByPerspectiva(1));
        }

        private void DgvObjFinanzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndicadoresFinancierosGridView.Rows.Add("Beneficio/Inversión", "50%" , "15" , "20" , "133%" , "5", TableroComando.Properties.Resources.menor);
            IndicadoresFinancierosGridView.Rows.Add("Beneficio Neto de Línea", "50%", "$1.000.000", "$1.500.000", "66%","$500.000", TableroComando.Properties.Resources.mayor1);
            IndicadoresFinancierosGridView.Rows[0].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            IndicadoresFinancierosGridView.Rows[1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        /************** Eventos para los grid view de indicadores **************/
        private void IndicadoresClientesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioIndicador(GetObjetoSeleccionado<IndicadorDataGridViewWrapper>(IndicadoresClientesGridView));
        }

        private void IndicadoresProcesosGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioIndicador(GetObjetoSeleccionado<IndicadorDataGridViewWrapper>(IndicadoresProcesosGridView));
        }

        private void IndicadoresAprendizajesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioIndicador(GetObjetoSeleccionado<IndicadorDataGridViewWrapper>(IndicadoresAprendizajesGridView));
        }

        private void IndicadoresFinancierosGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioIndicador(GetObjetoSeleccionado<IndicadorDataGridViewWrapper>(IndicadoresFinancierosGridView));
        }

        /************** Eventos para los grid view de objetivos **************/
        private void ProcesosGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioObjetivo(GetObjetoSeleccionado<ObjetivoDataGridViewWrapper>(ProcesosGridView));
        }

        private void FinanzasGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioObjetivo(GetObjetoSeleccionado<ObjetivoDataGridViewWrapper>(FinanzasGridView));
        }

        private void ClientesGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioObjetivo(GetObjetoSeleccionado<ObjetivoDataGridViewWrapper>(ClientesGridView));
        }

        private void AprendizajeGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioObjetivo(GetObjetoSeleccionado<ObjetivoDataGridViewWrapper>(AprendizajeGridView));
        }

        private void FinanzasGridView_SelectionChanged(object sender, EventArgs e)
        {
            Objetivo objetivo = GetObjetoSeleccionado<ObjetivoDataGridViewWrapper>(FinanzasGridView).GetObjetivo();
            CargarIndicadoresDataGridView(objetivo, IndicadoresFinancierosGridView);
        }

        private void ProcesosGridView_SelectionChanged(object sender, EventArgs e)
        {
            Objetivo objetivo = GetObjetoSeleccionado<ObjetivoDataGridViewWrapper>(ProcesosGridView).GetObjetivo();
            CargarIndicadoresDataGridView(objetivo, IndicadoresProcesosGridView);
        }

        private void ClientesGridView_SelectionChanged(object sender, EventArgs e)
        {
            Objetivo objetivo = GetObjetoSeleccionado<ObjetivoDataGridViewWrapper>(ClientesGridView).GetObjetivo();
            CargarIndicadoresDataGridView(objetivo, IndicadoresClientesGridView);
        }

        private void AprendizajeGridView_SelectionChanged(object sender, EventArgs e)
        {
            Objetivo objetivo = GetObjetoSeleccionado<ObjetivoDataGridViewWrapper>(AprendizajeGridView).GetObjetivo();
            CargarIndicadoresDataGridView(objetivo, IndicadoresAprendizajesGridView);
        }


        /************ Métodos complementarios **************/
        private T GetObjetoSeleccionado<T>(DataGridView grid)
        {
            BindingSource source = (BindingSource)grid.DataSource;
            return (T)source.Current;
        }

        private void AbrirFormularioIndicador(IndicadorDataGridViewWrapper wrapper)
        {
            Form_Indicador f = new Form_Indicador("Actualizar");
            f.Indicador = wrapper.GetIndicador();
            f.ShowDialog();
        }

        private void CargarIndicadoresDataGridView(Objetivo objetivo, DataGridView grid)
        {
            BindingSource source = new BindingSource();
            source.DataSource = objetivo.Indicadores.Select(i => new IndicadorDataGridViewWrapper(i)).ToList();
            grid.DataSource = source;

            grid.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns["Nombre"].Width = 220;
        }

        private void CargarObjetivosDataGridView(DataGridView grid, IList<Objetivo> objetivos)
        {
            BindingSource source = new BindingSource();
            source.DataSource = objetivos.Select(o => new ObjetivoDataGridViewWrapper(o)).ToList();
            grid.DataSource = source;

            grid.Columns["Pertenece"].Visible = false;
            grid.Columns["Perspectiva"].Visible = false;
            grid.Columns["Nombre"].Width = 220;
        }

        private void AbrirFormularioObjetivo(ObjetivoDataGridViewWrapper wrapper)
        {
            Form_AgregarObjetivo f = new Form_AgregarObjetivo("Actualizar");
            f.Objetivo = wrapper.GetObjetivo();
            f.ShowDialog();
        }
    }
}
