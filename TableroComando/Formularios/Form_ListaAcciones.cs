using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Repositorios;
using TableroComando.GUIWrapper;
using Dominio;

namespace TableroComando.Formularios
{
    public partial class Form_ListaAcciones : Form
    {
        BindingSource _acciones = new BindingSource();

        public Form_ListaAcciones()
        {
            InitializeComponent();
        }

        private void Form_ListaAcciones_Load(object sender, EventArgs e)
        {
            _acciones.DataSource = AccionCorrectivaRepository.Instance.All()
                .Select(accion => new AccionDataGridViewWrapper(accion)).ToList();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            //  AccionCorrectivaRepository.Instance.SaveAll<AccionCorrectiva>((List<AccionCorrectiva>)_acciones.DataSource);
        }
    }
}
