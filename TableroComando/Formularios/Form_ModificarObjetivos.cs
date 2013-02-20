using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TableroComando.Formularios
{
    public partial class Form_ModificarObjetivos : Form
    {
        public Form_ModificarObjetivos()
        {
            InitializeComponent();

            foreach (Clases.Modelo.Objetivo Obj in Clases.Modelo.Objetivo.listarObjetivos())
            {
                DGVFinanciera.Rows.Add(Obj.getidobjetivo(),Obj.getnumero(),Obj.gettitulo(),Obj.getnombreestado(),Obj.getnombreperspectiva());
            }
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            Form ventana = new Formularios.Form_ModificarObjetivoDetalle(DGVFinanciera.SelectedCells[0].Value.ToString());
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ventana = new Formularios.Form_AgregarIndicador();
            ventana.Show();
        }
    }
}
