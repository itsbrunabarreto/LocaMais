using FluentValidation;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Service.Validators
{
    public class ProprietarioValidator : AbstractValidator<Proprietario>
    {
        public ProprietarioValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Por Favor informe o Nome.")
                .NotNull().WithMessage("Por Favor informe o Nome.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(p => p.Endereco)
                .NotEmpty().WithMessage("Por Favor informe o Endereço.")
                .NotNull().WithMessage("Por Favor informe o Endereço.");

            RuleFor(p => p.Bairro)
                .NotEmpty().WithMessage("Por Favor informe o Bairro.")
                .NotNull().WithMessage("Por Favor informe o Bairro.");

            RuleFor(p => p.Cpf)
                .NotEmpty().WithMessage("Por Favor informe o CPF.")
                .NotNull().WithMessage("Por Favor informe o CPF.");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Por Favor informe o Email.")
                .NotNull().WithMessage("Por Favor informe o Email.");

        }
    }
}
