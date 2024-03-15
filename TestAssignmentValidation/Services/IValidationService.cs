using System;
using System.Collections.Generic;
using System.Text;

namespace TestAssignmentValidation.Services
{
    internal interface IValidationService
    {
        bool Validate(string dataType, string dataValue);
    }
}
