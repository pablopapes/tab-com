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
using TableroComando.Clases;
using Dominio.Validations.Results;


namespace TableroComando.Formularios
{
    public partial class Form_AgregarObjetivo : Form
    {
        private FormMode _mode;
        private PerspectivaRepository PerspectivaFachada = PerspectivaRepository.Instance;
        private ObjetivoRepository ObjetivoFachada = ObjetivoRepository.Instance;
        public Objetivo Objetivo { get; set; }
        public bool Guardado { get; protected set; }

        public Form_AgregarObjetivo(FormMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void Form_AgregarObjetivo_Load(object sender, EventArgs e)
        {
            BTNGuardar.Text = _mode.GuardarBtnText;
            ConfigurarCBPerspectiva();

            LoadObjetivo();

            // Se cargan los objetivos y se setean ciertas propiedades
            ConfigurarObjetivosDataGrid();

            string textAyuda = "Este número define en qué porcentaje el objetivo contribuye a la perspectiva. \nLa suma de los porcentajes de todos los objetivos pertenecientes a una perspectiva, debe ser menor o igual a 100.";
            toolTip1.SetToolTip(RelevanciaNum, textAyuda);
            toolTip1.SetToolTip(label3, textAyuda);
        }

        private void ConfigurarCBPerspectiva()
        {
            IList<Perspectiva> perspectivas = PerspectivaFachada.All();

            CBPerspectiva.DataSource = perspectivas;
            CBPerspectiva.DisplayMember = "Nombre";
            CBPerspectiva.SelectedIndex = -1;
        }

        private void ConfigurarObjetivosDataGrid()
        {
            ObjetivoRepository objFachada = ObjetivoRepository.Instance;
            List<ObjetivoDataGridViewWrapper> lista = new List<ObjetivoDataGridViewWrapper>();
            var objetivos = objFachada.All(new Dictionary<string, bool>
            {
                {"Perspectiva.Nombre", true},
                {"Nombre", true}
            });

            foreach(Objetivo o in objetivos)
            {
                ObjetivoDataGridViewWrapper wrapper = new ObjetivoDataGridViewWrapper(o);
                wrapper.Check(Objetivo);
                lista.Add(wrapper);
            }
                 
            BindingList<ObjetivoDataGridViewWrapper> objetivosWrapper = new BindingList<ObjetivoDataGridViewWrapper>(lista);
            ObjetivosDataGrid.DataSource = objetivosWrapper;

            ObjetivosDataGrid.Columns["Pertenece"].HeaderText = "Objetivo Hijo";
            ObjetivosDataGrid.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadObjetivo()
        {
            if (Objetivo == null)
            {
                
                Objetivo = new Objetivo();
            }
            TXTTitulo.DataBindings.Add("Text", Objetivo, "Nombre");
            RTBDescripcion.DataBindings.Add("Text", Objetivo, "Descripcion");
            CBPerspectiva.DataBindings.Add("SelectedItem", Objetivo, "Perspectiva");

            RelevanciaNum.DataBindings.Add("Value", Objetivo, "PorcentajeRelevancia");
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            Objetivo.ObjetivosHijos = GetCheckedObjetivos();
            ValidationResult result = ObjetivoFachada.Save(Objetivo);
            if (result.IsValid)
            {
                _mode.AfterSave<Form_AgregarObjetivo>(this);
                Guardado = true;
            }
            else MessageBoxHelper.ShowValidationFailure(result.Errors); 
            
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Objetivo> GetCheckedObjetivos()
        {
            return ((BindingList<ObjetivoDataGridViewWrapper>)ObjetivosDataGrid.DataSource)
                .Where(o => o.Pertenece)
                .Select(o => o.GetObjetivo())
                .ToList();
        }

    }
}
