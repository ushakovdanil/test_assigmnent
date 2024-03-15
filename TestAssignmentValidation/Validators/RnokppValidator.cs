using FluentValidation;

namespace TestAssignmentValidation.Validators
{
    internal class RnokppValidator : AbstractValidator<string>
    {
        public RnokppValidator()
        {
            RuleFor(pnokppNumber => pnokppNumber)
                .NotEmpty()
                .Length(10)
                .Matches(@"^\d+$")
                .WithMessage("Rnokpp number must be 10 digits.");
        }
    }
}
