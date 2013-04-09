using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;

namespace Dominio.Validations
{
    public class ObjetivoValidator : ModelValidator<Objetivo>
    {
        public ObjetivoValidator()
        {
            RuleFor(o => o.Perspectiva)
                .NotNull();
            RuleFor(o => o.Nombre).NotNull();
        }
    }
}
