using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InMemory
{
    public class MovieMemoryRepository : IMovieRepository
    {
        private IList<Movie> _movies;
        public MovieMemoryRepository()
        {
            _movies = new List<Movie>();
        }

        public Movie Add(Movie movie)
        {
            _movies.Add(movie);
            return movie;
        }

        public IList<Movie> GetAll()
        {
            return _movies;
        }

        public bool Remove(Movie movie)
        {
            for (int i = 0; i < _movies.Count; i++)
            {
                if (_movies[i].Name.Equals(movie.Name))
                {
                    _movies.RemoveAt(i);
                    return true;
                }
            };
            return false;
        }

        public bool Contains(Movie movie)
        {
            return _movies.Contains(movie);
        }
    }
}
