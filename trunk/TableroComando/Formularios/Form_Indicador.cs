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

namespace TableroComando.Formularios
{
    public partial class Form_Indicador : Form
    {
        private ObjetivoFachada _objetivoFachada = ObjetivoFachada.Instance;
        //private IndicadorFachada IndicadorFachada = IndicadorFachada.Instance;
        //private BindingList<MedicionDataGridViewWrapper> _bindingMediciones;
        private BindingSource _sourceMediciones;
        public Indicador Indicador { get; set; }


        public Form_Indicador(string textButton = "Agregar")
        {
            InitializeComponent();
            GuardarBtn.Text = textButton;
        }

        private void Form_AgregarIndicador_Load(object sender, EventArgs e)
        {
            /* Se cargan los objetivos en un combobox y se setean algunas propiedades */
            ConfigurarObjetivosCB();
            ConfigurarFrecuenciasCB();
            ConfigurarResponsablesCB();
            
            /* Si no se seteó ningún indicador, se crea uno nuevo */
            if (Indicador == null)
                Indicador = new Indicador();
            
            CargarPropiedadesIndicador();
            
            ConfigurarMedicioinesGridView(); // Se cargan las mediciones en el datagrid y se setean algunas propiedades
        }

        private void ConfigurarResponsablesCB()
        {
            
        }

        private void ConfigurarMedicioinesGridView()
        {
            /*_bindingMediciones = new BindingList<MedicionDataGridViewWrapper>(Indicador.Mediciones
                .Select(m => new MedicionDataGridViewWrapper(m))
                .ToList());*/

            _sourceMediciones = new BindingSource();
            _sourceMediciones.DataSource = Indicador.Mediciones
                .Select(m => new MedicionDataGridViewWrapper(m))
                .ToList();
            MedicionesGridView.DataSource = _sourceMediciones;
            MedicionesGridView.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void ConfigurarFrecuenciasCB()
        {
            FrecuenciasCB.DataSource = IndicadorFachada.Instance.AllFrecuencias();
            FrecuenciasCB.DisplayMember = "Periodo";
            FrecuenciasCB.SelectedIndex = -1;   
        }

        private void ConfigurarObjetivosCB()
        {
            ObjetivosCB.DataSource = _objetivoFachada.All();
            ObjetivosCB.DisplayMember = "Nombre";
            ObjetivosCB.SelectedIndex = -1;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            //var lista = _bindingMediciones.Select(m => m.GetMedicion()).ToList<Medicion>();
            //Indicador.AddMediciones(_bindingMediciones.Select(m => m.GetMedicion()).ToList<Medicion>());
            Indicador.AddMediciones(((List<MedicionDataGridViewWrapper>)_sourceMediciones.DataSource).Select(m => m.GetMedicion()).ToList<Medicion>());
            //Console.WriteLine(_bindingMediciones.Select(m => m.GetMedicion()).ToList<Medicion>());
            //Indicador.Frecuencia = (Frecuencia)FrecuenciasCB.SelectedItem;
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
            ValorEsperadoTxt.DataBindings.Add("Text", Indicador, "ValorEsperado");
            FrecuenciasCB.DataBindings.Add("SelectedItem", Indicador, "Frecuencia");
            ObjetivosCB.DataBindings.Add("SelectedItem", Indicador, "Objetivo");
            ResponsableCB.DataBindings.Add("Text", Indicador, "Responsable");
            
            //FrecuenciasCB.SelectedItem = Indicador.Frecuencia;


            //if(Indicador.Espectativa == "mayor") MayorRB.DataBindings.Add("Checked", true, ;
            //else MenorRB.Checked = true;

            //PrioridadUD.DataBindings.Add("Value", Indicador, "Prioridad");
        }

    }
}
