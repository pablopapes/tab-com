using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Repositorios;
using TableroComando.RangosUserControls;

namespace TableroComando.Formularios
{
    public partial class Form_RestriccionesPerspectivas : Form
    {
        int posicionX = 30;
        int posicionY = 0;
        int espacioEntreRangos = 0;
        string stringToShow = "% Perspectiva";
        private IList<RestriccionPerspectiva> _restriccionUserControl;

        public Form_RestriccionesPerspectivas()
        {
            InitializeComponent();
        }

        private void Form_RestriccionesPerspectivas_Load(object sender, EventArgs e)
        {
            _restriccionUserControl = RestriccionGeneralRepository.Instance.All<RestriccionPerspectiva>();
            foreach (RestriccionPerspectiva restriccion in _restriccionUserControl)
            {
                switch (restriccion.Tipo)
                {
                    case (TipoRestriccion.Mayor):
                        AddRestriccionUserControl(new RestriccionMayorUserControl(stringToShow, restriccion));
                        break;
                    case (TipoRestriccion.Menor):
                        AddRestriccionUserControl(new RestriccionMenorUserControl(stringToShow, restriccion));
                        break;
                    case (TipoRestriccion.Rango):
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

    }
}
