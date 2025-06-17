using Dominio;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IMovieLogic
    {
        Movie AddMovie(Movie movie);
        bool DeleteMovie(Movie movie);
        bool Contains(Movie movie);
        bool MoviesLinkedToGenre(Genre genre);
        IList<Movie> GetAllMovies();
        IList<Movie> GetAllMoviesSortedByGenre();
        IList<Movie> GetAllMoviesSortedBySponsored();
        IList<Movie> GetAllMoviesSortedByScore(string emailUser, string profileName);
        IList<string> GetActors(Movie movie);
        IList<Person> GetDirectors(Movie movie);
        IList<Movie> GetSeenByProfile(string emailUser, string profileName);
        IList<Movie> GetMoviesByActorsAlphabeticalOrder(List<Person> actors);
        IList<Movie> GetMoviesByActorsChronologicalOrder(List<Person> actors);
        IList<Movie> GetMoviesByDirectorsAlphabeticalOrder(List<Person> directors);
        IList<Movie> GetMoviesByDirectorsChronologicalOrder(List<Person> directors);
    }
}
