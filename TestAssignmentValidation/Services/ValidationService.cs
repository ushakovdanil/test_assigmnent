using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Xml;
using TestAssignmentValidation.Models.Enum;
using TestAssignmentValidation.Validators;

namespace TestAssignmentValidation.Services
{
    public class ValidationService : IValidationService
    {
        private readonly IServiceProvider _serviceProvider;

        public ValidationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public bool Validate(string dataType, string dataValue)
        {
            var validator = GetValidator(dataType);
            return validator?.Validate(dataValue).IsValid ?? false;
        }

        private AbstractValidator<string> GetValidator(string dataType)
        {
            switch (dataType)
            {
                case nameof(UserDataType.Passport):
                    return _serviceProvider.GetService<PassportValidator>();
                case nameof(UserDataType.Rnokpp):
                    return _serviceProvider.GetService<RnokppValidator>();
                case nameof(UserDataType.BirthDate):
                    return _serviceProvider.GetService<BirthDateValidator>();
                case nameof(UserDataType.DeviceNumber):
                    return _serviceProvider.GetService<DeviceSerialNumberValidator>();
                default:
                    throw new ArgumentException("Unknown data type", nameof(dataType));
            }
        }
    }
}
