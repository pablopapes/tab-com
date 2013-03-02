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
    public partial class Form_AgregarObjetivo : Form
    {
        private PerspectivaFachada PerspectivaFachada = PerspectivaFachada.Instance;
        private ObjetivoFachada ObjetivoFachada = ObjetivoFachada.Instance;
        public Objetivo Objetivo {get; set; }

        public Form_AgregarObjetivo(string textButton = "Agregar")
        {
            InitializeComponent();
            BTNGuardar.Text = textButton;
        }

        private void Form_AgregarObjetivo_Load(object sender, EventArgs e)
        {  
            // Cargo las perspectivas y setear ciertas propiedades
            ConfigurarCBPerspectiva();

            LoadObjetivo();

            // Se cargan los objetivos y se setean ciertas propiedades
            ConfigurarObjetivosDataGrid();
            
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
            ObjetivoFachada objFachada = ObjetivoFachada.Instance;
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
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            Objetivo.ObjetivosHijos = GetCheckedObjetivos();
            ObjetivoFachada.SaveOrUpdate(Objetivo);
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
