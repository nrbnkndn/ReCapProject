﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.Descriptions).MinimumLength(2);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(0);
            RuleFor(p => p.ModelYear).GreaterThanOrEqualTo(1970);
        }
    }
}
