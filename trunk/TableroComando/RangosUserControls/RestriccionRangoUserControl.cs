using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Formularios;
using Dominio;
using TableroComando.Clases;

namespace TableroComando.RangosUserControls
{
    public partial class RestriccionRangoUserControl : UserControl
    {
        private Form_Meta _formParent;
        public Restriccion Restriccion { get; set; }
        public RestriccionRangoUserControl(Form_Meta form, string codigo, Restriccion r)
        {
            InitializeComponent();
            label1.Text = codigo;
            _formParent = form;
            Restriccion = r;
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            _formParent.EliminarRestriccion(this);
        }

        private void RestriccionRango_Load(object sender, EventArgs e)
        {
            EstadoCB.DataSource = Enum.GetValues(typeof(EstadoIndicador));

            ValorMenorTxt.DataBindings.Add(DataBindingConverter.BuildBindingDecimalString<Restriccion>("Text", Restriccion, "ValorMenor"));
            ValorMayorTxt.DataBindings.Add(DataBindingConverter.BuildBindingDecimalString<Restriccion>("Text", Restriccion, "ValorMayor"));

            if (Restriccion.Estado == null) EstadoCB.SelectedIndex = -1;
            EstadoCB.DataBindings.Add("SelectedItem", Restriccion, "Estado");
        }

        private void EstadoCB_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb == null) return;
            if (e.Index < 0) return;
            if (!(cmb.Items[e.Index] is EstadoIndicador)) return;
            EstadoIndicador estado = (EstadoIndicador)cmb.Items[e.Index];
            Color color = VisualHelper.GetColor(estado);

            // Dibujamos el fondo
            e.DrawBackground();

            // Creamos los objetos GDI+
            Brush brush = new SolidBrush(color);
            Pen forePen = new Pen(e.ForeColor);
            Brush foreBrush = new SolidBrush(e.ForeColor);

            // Dibujamos el borde del rectángulo
            e.Graphics.DrawRectangle(
                forePen,
                new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 19,
                    e.Bounds.Size.Height - 4));

            // Rellenamos el rectángulo con el Color seleccionado
            // en el combo
            e.Graphics.FillRectangle(brush,
                new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 18,
                    e.Bounds.Size.Height - 5));

            // Dibujamos el string que se muestra en el combobox
            e.Graphics.DrawString(cmb.Items[e.Index].ToString(), cmb.Font,
                foreBrush, e.Bounds.Left + 25, e.Bounds.Top + 2);
            // Eliminamos objetos GDI+
            brush.Dispose();
            forePen.Dispose();
            foreBrush.Dispose();
        }

    }
}
