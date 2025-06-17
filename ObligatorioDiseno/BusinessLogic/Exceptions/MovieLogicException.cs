using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Exceptions
{
    public class MovieLogicException : Exception
    {
        public MovieLogicException(string message) : base(message)
        {
        }

        public static MovieLogicException movieExistsError()
        {
            return new MovieLogicException("The movie already exists.");
        }

        public static MovieLogicException movieNotFoundError()
        {
            return new MovieLogicException("The movie does not exists.");
        }
    }
}
