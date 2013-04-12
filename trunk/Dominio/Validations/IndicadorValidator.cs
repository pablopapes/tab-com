using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using TableroComando.Dominio;

namespace Dominio.Validations
{
    public class IndicadorValidator : ModelValidator<Indicador>
    {
        public IndicadorValidator()
        {
            RuleFor(i => i.Nombre)
                .NotNull();
            RuleFor(i => i.Responsable)
                .NotNull();
            RuleFor(i => i.Frecuencia)
                    .NotNull();
            RuleFor(i => i.Objetivo)
                .NotNull();
            RuleFor(i => i.Restricciones)
                .NotNull();
            RuleFor(i => i.Codigo)
                .NotNull()
                .Must((indicador, codigo) => IndicadorRepository.Instance.ValidateCodigoUnico(indicador))
                .WithMessage("El código '{0}' ya existe", i => i.Codigo);
        }
    }
}
