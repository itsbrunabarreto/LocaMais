using FluentValidation;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Nome)
               .NotEmpty().WithMessage("Por Favor informe o nome.")
               .NotNull().WithMessage("Por Favor informe o nome.");

            RuleFor(u => u.Login)
               .NotEmpty().WithMessage("Por Favor informe o login.")
               .NotNull().WithMessage("Por Favor informe o login.");

            RuleFor(u => u.Email)
                .EmailAddress().WithMessage("Email Inválido")
               .NotEmpty().WithMessage("Por Favor informe o email.")
               .NotNull().WithMessage("Por Favor informe o email.");

            RuleFor(u => u.Senha)
               .NotEmpty().WithMessage("Por Favor informe a senha.")
               .NotNull().WithMessage("Por Favor informe a senha.");


        }
    }
}
