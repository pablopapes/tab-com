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
using System.Globalization;

namespace TableroComando.Formularios
{
    public partial class Form_Indicador : Form
    {
        private ObjetivoRepository _objetivoFachada = ObjetivoRepository.Instance;
        private BindingSource _sourceMediciones;
        public Indicador Indicador { get; set; }


        public Form_Indicador(string textButton = "Agregar")
        {
            InitializeComponent();
            GuardarBtn.Text = textButton;
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
            FrecuenciasCB.DataSource = IndicadorRepository.Instance.AllFrecuencias();       
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
            Indicador.AddMediciones(((List<MedicionDataGridViewWrapper>)_sourceMediciones.DataSource).Select(m => m.GetMedicion()).ToList<Medicion>());
            Objetivo o = (Objetivo)ObjetivosCB.SelectedItem;
            o.Indicadores.Add(Indicador);
            _objetivoFachada.SaveOrUpdate(o);

            DialogResult result = MessageBox.Show("Los datos se guardaron extosamente. ¿Desea cargar otro indicador?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) OpenNewForm();
            this.Close();            
        }

        private void OpenNewForm()
        {
            Form_Indicador f = new Form_Indicador();
            f.Show();
        }

        private void CargarPropiedadesIndicador()
        {            
            NombreTxt.DataBindings.Add("Text", Indicador, "Nombre");
            CodigoTxt.DataBindings.Add("Text", Indicador, "Codigo");
            FormulaTxt.DataBindings.Add("Text", Indicador, "Calculo");
            CaracteristicaTxt.DataBindings.Add("Text", Indicador, "Caracteristica");
            PropositoTxt.DataBindings.Add("Text", Indicador, "Proposito");

            Binding binding = new Binding("Text", Indicador, "ValorEsperado");
            binding.Format +=new ConvertEventHandler(DecimalToString);
            binding.Parse += new ConvertEventHandler(StringToDecimal);
            ValorEsperadoTxt.DataBindings.Add(binding);


            ObjetivosCB.DataBindings.Add("SelectedItem", Indicador, "Objetivo");
            ResponsableCB.DataBindings.Add("SelectedItem", Indicador, "Responsable");
            FrecuenciasCB.DataBindings.Add("SelectedItem", Indicador, "Frecuencia");
        }

        private void MedicionesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleTxt.Text = ((MedicionDataGridViewWrapper)_sourceMediciones.Current).GetMedicion().Detalle;
        }

        private void DecimalToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType. 
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("c").
            cevent.Value = (cevent.Value != null) ? ((decimal)cevent.Value).ToString() : "";
        }

        private void StringToDecimal(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to decimal type only.
            if (cevent.DesiredType != typeof(decimal)) return;

            // Converts the string back to decimal using the static Parse method.
            cevent.Value = Decimal.Parse(cevent.Value.ToString(), NumberStyles.Currency, null);
        }
    }
}
