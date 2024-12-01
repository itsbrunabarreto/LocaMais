using FluentValidation;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Service.Validators
{
    public class ImovelValidator : AbstractValidator<Imovel>
    {
        public ImovelValidator() 
        {
            RuleFor(i => i.Nome)
            .NotEmpty().WithMessage("Por favor, informe o nome do imóvel.")
            .NotNull().WithMessage("Por favor, informe o nome do imóvel.")
            .MaximumLength(100).WithMessage("O nome do imóvel pode ter no máximo 100 caracteres.");

            RuleFor(i => i.Endereco)
                .NotEmpty().WithMessage("Por favor, informe o endereço do imóvel.")
                .NotNull().WithMessage("Por favor, informe o endereço do imóvel.")
                .MaximumLength(100).WithMessage("O endereço do imóvel pode ter no máximo 100 caracteres.");

            RuleFor(i => i.PrecoAluguel)
                .NotEmpty().WithMessage("Por favor, informe o preço do aluguel do imóvel.")
                .NotNull().WithMessage("Por favor, informe o preço do aluguel do imóvel.");

        }
    }
}
