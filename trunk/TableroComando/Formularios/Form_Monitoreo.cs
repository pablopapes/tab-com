using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Fachadas;
using TableroComando.Clases.Models;

namespace TableroComando.Formularios
{
    public partial class Form_Monitoreo : Form
    {
        public ObjetivoFachada ObjetivoFachada;
            
        public Form_Monitoreo()
        {
            InitializeComponent();
        }

        private void Form_Indicadores_Load(object sender, EventArgs e)
        {
            // Finanzas
            CargarObjetivos(FinanzasGridView, ObjetivoFachada.FindByPerspectiva(4));
            
            // Clientes
            CargarObjetivos(ClientesGridView, ObjetivoFachada.FindByPerspectiva(3));

            // Procesos Internos
            CargarObjetivos(ProcesosGridView, ObjetivoFachada.FindByPerspectiva(2));
           
            // Aprendizaje y Crecimiento
            CargarObjetivos(AprendizajeGridView, ObjetivoFachada.FindByPerspectiva(1));
        }

        private void DgvObjFinanzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndicadoresFinancierosGridView.Rows.Add("Beneficio/Inversión", "50%" , "15" , "20" , "133%" , "5", TableroComando.Properties.Resources.menor);
            IndicadoresFinancierosGridView.Rows.Add("Beneficio Neto de Línea", "50%", "$1.000.000", "$1.500.000", "66%","$500.000", TableroComando.Properties.Resources.mayor1);
            IndicadoresFinancierosGridView.Rows[0].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            IndicadoresFinancierosGridView.Rows[1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void FinanzasGridView_SelectionChanged(object sender, EventArgs e)
        {
            Objetivo objetivo = GetObjetoSeleccionado<Objetivo>(FinanzasGridView);
            CargarIndicadores(objetivo, IndicadoresFinancierosGridView);
        }

        private void ProcesosGridView_SelectionChanged(object sender, EventArgs e)
        {
            Objetivo objetivo = GetObjetoSeleccionado<Objetivo>(ProcesosGridView);
            CargarIndicadores(objetivo, IndicadoresProcesosGridView);
        }

        private void ClientesGridView_SelectionChanged(object sender, EventArgs e)
        {
            Objetivo objetivo = GetObjetoSeleccionado<Objetivo>(ClientesGridView);
            CargarIndicadores(objetivo, IndicadoresClientesGridView);
        }

        private void AprendizajeGridView_SelectionChanged(object sender, EventArgs e)
        {
            Objetivo objetivo = GetObjetoSeleccionado<Objetivo>(AprendizajeGridView);
            CargarIndicadores(objetivo, IndicadoresAprendizajesGridView);
        }

        /* Eventos para los grid view de indicadores */
        private void IndicadoresClientesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioIndicador(GetObjetoSeleccionado<Indicador>(IndicadoresClientesGridView));
        }

        private void IndicadoresProcesosGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioIndicador(GetObjetoSeleccionado<Indicador>(IndicadoresProcesosGridView));
        }

        private void IndicadoresAprendizajesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioIndicador(GetObjetoSeleccionado<Indicador>(IndicadoresAprendizajesGridView));
        }

        private void IndicadoresFinancierosGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioIndicador(GetObjetoSeleccionado<Indicador>(IndicadoresFinancierosGridView));
        }

        /* Métodos complementarios */
        private T GetObjetoSeleccionado<T>(DataGridView grid)
        {
            BindingSource source = (BindingSource)grid.DataSource;
            return (T)source.Current;
        }

        private void AbrirFormularioIndicador(Indicador indicador)
        {
            Form_Indicador f = new Form_Indicador("Actualizar");
            f.Indicador = indicador;
            f.ShowDialog();
        }

        private void CargarIndicadores(Objetivo objetivo, DataGridView grid)
        {
            BindingSource source = new BindingSource();
            source.DataSource = objetivo.Indicadores;
            grid.DataSource = source;
        }

        private void CargarObjetivos(DataGridView grid, IList<Objetivo> objetivos)
        {
            BindingSource source = new BindingSource();
            source.DataSource = objetivos;
            grid.DataSource = source;
        }

    }
}
