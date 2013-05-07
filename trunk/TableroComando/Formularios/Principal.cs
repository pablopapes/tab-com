using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Formularios;
using TableroComando.Dominio;
using Dominio;
using NHibernate.Proxy;
using Repositorios;
using Dominio.Repositorios;

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
            RestriccionGeneralRepository.Instance.CrearRestriccionesPerspectiva();
            PerspectivaRepository.Instance.CrearPerspectivas();
            FrecuenciaRepository.Instance.CrearFrecuencias();
            DeclaracionRepository.Instance.CrearMisionVision();
        }

        // Empresa
        private void modificarDatosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form ventana = new Formularios.Form_Empresa();
           // ventana.Show();
        }

        private void modificarLosValoresDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ShowForm(new Form_MisionVision());
        }

        // Mapa estratégico
        private void verMapaEstratégicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_MapaEstrategico());
        }

        private void responsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_ListaResponsables());
        }

        private void monitoreoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_MonitoreoArbol Monitor = new Form_MonitoreoArbol();
            Monitor.WindowState = FormWindowState.Maximized;
            ShowForm(Monitor);
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
            ShowForm(new Form_AccionesCorrectivas(AccionCorrectivaRepository.Instance.All()));
        }


        private void informeGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
           IList<Perspectiva> Lista =  PerspectivaRepository.Instance.All();
           Form_InformeGeneral FInforme = new Form_InformeGeneral(Lista);
           FInforme.WindowState = FormWindowState.Maximized;
           ShowForm(FInforme);
        }


        private void configurarIntervalosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_RestriccionesObjetivo());
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_ListaObjetivos());
        }

        private void configurarIntervalosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_RestriccionesPerspectivas());
        }

    }
}
