using FluentValidation.Results;
using Moq;
using TestAssignmentValidation.Models.Enum;
using TestAssignmentValidation.Services;
using TestAssignmentValidation.Validators;

namespace TestAssignmentValidation.Tests.Services
{
    public class ValidationServiceTests
    {

        [Fact]
        public void Validate_Password_Invalid_Data()
        {
            // Arrange
            var serviceProviderMock = new Mock<IServiceProvider>();
            var passportValidatorMock = new PassportValidator();
            serviceProviderMock.Setup(sp => sp.GetService(typeof(PassportValidator))).Returns(passportValidatorMock);

            var validationService = new ValidationService(serviceProviderMock.Object);

            // Act
            var result = validationService.Validate(nameof(UserDataType.Passport), "EEE121212");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Validate_Password_Valid_Data()
        {
            // Arrange
            var serviceProviderMock = new Mock<IServiceProvider>();
            var passportValidatorMock = new PassportValidator();
            serviceProviderMock.Setup(sp => sp.GetService(typeof(PassportValidator))).Returns(passportValidatorMock);

            var validationService = new ValidationService(serviceProviderMock.Object);

            // Act
            var result = validationService.Validate(nameof(UserDataType.Passport), "EE121212");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Validate_Rnokpp_Invalid_Data()
        {
            // Arrange
            var serviceProviderMock = new Mock<IServiceProvider>();
            var rnokppValidator = new RnokppValidator();
            serviceProviderMock.Setup(sp => sp.GetService(typeof(RnokppValidator))).Returns(rnokppValidator);

            var validationService = new ValidationService(serviceProviderMock.Object);

            // Act
            var result = validationService.Validate(nameof(UserDataType.Rnokpp), "EEE121212");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Validate_Rnokpp_Valid_Data()
        {
            // Arrange
            var serviceProviderMock = new Mock<IServiceProvider>();
            var rnokppValidator = new RnokppValidator();
            serviceProviderMock.Setup(sp => sp.GetService(typeof(RnokppValidator))).Returns(rnokppValidator);

            var validationService = new ValidationService(serviceProviderMock.Object);

            // Act
            var result = validationService.Validate(nameof(UserDataType.Rnokpp), "1212121212");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Validate_BirthDate_Invalid_Data()
        {
            // Arrange
            var serviceProviderMock = new Mock<IServiceProvider>();
            var birthDateValidator = new BirthDateValidator();
            serviceProviderMock.Setup(sp => sp.GetService(typeof(BirthDateValidator))).Returns(birthDateValidator);

            var validationService = new ValidationService(serviceProviderMock.Object);

            // Act
            var result = validationService.Validate(nameof(UserDataType.BirthDate), "01.22.2222");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Validate_BirthDate_Valid_Data()
        {
            // Arrange
            var serviceProviderMock = new Mock<IServiceProvider>();
            var birthDateValidator = new BirthDateValidator();
            serviceProviderMock.Setup(sp => sp.GetService(typeof(BirthDateValidator))).Returns(birthDateValidator);

            var validationService = new ValidationService(serviceProviderMock.Object);

            // Act
            var result = validationService.Validate(nameof(UserDataType.BirthDate), "01.01.2002");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Validate_DeviceNumber_Invalid_Data()
        {
            // Arrange
            var serviceProviderMock = new Mock<IServiceProvider>();
            var deviceSerialNumberValidator = new DeviceSerialNumberValidator();
            serviceProviderMock.Setup(sp => sp.GetService(typeof(DeviceSerialNumberValidator))).Returns(deviceSerialNumberValidator);

            var validationService = new ValidationService(serviceProviderMock.Object);

            // Act
            var result = validationService.Validate(nameof(UserDataType.DeviceNumber), "B5A648BA-262F-47BF-A0F5-4FDF68AC0rgC12");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Validate_DeviceNumber_Valid_Data()
        {
            // Arrange
            var serviceProviderMock = new Mock<IServiceProvider>();
            var deviceSerialNumberValidator = new DeviceSerialNumberValidator();
            serviceProviderMock.Setup(sp => sp.GetService(typeof(DeviceSerialNumberValidator))).Returns(deviceSerialNumberValidator);

            var validationService = new ValidationService(serviceProviderMock.Object);

            // Act
            var result = validationService.Validate(nameof(UserDataType.DeviceNumber), "B5A648BA-262F-47BF-A0F5-4FDF68AC0C12");

            // Assert
            Assert.True(result);
        }
    }
}
