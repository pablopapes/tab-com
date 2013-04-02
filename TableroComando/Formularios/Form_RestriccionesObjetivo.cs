using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.RangosUserControls;
using Repositorios;
using Dominio;

namespace TableroComando.Formularios
{
    public partial class Form_RestriccionesObjetivo : Form
    {
        int posicionX = 30;
        int posicionY = 0;
        int espacioEntreRangos = 0;
        string stringToShow = "% Objetivo";
        private IList<RestriccionObjetivo> _restriccionUserControl;

        public Form_RestriccionesObjetivo()
        {
            InitializeComponent();
        }

        private void Form_RestriccionesObjetivo_Load(object sender, EventArgs e)
        {
            _restriccionUserControl = RestriccionGeneralRepository.Instance.All<RestriccionObjetivo>();
            foreach (RestriccionObjetivo restriccion in _restriccionUserControl)
            {
                switch (restriccion.Tipo)
                {
                    case(TipoRestriccion.Mayor):
                        AddRestriccionUserControl(new RestriccionMayorUserControl(stringToShow, restriccion));
                        break;
                    case(TipoRestriccion.Menor):
                        AddRestriccionUserControl(new RestriccionMenorUserControl(stringToShow, restriccion));
                        break;
                    case(TipoRestriccion.Rango):
                        AddRestriccionUserControl(new RestriccionRangoUserControl(stringToShow, restriccion));
                        break;
                }
            }
        }

        private void AddRestriccionUserControl(UserControl userControl)
        {
            posicionY += userControl.Height + espacioEntreRangos;
            userControl.Location = new Point(posicionX, posicionY);
            Controls.Add(userControl);
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {

            RestriccionGeneralRepository.Instance.SaveAll(_restriccionUserControl);
        }
    }
}
