using FluentValidation;
using Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("Please enter the CPF.")
                .NotNull().WithMessage("Please enter the CPF.");
            
        }
    }
}
