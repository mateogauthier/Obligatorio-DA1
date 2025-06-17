using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Exceptions
{
    public class MovieException : Exception
    {
        private MovieException(string message) : base(message)
        {
        }

        public static MovieException emptyNameError()
        {
            return new MovieException("Movie's name cannot be empty.");
        }

        public static MovieException noMainGenreError()
        {
            return new MovieException("Movies need at least one main genre.");
        }

        public static MovieException alreadySecondaryGenreError()
        {
            return new MovieException("Movie already has this genre as a secondary genre.");
        }

        public static MovieException alreadyMainGenreError()
        {
            return new MovieException("The movie already has this genre as main genre.");
        }
    }
}
