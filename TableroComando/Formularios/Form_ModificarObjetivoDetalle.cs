using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TableroComando.Formularios
{
    public partial class Form_ModificarObjetivoDetalle : Form
    {
        Clases.Modelo.Objetivo objetivo = new Clases.Modelo.Objetivo();

        public Form_ModificarObjetivoDetalle(string idObjetivo)
        {
            InitializeComponent();
            objetivo.setidobjectivo(idObjetivo);
        }

        private void Form_ModificarObjetivoDetalle_Load(object sender, EventArgs e)
        {
            try
            {   // Cargo las perspectivas
                string consulta = "select idperspectiva, nombreperspectiva from perspectivas;";
                Clases.Herramientas.ejecutar ConsultaObject = new Clases.Herramientas.ejecutar();
                MySqlDataAdapter Perspectivas = ConsultaObject.AdaptadorSQL(consulta);
                DataSet DSConsulta = new DataSet();
                Perspectivas.Fill(DSConsulta);
                CBPerspectiva.DataSource = DSConsulta.Tables[0];
                CBPerspectiva.ValueMember = "idperspectiva";
                CBPerspectiva.DisplayMember = "nombreperspectiva";

                // Cargo los datos del objetivo
                objetivo = Clases.Modelo.Objetivo.buscarObjetivo(objetivo.getidobjetivo());
                TXTTitulo.Text = objetivo.gettitulo();
                TXTNumero.Text = objetivo.getnumero();
                RTBDescripcion.Text = objetivo.getdescripcion();
                CBPerspectiva.SelectedValue = objetivo.getperspectiva();

                foreach (Clases.Modelo.Objetivo Obj in Clases.Modelo.Objetivo.objetivosPermitidos(objetivo.getidobjetivo(), objetivo.getperspectiva()))
                {
                    DGVObjetivosDepende.Rows.Add(Obj.getidobjetivo(), Obj.getnumero(), Obj.gettitulo(), Obj.getnombreperspectiva());
                }

                foreach (string asociado in Clases.Modelo.Objetivo.objetivosAsociados(objetivo.getidobjetivo()))
                {
                    foreach (char id in DGVObjetivosDepende.Rows[0].ToString())
                    {
                        if (Convert.ToString(id) == asociado)
                        {
                            DGVObjetivosDepende.SelectedCells[0].Selected = true;
                        }
                    }
                }
            }

            catch
            {
            }

        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
