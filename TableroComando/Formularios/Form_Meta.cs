using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.RangosUserControls;
using Dominio;

namespace TableroComando.Formularios
{
    public partial class Form_Meta : Form
    {
        int posicionX = 100;
        int posicionY = 0;
        int espacioEntreRangos = 0;
        public Indicador Indicador;
        
        public List<Restriccion> _restriccionForms;

        public Form_Meta(Indicador indicador)
        {
            InitializeComponent();
            Indicador = indicador;
            CargarRestriccionesForms();
        }

        private void CargarRestriccionesForms()
        {
            if(Indicador.Restricciones.Count != 0)
            {
                foreach (Restriccion r in Indicador.Restricciones)
                {
                    switch(r.Tipo)
                    { 
                        case(TipoRestriccion.Mayor):
                            AgregarRestriccion(new RestriccionMayorUserControl(this, Indicador.Codigo, r));
                            break;
                        case(TipoRestriccion.Menor):
                            AgregarRestriccion(new RestriccionMenorUserControl(this, Indicador.Codigo, r));
                            break;
                        case(TipoRestriccion.Rango):
                            AgregarRestriccion(new RestriccionRangoUserControl(this, Indicador.Codigo, r));
                            break;
                    } 
                }
            }
        }

        private void Form_Meta_Load(object sender, EventArgs e)
        {
            MayorBtn.Text = "X < " + Indicador.Codigo;
            MenorBtn.Text = Indicador.Codigo + " < X";
            RangoBtn.Text = "X < " + Indicador.Codigo + " < Y";
        }

        private void MenorBtn_Click(object sender, EventArgs e)
        {
            AgregarRestriccion(new RestriccionMenorUserControl(this, Indicador.Codigo, Indicador.CrearRestriccion(TipoRestriccion.Menor)));
        }

        private void RangoBtn_Click(object sender, EventArgs e)
        {
            AgregarRestriccion(new RestriccionRangoUserControl(this, Indicador.Codigo, Indicador.CrearRestriccion(TipoRestriccion.Rango)));
        }

        private void MayorBtn_Click(object sender, EventArgs e)
        {
            AgregarRestriccion(new RestriccionMayorUserControl(this, Indicador.Codigo, Indicador.CrearRestriccion(TipoRestriccion.Mayor)));
        }

        private void AgregarRestriccion(UserControl userControl)
        {
            posicionY += userControl.Height + espacioEntreRangos;
            userControl.Location = new Point(posicionX, posicionY);
            Controls.Add(userControl);
        }

        public void EliminarRestriccion(UserControl userControl)
        {
            posicionY -= userControl.Height - espacioEntreRangos;
            Controls.Remove(userControl);
        }


        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
