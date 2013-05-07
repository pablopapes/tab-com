using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio.Repositorios;
using Dominio;

namespace TableroComando.Formularios
{
    public partial class Form_MisionVision : Form
    {
        Declaracion _vision = DeclaracionRepository.Instance.FindByTipo("vision");
        Declaracion _mision = DeclaracionRepository.Instance.FindByTipo("mision");

        public Form_MisionVision()
        {
            InitializeComponent();
        }

        private void Form_MisionVision_Load(object sender, EventArgs e)
        {

            VisionTxt.DataBindings.Add("Text", _vision, "Detalle");
            MisionTxt.DataBindings.Add("Text", _mision, "Detalle");
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            DeclaracionRepository.Instance.Save(_vision);
            DeclaracionRepository.Instance.Save(_mision);
        }
    }
}
