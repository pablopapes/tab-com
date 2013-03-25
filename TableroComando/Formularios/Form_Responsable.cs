using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using TableroComando.Fachadas;
using TableroComando.GUIWrapper;

namespace TableroComando.Formularios
{
    public partial class Form_Responsable : Form
    {
        public Responsable Responsable { get; set; }
        private BindingSource _sourceResponsables;

        /** 
         * El BindingSource se pasa por parámetro para agregar a la lista el nuevo responsable creado.
         **/
        public Form_Responsable(BindingSource responsables, string textButton = "Guardar")
        {
            InitializeComponent();
            _sourceResponsables = responsables;
            GuardarBtn.Text = textButton;
        }

        private void Form_Responsable_Load(object sender, EventArgs e)
        {
            CargarResponsableProperties();
        }

        private void CargarResponsableProperties()
        {
            if(Responsable == null) Responsable = new Responsable();
            
            NombreAreaTxt.DataBindings.Add("Text", Responsable, "Area");
            NombreResponsableTxt.DataBindings.Add("Text", Responsable, "Persona");
            TelefonoTxt.DataBindings.Add("Text", Responsable, "Telefono");
            EmailTxt.DataBindings.Add("Text", Responsable, "Email");
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            ResponsableRepository.Instance.Save(Responsable);
            _sourceResponsables.Add(new ResponsableDataGridViewWrapper(Responsable));
        }
    }
}
