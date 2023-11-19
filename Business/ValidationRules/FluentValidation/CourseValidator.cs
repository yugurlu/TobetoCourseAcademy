using System;
using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class CourseValidator : AbstractValidator<Course>
	{
		public CourseValidator()
		{
			RuleFor(p => p.Name).NotEmpty();
			RuleFor(p => p.Name).MinimumLength(2);
			RuleFor(p => p.Price).NotEmpty();
			RuleFor(p => p.Price).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
			RuleFor(p => p.Name).Must(StartWithA).WithMessage("course name must start with 'A'");
        }

        private bool StartWithA(string arg)
        {
			return arg.StartsWith('A');
        }
    }
}

