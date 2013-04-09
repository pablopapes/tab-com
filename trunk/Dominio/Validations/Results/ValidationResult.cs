using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Validations.Results
{
    public class ValidationResult
    {
        public bool IsValid { get; protected set; }
        public List<ValidationFailure> Errors { get; protected set; }

        public ValidationResult(FluentValidation.Results.ValidationResult result) 
        { 
            IsValid = result.IsValid;
            Errors = result.Errors.Select(e => new ValidationFailure(e)).ToList();
        }

        public ValidationResult()
        {
            Errors = new List<ValidationFailure>();
            IsValid = true;
        }

        
    }
}
