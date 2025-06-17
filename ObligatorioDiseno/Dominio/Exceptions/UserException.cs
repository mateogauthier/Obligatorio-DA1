using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Exceptions
{
    public class UserException : Exception
    {
        private UserException(string message) : base(message)
        {
        }

        public static UserException lengthNameError()
        {
            return new UserException("Users name must have between 10 and 20 characters.");
        }

        public static UserException emptyEmailError()
        {
            return new UserException("Users e-mail cannot be empty.");
        }

        public static UserException lengthPasswordError()
        {
            return new UserException("Passwords must have between 10 and 30 characters.");
        }
    }
}
