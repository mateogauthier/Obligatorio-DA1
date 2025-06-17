using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InMemory
{
    public class GenreMemoryRepository : IGenreRepository
    {
        private IList<Genre> _genres;
        public GenreMemoryRepository()
        {
            _genres = new List<Genre>();
        }

        public Genre Add(Genre genre)
        {
            _genres.Add(genre);
            return genre;
        }
        public bool Delete(Genre genre)
        {
            _genres.Remove(genre);
            return true;
        }
        public bool Contain(Genre genre)
        {
            return _genres.Contains(genre);
        }
        public IList<Genre> GetAll()
        {
            return _genres;
        }

    }
}
