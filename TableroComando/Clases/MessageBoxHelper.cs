using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio.Validations.Results;

namespace TableroComando.Clases
{
    static public class MessageBoxHelper
    {
        public static void ShowValidationFailure(List<ValidationFailure> errors)
        {
            string mensaje = String.Join(Environment.NewLine, errors.Select(e => "- " + e.ErrorMessage));
            MessageBox.Show(mensaje, "Error en los datos", MessageBoxButtons.OK);
        }
    }
}
