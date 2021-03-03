using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p => p.email).NotEmpty();
            RuleFor(p => p.userPassword).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.LastName).MinimumLength(2);
        }
    }
}
