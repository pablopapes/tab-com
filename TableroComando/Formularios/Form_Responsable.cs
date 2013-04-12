using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using TableroComando.Dominio;
using TableroComando.GUIWrapper;
using TableroComando.Clases;
using Dominio.Validations.Results;

namespace TableroComando.Formularios
{
    public partial class Form_Responsable : Form
    {
        public Responsable Responsable { get; set; }
        private FormMode _mode;
        public bool Guardado { get; protected set; }

        /** 
         * El BindingSource se pasa por parámetro para agregar a la lista el nuevo responsable creado.
         **/
        public Form_Responsable(FormMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void Form_Responsable_Load(object sender, EventArgs e)
        {
            GuardarBtn.Text = _mode.GuardarBtnText;
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
            ValidationResult result = ResponsableRepository.Instance.Save(Responsable);
            if (result.IsValid)
            {
                _mode.AfterSave<Form_Responsable>(this);
                Guardado = true;
            }
            else
            {
                MessageBoxHelper.ShowValidationFailure(result.Errors);
            }
            
        }
    }
}
