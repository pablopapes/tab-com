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
using TableroComando.Dominio;

namespace TableroComando.Formularios
{
    public partial class Form_AccionesCorrectivas : Form
    {
        BindingSource _accionesSource = new BindingSource();
        BindingList<EstadoTarea> _estadoTareasBinding = new BindingList<EstadoTarea>(Enum.GetValues(typeof(EstadoTarea)).Cast<EstadoTarea>().ToList());
        Indicador _indicador;

        // Esta columna contiene solo el código del indicador y solo se crea y muestra cuando se listan todas las acciones correctivas
        DataGridViewTextBoxColumn CodigoIndicadorColumn; 

        /* Este contructor es usado para mostrar cualquier listado de acciones correctivas */
        public Form_AccionesCorrectivas(IList<AccionCorrectiva> acciones)
        {
            InitializeComponent();
            _accionesSource.DataSource = acciones.Select(a => new AccionDataGridViewWrapper(a)).ToList();
            AccionesDataGrid.AllowUserToAddRows = false;
            CodigoIndicadorColumn = new DataGridViewTextBoxColumn();
            CodigoIndicadorColumn.Name = "Indicador";
            CodigoIndicadorColumn.HeaderText = "Indicador";
            CodigoIndicadorColumn.DataPropertyName = "Indicador";
        }

        /* Este contructor es usado para mostrar todas las acciones correctivas de un indicador en particular */
        public Form_AccionesCorrectivas(Indicador indicador)
        {
            InitializeComponent();
            _indicador = indicador;
            _accionesSource.DataSource = indicador.Acciones.Select(a => new AccionDataGridViewWrapper(a)).ToList();
        }

        private void Form_AccionesCorrectivas_Load(object sender, EventArgs e)
        {
            AccionesDataGrid.DataSource = _accionesSource;
            AccionesDataGrid.Columns["FechaFin"].DefaultCellStyle.Format = "dd";
            if (CodigoIndicadorColumn != null) AccionesDataGrid.Columns.Add(CodigoIndicadorColumn);

            AccionesDataGrid.Columns.Remove("Responsable");

            // Se crea una nueva columna de Responsable de las acciones
            DataGridViewComboBoxColumn ColumnaResponsable = new DataGridViewComboBoxColumn();
            ColumnaResponsable.DataPropertyName = "Responsable";
            ColumnaResponsable.DataSource = new BindingList<Responsable>(ResponsableRepository.Instance.All());
            ColumnaResponsable.Name = "Responsable";
            ColumnaResponsable.HeaderText = "Responsable";
            AccionesDataGrid.Columns.Add(ColumnaResponsable);

            AccionesDataGrid.Columns.Remove("Estado"); // Se elimina la columna autogenerada por default

            // Se crea una nueva columna de estado de las acciones
            DataGridViewComboBoxColumn ColumnaEstado = new DataGridViewComboBoxColumn();
            ColumnaEstado.DataPropertyName = "Estado";
            ColumnaEstado.DataSource = _estadoTareasBinding;
            ColumnaEstado.Name = "Estado";
            ColumnaEstado.HeaderText = "Estado";
            AccionesDataGrid.Columns.Add(ColumnaEstado);

            AccionesDataGrid.Columns["Indicador"].Visible = false;
            AccionesDataGrid.Columns["FechaFin"].DefaultCellStyle.Format = "dd";
            AccionesDataGrid.Columns["FechaFin"].HeaderText = "Fecha límite";
            AccionesDataGrid.Columns["FechaFin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccionesDataGrid.Columns["Responsable"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccionesDataGrid.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccionesDataGrid.Columns["Descripcion"].HeaderText = "Descripción del desvío";
            AccionesDataGrid.Columns["Objetivo"].HeaderText = "Acción de mejora a implementar";
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<AccionCorrectiva> acciones = ((IList<AccionDataGridViewWrapper>)_accionesSource.DataSource)
                .Select(wrapper => wrapper.GetAccionCorrectiva());

            if (_indicador == null)
            {
                AccionCorrectivaRepository.Instance.SaveAll(acciones);
            }
            else
            {
                foreach (AccionCorrectiva accion in acciones)
                {
                    if (accion.Indicador == null) accion.Indicador = _indicador;
                    AccionCorrectivaRepository.Instance.Save(accion);
                }
            }
        }

        // Estos eventos están para que retornen objetos cuando una opción es seleccionada.
        private void AccionesDataGrid_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (AccionesDataGrid.CurrentCell.OwningColumn is DataGridViewComboBoxColumn) {
                DataGridViewComboBoxEditingControl editingControl = 
                (DataGridViewComboBoxEditingControl)AccionesDataGrid.EditingControl;
                e.Value = editingControl.SelectedItem;
                e.ParsingApplied = true;
            }
        }

        private void AccionesDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                e.Value = e.Value.ToString();
            }           
        }
    }
}
