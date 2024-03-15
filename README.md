# TestAssignment Validation

This project is a C# application for validating various types of user data, such as passport numbers, rnokpp numbers, dates of birth, and device serial numbers.

## Project Description

The goal of this project is to provide a simple and reliable way to validate different types of user data commonly encountered in applications. It includes validators for the following types of data:

- Passport numbers
- Tax identification numbers (Rnokpp)
- Dates of birth
- Device serial numbers

Each validator is implemented using the FluentValidation library, ensuring robust and customizable validation rules.

## How to Use

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Build the solution to compile the project(In Release mode).
4. Open a command prompt or terminal window.
5. Navigate to the directory containing the compiled executable ("TestAssignmentDataValidation\TestAssignmentValidation\bin\Release\netcoreapp3.1").
6. To validate a specific type of user data, use the following command format:             
  TestAssignmentValidation.exe Passport ER121212              
  TestAssignmentValidation.exe Rnokpp 1212121212               
  TestAssignmentValidation.exe BirthDate 01.05.2024                
  TestAssignmentValidation.exe DeviceNumber B5A648BA-262F-47BF-A0F5-4FDF68AC0C12                
8. After running the command, the application will display whether the provided data is valid or not.


## Technologies Used

- C# (.NET Core)
- Microsoft.Extensions.DependencyInjection
- FluentValidation
- XUnit

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, please open an issue or submit a pull request.
