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
    public partial class Form_Empresa : Form
    {

        Clases.Modelo.Empresa empresa = new Clases.Modelo.Empresa("1");

        // INITIALIZE
        public Form_Empresa()
        {
            InitializeComponent();
        }

        // LOAD
        private void Empresa_Load(object sender, EventArgs e)
        {
            
            TXTEmpresa.Text = empresa.getnombreempresa();
            TXTCUIT.Text = empresa.getcuit();
            RTBMision.Text = empresa.getmision();
            RTBVision.Text = empresa.getvision();

        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            empresa.setnombreempresa(TXTEmpresa.Text);
            empresa.setcuit(TXTCUIT.Text);
            empresa.setmision(RTBMision.Text);
            empresa.setvision(RTBVision.Text);
            empresa.guardar();
        }


    }
}
