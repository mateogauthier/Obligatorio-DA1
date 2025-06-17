using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IGenreRepository
    {
        Genre Add(Genre genre);
        bool Delete(Genre genre);
        bool Contain(Genre genre);
        IList<Genre> GetAll();
    }
}
