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
            LoadObjetivo();

            // Cargo las perspectivas
            IList<Perspectiva> perspectivas = PerspectivaFachada.All();
                
            CBPerspectiva.DataSource = perspectivas;
            CBPerspectiva.ValueMember = "Id";
            CBPerspectiva.DisplayMember = "Nombre";

            CargarObjetivosDataGrid();

        }

        private void CargarObjetivosDataGrid()
        {
            ObjetivoFachada objFachada = ObjetivoFachada.Instance;
            List<ObjetivoDataGridViewWrapper> lista = new List<ObjetivoDataGridViewWrapper>();
            foreach(Objetivo o in objFachada.All())
            {
                ObjetivoDataGridViewWrapper wrapper = new ObjetivoDataGridViewWrapper(o);
                wrapper.Check(Objetivo);
                lista.Add(wrapper);
            }
                 
            BindingList<ObjetivoDataGridViewWrapper> objetivos = new BindingList<ObjetivoDataGridViewWrapper>(lista);
            ObjetivosDataGrid.DataSource = objetivos;

            ObjetivosDataGrid.Columns["Pertenece"].HeaderText = "Objetivo Hijo";
            ObjetivosDataGrid.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadObjetivo()
        {
            if (Objetivo == null)
                Objetivo = new Objetivo();

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
