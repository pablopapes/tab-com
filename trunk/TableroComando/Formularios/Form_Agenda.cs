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
        Indicador IndicadorSeleccionado
        {
            get
            {
                return ((IndicadorDataGridViewWrapper)_sourceIndicadores.Current).GetIndicador();
            }
        }
        
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
            _sourceIndicadores.DataSource = IndicadorRepository.Instance.FindByRequiereMedicion().Select( i => new IndicadorDataGridViewWrapper(i));
            IndicadoresDataGrid.DataSource = _sourceIndicadores;

            IndicadoresDataGrid.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndicadoresDataGrid.Columns["UltimaMedicion"].Visible = false;
            IndicadoresDataGrid.Columns["UltimaMedicion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            IndicadoresDataGrid.Columns["ProximaFechaMedicion"].HeaderText = "Fecha de Medición";
            IndicadoresDataGrid.Columns["ProximaFechaMedicion"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void IndicadoresDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CamposMedicionGroup.Text = IndicadorSeleccionado.ToString();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(ValorTxt.Text, out valor))
            {
                IndicadorSeleccionado.AddMedicion(FechaMedicionDtp.Value, valor, DetalleTxt.Text);
            }

            IndicadorRepository.Instance.Save(IndicadorSeleccionado);
            _sourceIndicadores.RemoveCurrent();
            ValorTxt.Text = "";
            FechaMedicionDtp.Value = DateTime.Now;
        }
    }
}
