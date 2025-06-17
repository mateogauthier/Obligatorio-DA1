using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Exceptions
{
    public class PersonException : Exception
    {
        private PersonException(string message) : base(message)
        {
        }

        public static PersonException emptyNameError()
        {
            return new PersonException("Name cannot be empty.");
        }

        public static PersonException noBirthDateError()
        {
            return new PersonException("Date of birth required.");
        }

        public static PersonException WorksOnMovieError()
        {
            return new PersonException("This movie has already been registered.");
        }

        public static PersonException DidntWorkOnMovieError()
        {
            return new PersonException("The person did not work on that movie.");
        }
    }
}
