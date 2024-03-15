using System;
using TestAssignmentValidation.Services;

namespace TestAssignmentValidation
{
    public class Program
    {
        private static readonly ValidationService _validationService = new ValidationService();

        /*  For better user expierence we can modify console output before send args.
            Smth like this:
            Console.WriteLine("Choose data to validate:");
            Console.WriteLine("1. Passport");
            Console.WriteLine("2. Rnokpp Number");
            Console.WriteLine("3. Date of Birth");
            Console.WriteLine("4. Device Number (iOS, Android)");*/
        
        public static void Main(string[] args)
        {
            _validationService.ValidateUserData(args[0], args[1]);
        }
    }
}
