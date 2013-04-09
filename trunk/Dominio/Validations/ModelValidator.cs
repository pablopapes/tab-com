using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using Dominio.Validations.Results;

namespace Dominio.Validations
{
    public abstract class ModelValidator<T> : AbstractValidator<T>
    {
        new public ValidationResult Validate(T model)
        {
            return new ValidationResult(base.Validate(model));
        }
    }
}
