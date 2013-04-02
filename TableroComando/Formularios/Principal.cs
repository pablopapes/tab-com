using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Formularios;
using TableroComando.Fachadas;
using Dominio;
using NHibernate.Proxy;
using Repositorios;

namespace TableroComando
{
    public partial class Principal : Form
    {
        private ObjetivoRepository ObjetivoFachada = ObjetivoRepository.Instance;
        private IndicadorRepository IndicadorFachada = IndicadorRepository.Instance;

        public Principal()
        {
            InitializeComponent();
            RestriccionGeneralRepository.Instance.CrearRestriccionesObjetivos();
        }

        // Empresa
        private void modificarDatosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form ventana = new Formularios.Form_Empresa();
           // ventana.Show();
        }

        private void modificarLosValoresDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form ventana = new Formularios.Form_Valores();
           // ventana.Show();
        }

        // Mapa estratégico
        private void verMapaEstratégicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_MapaEstrategico());
        }

        // Objetivos
        private void agregarUnObjetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Formularios.Form_AgregarObjetivo());
        }

        private void agregarIndicadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Formularios.Form_Indicador());
        }

        private void responsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_ListaResponsables());
        }

        private void monitoreoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(new Formularios.Form_Monitoreo());
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_ListaIndicadores());
        }

        private void agendaDeMedicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_Agenda());
        }

        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_graficos());
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void accionesCorrectivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_ListaAcciones());
        }

        private void configurarIntervalosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_RestriccionesObjetivo());
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_ListaObjetivos());
        }

    }
}
