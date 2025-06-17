using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Exceptions
{
    public class GenreException : Exception
    {
        private GenreException(string message) : base(message)
        {
        }

        public static GenreException emptyNameError()
        {
            return new GenreException("Genre's name cannot be empty.");
        }
    }
}
