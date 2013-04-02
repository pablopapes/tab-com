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

namespace TableroComando.Formularios
{
    public partial class Form_AccionesCorrectivas : Form
    {
        BindingSource _accionesSource = new BindingSource();
        Indicador _indicador;

        public Form_AccionesCorrectivas(Indicador indicador)
        {
            InitializeComponent();
            _indicador = indicador;
            AccionesDataGrid.AutoGenerateColumns = false;
        }

        private void Form_AccionesCorrectivas_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn c = new DataGridViewComboBoxColumn();
            c.DataSource = Enum.GetValues(typeof(EstadoTarea));
            c.Name = "clmColumn1";
            c.HeaderText = "Dosage";
            c.DataPropertyName = "Dosage";
            AccionesDataGrid.Columns.Add(c);
            _accionesSource.DataSource = _indicador.Acciones.Select(a => new AccionDataGridViewWrapper(a)).ToList();
            AccionesDataGrid.DataSource = _accionesSource;
        }
    }
}
