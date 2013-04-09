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
                    .NotNull()
                    .WithMessage("El indicador debe tener un nombre");
                RuleFor(i => i.Responsable)
                    .NotNull()
                    .WithMessage("El indicador debe tener un responsable");
                RuleFor(i => i.Frecuencia)
                    .NotNull()
                    .WithMessage("El indicador debe tener una frecuencia");
                RuleFor(i => i.Objetivo)
                    .NotNull()
                    .WithMessage("El indicador debe tener un objetivo asociado");
                RuleFor(i => i.Restricciones)
                    .NotNull()
                    .WithMessage("Error en la definición de metas");
                RuleFor(i => i.Codigo)
                    .NotNull()
                    .Must(codigo => IndicadorRepository.Instance.IsCodigoUnico(codigo))
                    .WithMessage("El código '{0}' ya existe", i => i.Codigo);
                
        }
    }
}
