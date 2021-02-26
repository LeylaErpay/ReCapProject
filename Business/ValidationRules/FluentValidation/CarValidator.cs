using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Cars>
    {
        public CarValidator()
        {
            RuleFor(c => c.Descriptions).MinimumLength(2);
        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
