using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Clases.Models;
using TableroComando.Fachadas;

namespace TableroComando.Formularios
{
    public partial class Form_AgregarIndicador : Form
    {
        public ObjetivoFachada ObjetivoFachada = ObjetivoFachada.Instance;
        public IndicadorFachada IndicadorFachada = IndicadorFachada.Instance;

        public Form_AgregarIndicador()
        {
            InitializeComponent();
            ObjetivosCB.DataSource = ObjetivoFachada.All();
            ObjetivosCB.DisplayMember = "Nombre";
            MenorRB.Checked = true; // Por defecto, el radio buton de "tendencia menor" está seleccionado.
        }

        private void Form_AgregarIndicador_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("$");
            comboBox1.Items.Add("%");
            comboBox1.Items.Add("#");
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Indicador indicador = new Indicador { Nombre = NombreTxt.Text };
            indicador.Espectativa = (MenorRB.Checked) ? "menor" : "mayor";
            indicador.Objetivo = (Objetivo)ObjetivosCB.SelectedItem;
            indicador.Prioridad = (int)PrioridadUD.Value;

            IndicadorFachada.Save(indicador);
        }

    }
}
