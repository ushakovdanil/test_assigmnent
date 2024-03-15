using FluentValidation;

namespace TestAssignmentValidation.Validators
{
    public class RnokppValidator : AbstractValidator<string>
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
