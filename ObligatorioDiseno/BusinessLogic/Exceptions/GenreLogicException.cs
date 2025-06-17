using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Exceptions
{
    public class GenreLogicException : Exception
    {
        public GenreLogicException(string message) : base(message)
        {
        }

        public static GenreLogicException genreExistsError()
        {
            return new GenreLogicException("The genre already exists.");
        }

        public static GenreLogicException genreNotFoundError(string genreName)
        {
            return new GenreLogicException("The genre called \"" + genreName + "\" does not exist.");
        }

        public static GenreLogicException linkedGenreRemoveError()
        {
            return new GenreLogicException("A genre with movies linked cannot be removed.");
        }
    }
}
