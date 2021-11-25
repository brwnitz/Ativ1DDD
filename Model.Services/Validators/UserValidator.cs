using FluentValidation;
using Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please enter the name.")
                .NotNull().WithMessage("Please enter the name.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Please enter the email.")
                .NotNull().WithMessage("Please enter the email.");            
        }
    }
}
