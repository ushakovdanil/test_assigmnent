using Microsoft.Extensions.DependencyInjection;
using System;
using TestAssignmentValidation.Services;
using TestAssignmentValidation.Validators;

namespace TestAssignmentValidation
{
    public class Program
    {

        /*  For better user experience we can modify console output before send args.
            Smth like this:
            Console.WriteLine("Choose data to validate:");
            Console.WriteLine("1. Passport");
            Console.WriteLine("2. Rnokpp Number");
            Console.WriteLine("3. Date of Birth");
            Console.WriteLine("4. Device Number (iOS, Android)");*/

        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            RunApplication(serviceProvider, args);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<PassportValidator>();
            services.AddTransient<RnokppValidator>();
            services.AddTransient<BirthDateValidator>();
            services.AddTransient<DeviceSerialNumberValidator>();
            services.AddTransient<IValidationService, ValidationService>();
        }

        private static void RunApplication(IServiceProvider serviceProvider, string[] args)
        {
            var validationService = serviceProvider.GetRequiredService<IValidationService>();
            var isValidData = validationService.Validate(args[0], args[1]);
            Console.WriteLine(isValidData);
        }

    }
}
