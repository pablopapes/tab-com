using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Dominio;
using TableroComando.GUIWrapper;
using Dominio;

namespace TableroComando.Formularios
{
    public partial class Form_ListaObjetivos : Form
    {
        BindingSource _sourceObjetivos = new BindingSource();

        public Form_ListaObjetivos()
        {
            InitializeComponent();
        }

        private void Form_ListaObjetivos_Load(object sender, EventArgs e)
        {
            ConfigurarObjetivosDataGrid();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            new Form_AgregarObjetivo().ShowDialog();
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Si borra el objetivo seleccionado se borrarán todos los indicadores asociados" +
                                                        " ¿Desea borrar el objetivo seleccionado?",
                                                        "Borrar objetivo",
                                                        MessageBoxButtons.YesNo);
            
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Objetivo o = ((ObjetivoDataGridViewWrapper)_sourceObjetivos.Current).GetObjetivo();
                ObjetivoRepository.Instance.Delete(o); // Borrar de la base de datos
                _sourceObjetivos.RemoveCurrent(); // Borrar del datagrid
            }
        }

        private void ConfigurarObjetivosDataGrid()
        {
            IList<Objetivo> objetivos = ObjetivoRepository.Instance.All();
            if (objetivos.Count != 0)
            {
                _sourceObjetivos.DataSource = ObjetivoRepository.Instance.All().Select(o => new ObjetivoDataGridViewWrapper(o));
                ObjetivosDataGrid.DataSource = _sourceObjetivos;

                ObjetivosDataGrid.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                ObjetivosDataGrid.Columns["Pertenece"].Visible = false;
            }
        }

        private void ObjetivosDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_AgregarObjetivo f = new Form_AgregarObjetivo("Actualizar");
            f.Objetivo = ((ObjetivoDataGridViewWrapper)_sourceObjetivos.Current).GetObjetivo();
            f.ShowDialog();
        }

    }
}
