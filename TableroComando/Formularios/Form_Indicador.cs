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
using System.Globalization;
using Dominio.Validations.Results;
using TableroComando.Clases;
using Repositorios;

namespace TableroComando.Formularios
{
    public partial class Form_Indicador : Form
    {
        private FormMode _mode;
        private ObjetivoRepository _objetivoFachada = ObjetivoRepository.Instance;
        private BindingSource _sourceMediciones;
        public Indicador Indicador { get; set; }
        public bool Guardado { get; protected set; }


        public Form_Indicador(FormMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void Form_AgregarIndicador_Load(object sender, EventArgs e)
        {
            /* Si no se seteó ningún indicador, se crea uno nuevo */
            if (Indicador == null)
                Indicador = new Indicador();

            /* Se cargan los objetivos en un combobox y se setean algunas propiedades */
            ConfigurarObjetivosCB();
            ConfigurarFrecuenciasCB();
            ConfigurarResponsablesCB();
            
            CargarPropiedadesIndicador();
            
            ConfigurarMedicioinesGridView(); // Se cargan las mediciones en el datagrid y se setean algunas propiedades
        }

        private void ConfigurarMedicioinesGridView()
        {
            _sourceMediciones = new BindingSource();
            _sourceMediciones.DataSource = Indicador.Mediciones
                .Select(m => new MedicionDataGridViewWrapper(m))
                .ToList();
            MedicionesGridView.DataSource = _sourceMediciones;
            MedicionesGridView.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void ConfigurarResponsablesCB()
        {
            ResponsableCB.DataSource = ResponsableRepository.Instance.All();
            ResponsableCB.DisplayMember = "Area";
            if (Indicador.Responsable == null) 
                ResponsableCB.SelectedIndex = -1;
        }

        private void ConfigurarFrecuenciasCB()
        {           
            FrecuenciasCB.DisplayMember = "Periodo";
            FrecuenciasCB.DataSource = FrecuenciaRepository.Instance.All();       
            if (Indicador.Frecuencia == null) 
                FrecuenciasCB.SelectedIndex = -1;   
        }

        private void ConfigurarObjetivosCB()
        {
            ObjetivosCB.DataSource = _objetivoFachada.All();
            ObjetivosCB.DisplayMember = "Nombre";
            if (Indicador.Objetivo == null) ObjetivosCB.SelectedIndex = -1;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            ValidationResult result = IndicadorRepository.Instance.Save(Indicador);
            if (result.IsValid)
            {
                _mode.AfterSave<Form_Indicador>(this);
                Guardado = true;
            }
            else
            {
                MessageBoxHelper.ShowValidationFailure(result.Errors);
            }
        }

        private void CargarPropiedadesIndicador()
        {            
            NombreTxt.DataBindings.Add("Text", Indicador, "Nombre");
            CodigoTxt.DataBindings.Add("Text", Indicador, "Codigo");
            FormulaTxt.DataBindings.Add("Text", Indicador, "Calculo");
            CaracteristicaTxt.DataBindings.Add("Text", Indicador, "Caracteristica");
            PropositoTxt.DataBindings.Add("Text", Indicador, "Proposito");
            
            UnidadTxt.DataBindings.Add("Text", Indicador, "Unidad");

            ObjetivosCB.DataBindings.Add("SelectedItem", Indicador, "Objetivo");
            ResponsableCB.DataBindings.Add("SelectedItem", Indicador, "Responsable");
            FrecuenciasCB.DataBindings.Add("SelectedItem", Indicador, "Frecuencia");
        }

        private void MedicionesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleTxt.Text = ((MedicionDataGridViewWrapper)_sourceMediciones.Current).GetMedicion().Detalle;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form_graficos f = new Form_graficos();
            f.Indicador = Indicador;
            f.ShowDialog();
        }

        private void toolStripMetaBtn_Click(object sender, EventArgs e)
        {
            Form_Meta f = new Form_Meta(Indicador);
            f.ShowDialog();
        }

        private void toolStripAcciones_Click(object sender, EventArgs e)
        {
            new Form_AccionesCorrectivas(Indicador).Show();
        }

        private void toolStripInforme_Click(object sender, EventArgs e)
        {
            new Form_InformeIndicador(Indicador).ShowDialog();
        }

    }
}
