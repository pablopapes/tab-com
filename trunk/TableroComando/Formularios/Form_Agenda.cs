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
            _sourceIndicadores.DataSource = IndicadorRepository.Instance.FindByRequiereMedicion();
            IndicadoresDataGrid.DataSource = _sourceIndicadores;
        }

        private void IndicadoresDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Frecuencia f = ((Indicador)_sourceIndicadores.Current).Frecuencia;
            Console.WriteLine(f.FrecuenciaEspecifica);
        }

    }
}
