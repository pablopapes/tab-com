using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Fachadas;
using TableroComando.GUIWrapper;
using Dominio;

namespace TableroComando.Formularios
{
    public partial class Form_Agenda : Form
    {
        BindingSource _sourceIndicadores = new BindingSource();
        public IndicadorRepository Repo;

        public Form_Agenda()
        {
            InitializeComponent();
        }

        private void Form_Agenda_Load(object sender, EventArgs e)
        {
            ConfigurarIndicadoresDataGrid();
        }

        private void ConfigurarIndicadoresDataGrid()
        {
            
            _sourceIndicadores.DataSource = Repo.FindByRequiereMedicion().Select( i => new IndicadorDataGridViewWrapper(i));
            IndicadoresDataGrid.DataSource = _sourceIndicadores;

            IndicadoresDataGrid.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void IndicadoresDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Frecuencia f = ((Indicador)_sourceIndicadores.Current).Frecuencia;
            
        }   

    }
}
