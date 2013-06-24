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
using Dominio.Validations.Results;
using TableroComando.Clases;

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
            IList<IndicadorDataGridViewWrapper> indicadores = IndicadorRepository.Instance.FindByRequiereMedicion().Select(i => new IndicadorDataGridViewWrapper(i)).ToList();
            if (indicadores.Count != 0)
            {
                _sourceIndicadores.DataSource = indicadores;
                IndicadoresDataGrid.DataSource = _sourceIndicadores;

                IndicadoresDataGrid.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                IndicadoresDataGrid.Columns["UltimaMedicion"].Visible = false;
                IndicadoresDataGrid.Columns["UltimaMedicion"].DefaultCellStyle.Format = "dd/MM/yyyy";
                IndicadoresDataGrid.Columns["ProximaFechaMedicion"].HeaderText = "Fecha de Medición";
                IndicadoresDataGrid.Columns["ProximaFechaMedicion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            try
            {
                IndicadorDataGridViewWrapper wrapper = (IndicadorDataGridViewWrapper)_sourceIndicadores.Current;
                if (wrapper.GetIndicador().RequiereMedicion == false)
                {
                    _sourceIndicadores.RemoveCurrent();
                }
            }
            catch
            {

            }
           
        }

        private void IndicadoresDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CamposMedicionGroup.Text = IndicadorSeleccionado.ToString();
            FechaMedicionDtp.Value = IndicadorSeleccionado.ProximaFechaMedicion;
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(ValorTxt.Text, out valor))
            {
                Medicion medicion = IndicadorSeleccionado.CrearMedicion();
                medicion.Valor = valor;
                medicion.Fecha = FechaMedicionDtp.Value;
                medicion.Detalle = DetalleTxt.Text;
                ValidationResult result = medicion.Validate();
                if (result.IsValid)
                {
                    IndicadorSeleccionado.Mediciones.Add(medicion);
                    IndicadorRepository.Instance.Save(IndicadorSeleccionado);
                    ValorTxt.Text = "";
                    DetalleTxt.Text = "";
                    FechaMedicionDtp.Value = IndicadorSeleccionado.ProximaFechaMedicion;
                    ConfigurarIndicadoresDataGrid();
                }
                else
                {
                    MessageBoxHelper.ShowValidationFailure(result.Errors);
                }
            }
            else
            {
                MessageBox.Show("El campo 'Valor' debe completarse", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
