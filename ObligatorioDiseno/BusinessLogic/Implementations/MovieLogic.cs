using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Classes;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class MovieLogic : IMovieLogic
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IViewLogic _viewLogic;
        private readonly IPersonLogic _personLogic;

        public MovieLogic(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public MovieLogic(IMovieRepository movieRepository, IViewLogic viewLogic)
        {
            _movieRepository = movieRepository;
            _viewLogic = viewLogic;
        }

        public MovieLogic(IMovieRepository movieRepository, IViewLogic viewLogic, IPersonLogic personLogic)
        {
            _movieRepository = movieRepository;
            _viewLogic = viewLogic;
            _personLogic = personLogic;
        }

        public Movie AddMovie(Movie movie)
        {
            if (Contains(movie)) throw MovieLogicException.movieExistsError();
            return _movieRepository.Add(movie);
        }

        public bool Contains(Movie movie)
        {
            IList<Movie> movies = _movieRepository.GetAll();
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Name.Equals(movie.Name)) return true;
            }
            return false;
        }

        public bool DeleteMovie(Movie movie)
        {
            if (!_movieRepository.Contains(movie)) throw MovieLogicException.movieNotFoundError();
            return _movieRepository.Remove(movie);
        }

        public IList<Movie> GetAllMovies()
        {
            return _movieRepository.GetAll();
        }

        public bool MoviesLinkedToGenre(Genre genre)
        {
            return _movieRepository.GetAll()
                .Any(x => (x.Genre.Name == genre.Name) || (x.SecondaryGenreList.Contains(genre)));
        }

        public IList<Movie> GetAllMoviesSortedByGenre()
        {
            IList<Movie> moviesToSort = _movieRepository.GetAll();
            try
            {
                IList<Movie> SortedMovies = moviesToSort.OrderBy(x => x.Genre.Name).
                ThenBy(x => x.Name).ToList();
                return SortedMovies;
            }
            catch (NullReferenceException)
            {
                return new List<Movie>();
            }
        }

        public IList<Movie> GetAllMoviesSortedByScore(string emailUser, string profileName)
        {
            IList<Movie> moviesToSort = _movieRepository.GetAll();
            IList<Movie> SortedMovies = moviesToSort.OrderByDescending(x => GetScoreOfMovieByUserProfile(x,emailUser,profileName)).
                ThenBy(x => x.Name).ToList();
            return SortedMovies;
        }

        public int GetScoreOfMovieByUserProfile(Movie movie, string emailUser, string profileName)
        {
            int score = 0;
            IList<View> viewsFromProfile = _viewLogic.GetAllFromProfile(emailUser, profileName);
            IList<Movie> Movies = GetAllMovies();
            for (int i = 0; i < Movies.Count; i++)
            {
                for (int j = 0; j < viewsFromProfile.Count; j++)
                {
                    //Check movie name
                    if (Movies[i].Name.Equals(movie.Name) && viewsFromProfile[j].MovieName.Equals(movie.Name))
                    {
                        score++; //Points per view
                        score += viewsFromProfile[j].Rating; //Points per user score
                    }
                }
            }
            return score;
        }

        public IList<Movie> GetAllMoviesSortedBySponsored()
        {
            IList<Movie> moviesToSort = _movieRepository.GetAll();
            IList<Movie> SortedMovies = moviesToSort.OrderByDescending(x => x.IsSponsored).
                ThenBy(x=> x.Genre.Name).
                ThenBy(x => x.Name).ToList();
            return SortedMovies;
        }

        public IList<string> GetActors(Movie movie)
        {
            IList<string> actors = new List<string>();
            foreach(var actorRole in movie.Actors)
            {
                if (!actors.Contains(actorRole.Actor)) actors.Add(actorRole.Actor);
            }
            return actors;
        }

        public IList<Person> GetDirectors(Movie movie)
        {
            return movie.Directors.Distinct().ToList();
        }

        public IList<Movie> GetSeenByProfile(string emailUser, string profileName)
        {
            IList<Movie> movies = _movieRepository.GetAll();
            List<Movie> moviesSeen = new List<Movie>();
            IList<View> views = _viewLogic.GetAllFromProfile(emailUser, profileName);

            foreach (View v in views.OrderBy(x => x.Id))
            {
                foreach (Movie m in movies)
                {
                    if (m.Name.Equals(v.MovieName) && !moviesSeen.Contains(m))
                    {
                        moviesSeen.Add(m);
                    }
                }
            }
            return moviesSeen;
        }

        private IList<Movie> GetMoviesByActors(List<Person> actors)
        {
            List<string> movieNames = new List<string>();
            foreach (Person p in actors)
            {
                foreach(Movie m in p.MoviesActed)
                {
                    if (!movieNames.Contains(m.Name)) movieNames.Add(m.Name);
                }
            }
            return _movieRepository.GetAll().Where(x => movieNames.Contains(x.Name)).ToList();
        }

        public IList<Movie> GetMoviesByActorsAlphabeticalOrder(List<Person> actors)
        {
            IList<Movie> movies = GetMoviesByActors(actors);
            return movies.OrderBy(x => x.Name).ToList();
        }

        public IList<Movie> GetMoviesByActorsChronologicalOrder(List<Person> actors)
        {
            IList<Movie> movies = GetMoviesByActors(actors);
            return movies.OrderBy(x => x.ReleaseYear).ToList();
        }

        private IList<Movie> GetMoviesByDirectors(List<Person> directors)
        {
            List<string> movieNames = new List<string>();
            foreach (Person p in directors)
            {
                foreach (Movie m in p.MoviesDirected)
                {
                    if (!movieNames.Contains(m.Name)) movieNames.Add(m.Name);
                }
            }
            return _movieRepository.GetAll().Where(x => movieNames.Contains(x.Name)).ToList();
        }

        public IList<Movie> GetMoviesByDirectorsAlphabeticalOrder(List<Person> directors)
        {
            IList<Movie> movies = GetMoviesByDirectors(directors);
            return movies.OrderBy(x => x.Name).ToList();
        }

        public IList<Movie> GetMoviesByDirectorsChronologicalOrder(List<Person> directors)
        {
            IList<Movie> movies = GetMoviesByDirectors(directors);
            return movies.OrderBy(x => x.ReleaseYear).ToList();
        }
    }
}
