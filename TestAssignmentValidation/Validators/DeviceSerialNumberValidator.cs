using FluentValidation;
using System;

namespace TestAssignmentValidation.Validators
{
    internal class DeviceSerialNumberValidator : AbstractValidator<string>
    {
        public DeviceSerialNumberValidator()
        {
            RuleFor(deviceNumber => deviceNumber)
                .NotEmpty()
                .Must(BeValidDeviceNumber)
                .WithMessage("Device number format is incorrect.");
        }

        private bool BeValidDeviceNumber(string deviceNumber)
        {
            return Guid.TryParse(deviceNumber, out _);
        }
    }
}
