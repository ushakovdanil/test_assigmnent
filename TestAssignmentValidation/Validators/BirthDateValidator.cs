using FluentValidation;
using System;

namespace TestAssignmentValidation.Validators
{
    internal class BirthDateValidator : AbstractValidator<string>
    {
        public BirthDateValidator()
        {
            RuleFor(birthDate => birthDate)
                .NotEmpty()
                .Must(BeValidDate)
                .WithMessage("Date of birth format is incorrect.");
        }

        private bool BeValidDate(string date)
        {
            if (!DateTime.TryParse(date, out DateTime parsedDate))
            {
                return false;
            }

            return parsedDate < DateTime.Today; 
        }
    }
}
