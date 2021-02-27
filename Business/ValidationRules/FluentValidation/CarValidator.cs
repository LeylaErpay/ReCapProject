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
            //RuleFor(c => c.Descriptions).MinimumLength(2).WithMessage("Description must be at least 2 characters");
            //RuleFor(c => c.Descriptions).NotEmpty();
            //RuleFor(c => c.Descriptions).NotNull();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(100).When(c => c.BrandId == 1);
            RuleFor(c => c.ModelYear).LessThan(DateTime.Now.Year);
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.BrandId).GreaterThan(0);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).GreaterThan(0);
            RuleFor(c => c.ColorId).NotEmpty();

           // RuleFor(c => c.Descriptions).Must(StartWithA).When(c => c.Descriptions != null).WithMessage("Description Must start with the letter A");
        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
