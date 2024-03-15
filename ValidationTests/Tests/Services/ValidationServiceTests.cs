using TestAssignmentValidation.Services;

namespace TestAssignmentValidation.Tests.Services
{
    public class ValidationServiceTests
    {

        [Fact]
        public void ValidateUserData_Passport_Failure()
        {
            // arrange
            ValidationService validationService = new();
            // act
            var result = validationService.ValidateUserData("Passport", "УА12121212");
            // assert
            Assert.False(result);
        }

        [Fact]
        public void ValidateUserData_Passport_Success()
        {
            // arrange
            ValidationService validationService = new();
            // act
            var result = validationService.ValidateUserData("Passport", "УА121212");
            // assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateUserData_Rnokpp_Failure()
        {
            // arrange
            ValidationService validationService = new ();
            // act
            var result = validationService.ValidateUserData("Rnokpp", "1122334455111");
            // assert
            Assert.False(result);
            //Here we also can check message errors from the validator
        }

        [Fact]
        public void ValidateUserData_Rnokpp_Success()
        {
            // arrange
            ValidationService validationService = new();
            // act
            var result = validationService.ValidateUserData("Rnokpp", "1122334455");
            // assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateUserData_BirthDate_Failure()
        {
            // arrange
            ValidationService validationService = new();
            // act
            var result = validationService.ValidateUserData("BirthDate", "01.01.2222");
            // assert
            Assert.False(result);
        }

        [Fact]
        public void ValidateUserData_BirthDate_Success()
        {
            // arrange
            ValidationService validationService = new();
            // act
            var result = validationService.ValidateUserData("BirthDate", "01.01.2002");
            // assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateUserData_DeviceNumber_Failure()
        {
            // arrange
            ValidationService validationService = new();
            // act
            var result = validationService.ValidateUserData("DeviceNumber", "01.01.2222");
            // assert
            Assert.False(result);
        }

        [Fact]
        public void ValidateUserData_DeviceNumber_Success()
        {
            // arrange
            ValidationService validationService = new();
            // act
            var result = validationService.ValidateUserData("DeviceNumber", "B5A648BA-262F-47BF-A0F5-4FDF68AC0C12");
            // assert
            Assert.True(result);
        }
    }
}
