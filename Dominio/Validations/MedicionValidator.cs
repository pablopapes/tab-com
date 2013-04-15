using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;

namespace Dominio.Validations
{
    public class MedicionValidator : ModelValidator<Medicion>
    {
        public MedicionValidator()
        {
            RuleFor(m => m.Valor)
                .NotNull();
            RuleFor(m => m.Fecha)
                .NotNull();
            /*RuleFor(m => m.Indicador)
                .NotNull()
                .Must((medicion, indicador) => indicador.ProximaFechaMedicion <= medicion.Fecha)
                .WithMessage("La fecha de medición debe ser mayor o igual a {0}", m => m.Indicador.ProximaFechaMedicion.ToShortDateString());
            */
        }

    }
}
