using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.GUIWrapper;
using Dominio;
using Repositorios;

namespace TableroComando.Formularios
{
    public partial class Form_AccionesCorrectivas : Form
    {
        BindingSource _accionesSource = new BindingSource();
        BindingList<EstadoTarea> _estadoTareasBinding = new BindingList<EstadoTarea>(Enum.GetValues(typeof(EstadoTarea)).Cast<EstadoTarea>().ToList());
        Indicador _indicador;

        public Form_AccionesCorrectivas(Indicador indicador)
        {
            InitializeComponent();
            _indicador = indicador;
            
        }

        private void Form_AccionesCorrectivas_Load(object sender, EventArgs e)
        {
            _accionesSource.DataSource = _indicador.Acciones.Select(a => new AccionDataGridViewWrapper(a)).ToList();
            AccionesDataGrid.DataSource = _accionesSource;
            AccionesDataGrid.Columns.Remove("Estado"); // Se elimina la columna autogenerada por default

            DataGridViewComboBoxColumn c = new DataGridViewComboBoxColumn();
            c.DataPropertyName = "Estado";
            c.DataSource = _estadoTareasBinding;
            c.Name = "Estado";
            c.HeaderText = "Estado";
            AccionesDataGrid.Columns.Add(c);

            AccionesDataGrid.Columns["Indicador"].Visible = false;
            AccionesDataGrid.Columns["FechaFin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccionesDataGrid.Columns["Responsable"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccionesDataGrid.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<AccionCorrectiva> acciones = ((IList<AccionDataGridViewWrapper>)_accionesSource.DataSource)
                .Select(wrapper => wrapper.GetAccionCorrectiva());
            AccionCorrectivaRepository.Instance.SaveAll(acciones);
        }

        private void AccionesDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox comboBox = e.Control as ComboBox;
            if (comboBox != null) 
            { 
                comboBox.SelectionChangeCommitted -= new EventHandler(cb_SelectedIndexChanged);
                // now attach the event handler
                comboBox.SelectionChangeCommitted += new EventHandler(cb_SelectedIndexChanged);
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            comboBox.DroppedDown = true;
        }
    }
}
