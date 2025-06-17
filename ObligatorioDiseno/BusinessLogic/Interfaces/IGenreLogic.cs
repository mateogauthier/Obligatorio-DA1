using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IGenreLogic
    {
        Genre AddGenre(Genre genre);
        bool RemoveGenre(Genre genre);
        IList<Genre> GetAll();
        Genre GetByName(String genreName);
    }
}
