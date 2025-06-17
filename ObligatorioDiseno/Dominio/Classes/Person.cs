using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class Person
    {
        public int Id { get; set; }

        private String _name;
        public string Name { get => _name ; set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw PersonException.emptyNameError();
                }
            }
        }

        private String _bday;
        public string BirthDate
        {
            get => _bday; set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _bday = value;
                }
                else
                {
                    throw PersonException.noBirthDateError();
                }
            }
        }

        public string Picture { get; set; }

        public List<Movie> MoviesActed { get; set; } = new List<Movie>();
        public List<Movie> MoviesDirected { get; set; } = new List<Movie>();


        public void AddActed(Movie movie)
        {
            if (MoviesActed.Contains(movie)) throw PersonException.WorksOnMovieError();
            MoviesActed.Add(movie);
        }

        public void AddDirected(Movie movie)
        {
            if (MoviesDirected.Contains(movie)) throw PersonException.WorksOnMovieError();
            MoviesDirected.Add(movie);
        }

        public Movie RemoveActed(Movie movieToDelete)
        {
            foreach (var movie in MoviesActed)
            {
                if (movie.Name.Equals(movieToDelete.Name))
                {
                    MoviesActed.Remove(movie);
                    return movie;
                }
            }
            throw PersonException.DidntWorkOnMovieError();
        }

        public Movie RemoveDirected(Movie movieToDelete)
        {
            foreach (var movie in MoviesDirected)
            {
                if (movie.Name.Equals(movieToDelete.Name))
                {
                    MoviesDirected.Remove(movie);
                    return movie;
                }
            }
            throw PersonException.DidntWorkOnMovieError();
        }
    }
}
