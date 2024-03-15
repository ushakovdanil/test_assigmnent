using System;
using System.Xml;
using TestAssignmentValidation.Models.Enum;
using TestAssignmentValidation.Validators;

namespace TestAssignmentValidation.Services
{
    public class ValidationService
    {
        //Methods for validating specific user data.
        private bool ValidatePassportId(string passportId)
        {
            return new PassportValidator().Validate(passportId).IsValid;
        }

        private bool ValidateRnokpp(string rnokpp)
        {
            return new RnokppValidator().Validate(rnokpp).IsValid;
        }

        private bool ValidateBirthDate(string birthDate)
        {
            return new BirthDateValidator().Validate(birthDate).IsValid;
        }

        private bool ValidateDeviceSerialNumber(string serialNumber)
        {
            return new DeviceSerialNumberValidator().Validate(serialNumber).IsValid;
        }

        //Use ValidateUserData for validate some data from user and return validation result to console and logic flow.
        //In future you can modify this method for return specific model with result and error message.
        public bool ValidateUserData(string dataName, string dataValue)
        {
            bool result = false;
            switch(dataName)
            {
                case nameof(UserDataType.Passport):
                    result = ValidatePassportId(dataValue);
                    break;

                case nameof(UserDataType.Rnokpp):
                    result = ValidateRnokpp(dataValue);
                    break;

                case nameof(UserDataType.BirthDate):
                    result = ValidateBirthDate(dataValue);
                    break;

                case nameof(UserDataType.DeviceNumber):
                    result = ValidateDeviceSerialNumber(dataValue);
                    break;

                default:
                    break;
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
