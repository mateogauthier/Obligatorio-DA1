using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Exceptions
{
    public class PersonLogicException : Exception
    {
        public PersonLogicException(string message) : base(message)
        {
        }

        public static PersonLogicException personExistsError()
        {
            return new PersonLogicException("Person already exists.");
        }

        public static PersonLogicException personNotFound()
        {
            return new PersonLogicException("Person does not exist.");
        }
    }
}
