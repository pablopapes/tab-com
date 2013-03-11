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

namespace TableroComando
{
    public partial class Principal : Form
    {
        private ObjetivoRepository ObjetivoFachada = ObjetivoRepository.Instance;
        //private IndicadorRepository IndicadorFachada = IndicadorRepository.Instance;

        public Principal()
        {
            InitializeComponent();
            //createData();
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

        // Usuarios
        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ventana = new Formularios.Form_AgregarUsuario();
            //ventana.Show();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ventana = new Formularios.Form_ModificarUsuario();
            //ventana.Show();
        }

        // Mapa estratégico
        private void verMapaEstratégicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new TableroComando.Formularios.Form_MapaEstrategico();
            ventana.Show();
        }

        // Objetivos
        private void agregarUnObjetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Formularios.Form_AgregarObjetivo();
            ventana.Show();
        }

        private void modificarObjetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Form_ListaObjetivos();
            ventana.Show();
        }

 /*       private void indicadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Indicadores ventana = new Formularios.Form_Indicadores();
            ventana.ObjetivoFachada = ObjetivoFachada;
            ventana.Show();
        }
*/
        private void agregarIndicadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Indicador ventana = new Formularios.Form_Indicador();
           // ventana.ObjetivoFachada = ObjetivoFachada;
           // ventana.IndicadorFachada = IndicadorFachada;
            ventana.Show();
        }

        private void responsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_ListaResponsables().Show();
        }
        /*
        private void createData()
        {
            Perspectiva p = new Perspectiva { Nombre = "Finanzas" };
            Perspectiva p1 = new Perspectiva { Nombre = "Clientes" };
            Perspectiva p2 = new Perspectiva { Nombre = "Procesos Internos" };
            Perspectiva p3 = new Perspectiva { Nombre = "Aprendizajes" };
            
            Objetivo o = new Objetivo {Nombre = "Objetivo 1", Codigo = "1.1", Descripcion = "Descripción 1", Perspectiva = p};
            Objetivo o1 = new Objetivo { Nombre = "Objetivo 1", Codigo = "1.2", Descripcion = "Descripción 2", Perspectiva = p };
            Objetivo o2 = new Objetivo { Nombre = "Objetivo 1", Codigo = "2.1", Descripcion = "Descripción 3", Perspectiva = p1 };
            Objetivo o3 = new Objetivo { Nombre = "Objetivo 1", Codigo = "3.1", Descripcion = "Descripción 4", Perspectiva = p2 };

            Indicador i1 = new Indicador { Nombre = "Indicador 1", Objetivo = o, Proposito = "Mejorar 1", Prioridad = 1 };
            Indicador i2 = new Indicador { Nombre = "Indicador 2", Objetivo = o1, Proposito = "Mejorar 2", Prioridad = 2 };
            Indicador i3 = new Indicador { Nombre = "Indicador 3", Objetivo = o2, Proposito = "Mejorar 3", Prioridad = 3 };
            Indicador i4 = new Indicador { Nombre = "Indicador 4", Objetivo = o3, Proposito = "Mejorar 4", Prioridad = 4 };
            /*
            Repository.Instance.Session.Save(p);
            Repository.Instance.Session.Save(p1);
            Repository.Instance.Session.Save(p2);
            Repository.Instance.Session.Save(p3);
            
            Repository.Instance.Session.Flush();
            
            ObjetivoFachada.Save(o);
            ObjetivoFachada.Save(o1);
            ObjetivoFachada.Save(o2);
            ObjetivoFachada.Save(o3);

            IndicadorFachada.Save(i1);
            IndicadorFachada.Save(i2);
            IndicadorFachada.Save(i3);
            IndicadorFachada.Save(i4);
        }*/
    
        private void objetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monitoreoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Monitoreo ventana = new Formularios.Form_Monitoreo();
            ventana.ObjetivoFachada = ObjetivoFachada;
            ventana.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListaIndicadores f = new Form_ListaIndicadores();
            f.ShowDialog();
        }

        private void agendaDeMedicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Agenda f = new Form_Agenda();
            f.ShowDialog();
        }

    }
}
