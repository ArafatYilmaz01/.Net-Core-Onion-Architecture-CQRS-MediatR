using System;

namespace OnionArchitectureApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Validation error occurred.")
        {
        }

        public ValidationException(string message) : base(message)
        {
        }

        public ValidationException(Exception innerException) : this(innerException.Message)
        {
        }
    }
}
