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
using TableroComando.Clases;

namespace TableroComando.Formularios
{
    public partial class Form_ListaResponsables : Form
    {
        BindingSource _sourceResponsables = new BindingSource();

        public Form_ListaResponsables()
        {
            InitializeComponent();
        }

        private void Form_ListaResponsables_Load(object sender, EventArgs e)
        {
            ConfigurarResponsablesDataGrid();
        }

        private void ConfigurarResponsablesDataGrid()
        {
            IList<Responsable> responsables = ResponsableRepository.Instance.All();
            if(responsables.Count != 0)
            {
                _sourceResponsables.DataSource = responsables.Select(r => new ResponsableDataGridViewWrapper(r));
                ResponsablesDataGrid.DataSource = _sourceResponsables;
                ResponsablesDataGrid.Columns["Persona"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Form_Responsable f = new Form_Responsable(new CreateMode());
            f.ShowDialog();
            if (f.Guardado)
            {
                // Se agrega al datagrid un wrapper del nuevo responsable creado
                _sourceResponsables.Add(new ResponsableDataGridViewWrapper(f.Responsable));
            } 
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea borrar el área seleccionada?", "Borrar área", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Responsable responsable = ((ResponsableDataGridViewWrapper) _sourceResponsables.Current).GetResponsable();
                ResponsableRepository.Instance.Delete(responsable);
                _sourceResponsables.RemoveCurrent();
            }

        }

        private void ResponsablesDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Responsable f = new Form_Responsable(new UpdateMode());
            f.Responsable = ((ResponsableDataGridViewWrapper)_sourceResponsables.Current).GetResponsable();
            f.ShowDialog();
        }
    }
}
