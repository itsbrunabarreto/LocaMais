using FluentValidation;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Service.Validators
{
    public class TipoImovelValidator : AbstractValidator<TipoImovel>
    {
        public TipoImovelValidator()
        {
            RuleFor(t => t.Nome)
                .NotEmpty().WithMessage("Por Favor informe o nome.")
                .NotNull().WithMessage("Por Favor informe o nome.")
                .MaximumLength(50).WithMessage("Nome pode ter no máximo 50 caracteres.");
        }
    }
}
