using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Fachadas;
using Dominio;


namespace TableroComando.Formularios
{
    public partial class Form_AgregarObjetivo : Form
    {
        private PerspectivaFachada PerspectivaFachada = PerspectivaFachada.Instance;
        private ObjetivoFachada ObjetivoFachada = ObjetivoFachada.Instance;
        Objetivo objetivo = new Objetivo();

        public Form_AgregarObjetivo()
        {
            InitializeComponent();
        }

        private void Form_AgregarObjetivo_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargo las perspectivas
                IList<Perspectiva> perspectivas = PerspectivaFachada.All();

                CBPerspectiva.DataSource = perspectivas;
                CBPerspectiva.ValueMember = "Id";
                CBPerspectiva.DisplayMember = "Nombre";

                // Cargo los objetivos
              /*  ObjetivoFachada objFachada = ObjetivoFachada.Instance;
                IList<Objetivo> Objetivos = objFachada.All();

                while (Objetivos.Read())
                {
                    string[] FilaObjetivos = { Objetivos.GetString("idobjetivo"), Objetivos.GetString("numero"), Objetivos.GetString("titulo"), Objetivos.GetString("nombreperspectiva"),"0" };
                    DGVObjetivosDepende.Rows.Add(FilaObjetivos);
                }

                ObjetivoObject.cerrar();*/
            }

            catch
            {
            }
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Objetivo objetivo = new Objetivo();
                objetivo.Nombre = TXTTitulo.Text;
                objetivo.Codigo = TXTNumero.Text;
                objetivo.Descripcion = RTBDescripcion.Text;
                objetivo.Perspectiva = (Perspectiva)CBPerspectiva.SelectedItem;
                ObjetivoFachada.Save(objetivo);
            }
            catch
            { }
        }



        private void CBPerspectiva_SelectedIndexChanged(object sender, EventArgs e)
        {
           /*try
            {
                DGVObjetivosDepende.Rows.Clear();

                string consulta = "select idperspectiva, nombreperspectiva from perspectivas;";
                Clases.Herramientas.ejecutar ConsultaObject = new Clases.Herramientas.ejecutar();
                MySqlDataAdapter responsabilidad = ConsultaObject.AdaptadorSQL(consulta);
                DataSet DSConsulta = new DataSet();
                responsabilidad.Fill(DSConsulta);
                CBPerspectiva.ValueMember = "idperspectiva";
                CBPerspectiva.DisplayMember = "nombreperspectiva";

                string objetivos = "select o.idobjetivo, o.numero, o.titulo, p.nombreperspectiva from perspectivas p, objetivos o where o.empresa=" + "1" + " and o.perspectiva=p.idperspectiva and p.idperspectiva >=" + CBPerspectiva.SelectedValue;
                Clases.Herramientas.ejecutar ObjetivoObject = new Clases.Herramientas.ejecutar();
                MySqlDataReader Objetivos = ObjetivoObject.EjecutarSQL(objetivos);

                while (Objetivos.Read())
                {
                    string[] FilaObjetivos = { Objetivos.GetString("idobjetivo"), Objetivos.GetString("numero"), Objetivos.GetString("titulo"), Objetivos.GetString("nombreperspectiva") };
                    DGVObjetivosDepende.Rows.Add(FilaObjetivos);
                }

                ObjetivoObject.cerrar();
            }

            catch
            {
            }
            */
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            DGVObjetivosDepende.ClearSelection();
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
