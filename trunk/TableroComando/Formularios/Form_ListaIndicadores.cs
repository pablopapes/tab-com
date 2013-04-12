using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Dominio;
using TableroComando.GUIWrapper;
using Dominio;
using TableroComando.Clases;

namespace TableroComando.Formularios
{
    public partial class Form_ListaIndicadores : Form
    {
        BindingSource _sourceIndicador = new BindingSource();
        public Form_ListaIndicadores()
        {
            InitializeComponent();
        }

        private void Form_ListaIndicadores_Load(object sender, EventArgs e)
        {
            ConfigurarIndicadoresDataGrid();
        }

        private void ConfigurarIndicadoresDataGrid()
        {
            IList<Indicador> indicadores = IndicadorRepository.Instance.All();
            if (indicadores.Count != 0)
            {
                _sourceIndicador.DataSource = indicadores.Select(i => new IndicadorDataGridViewWrapper(i));
                IndicadoresDataGrid.DataSource = _sourceIndicador;

                IndicadoresDataGrid.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Form_Indicador f = new Form_Indicador(new CreateMode());
            f.ShowDialog();
            if (f.Guardado)
            {
                // Se agrega un wrapper del nuevo indicador que se acaba de crear.
                _sourceIndicador.Add(new IndicadorDataGridViewWrapper(f.Indicador));
            }
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            Indicador indicador = GetIndicadorSeleccionado();
            IndicadorRepository.Instance.Delete(indicador);
            _sourceIndicador.RemoveCurrent();
        }

        private void IndicadoresDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Indicador f = new Form_Indicador(new UpdateMode());
            f.Indicador = GetIndicadorSeleccionado();
            f.ShowDialog();
            
        }

        private Indicador GetIndicadorSeleccionado()
        {
             return ((IndicadorDataGridViewWrapper)_sourceIndicador.Current).GetIndicador();
        }

    }
}
