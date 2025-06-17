using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class GenreLogic : IGenreLogic
    {
        private IGenreRepository _genreRepository;
        private IMovieLogic _movieLogic;

        public GenreLogic(IGenreRepository genreRepository, IMovieLogic movieLogic = null)
        {
            _genreRepository = genreRepository;
            _movieLogic = movieLogic;
        }

        public Genre AddGenre(Genre genre)
        {
            IList<Genre> genreList = _genreRepository.GetAll();
            for (int i = 0; i < genreList.Count; i++)
            {
                if (genreList[i].Name.Equals(genre.Name)) throw GenreLogicException.genreExistsError();
            }
            return _genreRepository.Add(genre);
        }

        public IList<Genre> GetAll()
        {
            return _genreRepository.GetAll();
        }

        public Genre GetByName(string genreName)
        {
            IList<Genre> genres = _genreRepository.GetAll();
            for (int i = 0; i < genres.Count; i++)
            {
                if (genres[i].Name.Equals(genreName)) return genres[i];
            }
            throw GenreLogicException.genreNotFoundError(genreName);
        }

        public bool RemoveGenre(Genre genre)
        {
            if (!_genreRepository.Contain(genre)) throw GenreLogicException.genreNotFoundError(genre.Name);
            if (_movieLogic != null && _movieLogic.MoviesLinkedToGenre(genre)) throw GenreLogicException.linkedGenreRemoveError();
            return _genreRepository.Delete(genre);
        }
    }
}