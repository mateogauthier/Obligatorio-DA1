using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IMovieRepository
    {
        Movie Add(Movie movie);
        bool Remove(Movie movie);
        bool Contains(Movie movie);
        IList<Movie> GetAll();
    }
}
