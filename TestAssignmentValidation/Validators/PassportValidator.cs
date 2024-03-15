using FluentValidation;

namespace TestAssignmentValidation.Validators
{
    public class PassportValidator : AbstractValidator<string>
    {
        public PassportValidator()
        {
            RuleFor(passport => passport)
                .NotEmpty()
                .Matches(@"^[A-ZА-Я]{2}\d{6}$")
                .WithMessage("Passport number format is incorrect.");
        }
    }
}
