using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using TableroComando.Dominio;
using Dominio;
using Repositorios;
using TableroComando.Clases;


namespace TableroComando.Formularios
{
    public partial class Form_MonitoreoArbol : Form
    {
        public Form_MonitoreoArbol()
        {
            InitializeComponent();
        }

        private void Form_MonitoreoArbol_Load(object sender, EventArgs e)
        {
            IList<Perspectiva> ListaPerspectiva = PerspectivaRepository.Instance.All();

            treeListView1.CanExpandGetter = delegate(object x) {
                                                             if (((Modelo)x).isPerspective) return true;
                                                             if (((Modelo)x).isObjetive) return true;
                                                             return false;
                                                               };



            treeListView1.ChildrenGetter = delegate(object x) { return ((Modelo)x).Children; };

            this.Nombre.ImageGetter = delegate(object x)
            {
                if (((Modelo)x).Color == Color.Green) return "Green";
                if (((Modelo)x).Color == Color.Yellow) return "Yellow";
                if (((Modelo)x).Color == Color.Red) return "Red";
                if (((Modelo)x).Color == Color.White) return "White";
                else
                {
                    return null;
                };
            };

            treeListView1.Roots = Modelo.CreateModelPers(null, ListaPerspectiva);

        }

        

        private void treeListView1_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            if (e.ClickCount == 2 && e.Item != null)
            {
                if (((Modelo)e.Item.RowObject).Indicador != null)
                {
                    Form_Indicador f = new Form_Indicador();
                    f.Indicador = ((Modelo)e.Item.RowObject).Indicador;
                    f.ShowDialog();
                }
                else
                {
                    if (((Modelo)e.Item.RowObject).isObjetive)
                    {
                        Form_AgregarObjetivo f = new Form_AgregarObjetivo();
                        f.Objetivo = ((Modelo)e.Item.RowObject).Objetivo;
                        f.ShowDialog();
                    }
                }
            }
        }
    }
}
