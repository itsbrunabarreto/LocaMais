using FluentValidation;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Service.Validators
{
    public class ContratoValidator : AbstractValidator<Contrato>
    {
        public ContratoValidator() 
        {
            RuleFor(c => c.ValorAluguel)
               .NotEmpty().WithMessage("Por Favor informe o Valor do Aluguel do contrato")
               .NotNull().WithMessage("Por Favor informe o Valor do Aluguel do contrato");

            RuleFor(c => c.DataInicio)
                .NotEmpty().WithMessage("Por Favor informe a data de inicio do contrato")
                .NotNull().WithMessage("Por Favor informe a data de inicio do contrato");

            RuleFor(c => c.DataFim)
                .NotEmpty().WithMessage("Por Favor informe a data de fim do contrato")
                .NotNull().WithMessage("Por Favor informe a data de fim do contrato");
           
        }
    }
}
