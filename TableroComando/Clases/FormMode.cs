using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TableroComando.Clases
{

    public abstract class FormMode
    {
        public FormMode(){}
        public abstract void AfterSave<FormClass>(Form form) where FormClass : Form;
        public string GuardarBtnText { get; protected set; }
    }

    public class UpdateMode : FormMode
    {
        public UpdateMode()
        {
            GuardarBtnText = "Actualizar"; 
        }

        public override void AfterSave<FormClass>(Form form)
        {
            
        }
    }

    public class CreateMode : FormMode  
    {
        public CreateMode()
        {
            GuardarBtnText = "Guardar";
        }

        public override void AfterSave<FormClass>(Form form) 
        {
            DialogResult result = MessageBox.Show("Los datos fueron guardados. ¿Desea agregar otro objetivo?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                form.Close();
                CreateMode c = new CreateMode();
                ((Form)Activator.CreateInstance(typeof(FormClass), c)).Show();
            }
            else form.Close();
        }
    }
}
