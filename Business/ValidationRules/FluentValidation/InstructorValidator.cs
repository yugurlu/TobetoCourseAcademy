using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class InstructorValidator : AbstractValidator<Instructor>
    {
        public InstructorValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.FirstName.Length >= 3);
            RuleFor(p => p.LastName.Length >= 3);
        }
    }
}