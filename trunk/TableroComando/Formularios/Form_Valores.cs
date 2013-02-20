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
    public partial class Form_Valores : Form
    {
        Clases.Modelo.Empresa empresa = new Clases.Modelo.Empresa("1");

        public Form_Valores()
        {
            InitializeComponent();
        }

        private void Valores_Load(object sender, EventArgs e)
        {
            RTBValores.Text = empresa.getvalores();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            empresa.setvalores(RTBValores.Text);
            empresa.guardar();
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
