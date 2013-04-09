using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Validations.Results
{
    public class ValidationFailure
    {
        FluentValidation.Results.ValidationFailure error;
        public ValidationFailure(FluentValidation.Results.ValidationFailure fail)
        {
            error = fail;
        }

        public string ErrorMessage { get { return error.ErrorMessage; } }

        public override string ToString()
        {
            return error.ErrorMessage;
        }
           
    }
}
