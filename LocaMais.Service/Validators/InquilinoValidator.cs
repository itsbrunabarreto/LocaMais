using FluentValidation;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Service.Validators
{
    public class InquilinoValidator : AbstractValidator<Inquilino>
    {
        public InquilinoValidator()
        {
            RuleFor(i => i.Nome)
                .NotEmpty().WithMessage("Por Favor informe o Nome.")
                .NotNull().WithMessage("Por Favor informe o Nome.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(i => i.Endereco)
                .NotEmpty().WithMessage("Por Favor informe o Endereço.")
                .NotNull().WithMessage("Por Favor informe o Endereço.");

            RuleFor(i => i.Bairro)
                .NotEmpty().WithMessage("Por Favor informe o Bairro.")
                .NotNull().WithMessage("Por Favor informe o Bairro.");

            RuleFor(i => i.Cpf)
                .NotEmpty().WithMessage("Por Favor informe o CPF.")
                .NotNull().WithMessage("Por Favor informe o CPF.");

            RuleFor(i => i.Email)
                .NotEmpty().WithMessage("Por Favor informe o Email.")
                .NotNull().WithMessage("Por Favor informe o Email.");

        }
    }
}
