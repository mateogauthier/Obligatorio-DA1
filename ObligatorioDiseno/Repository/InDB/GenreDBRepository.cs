using Dominio;
using Dominio.Classes;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InDB
{
    public class GenreDBRepository : IGenreRepository
    {
        public Genre Add(Genre genre)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                SysContext.Genres.Add(genre);
                SysContext.SaveChanges();
            }
            return genre;
        }

        public bool Contain(Genre genre)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                Genre genreOnDB = SysContext.Genres.FirstOrDefault(x => x.Name == genre.Name);
                if (genreOnDB != null) return true;
                return false;
            }
        }

        public bool Delete(Genre genre)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                Genre genreOnDB = SysContext.Genres.FirstOrDefault(x => x.Name == genre.Name);
                List<Genre> genres = SysContext.Genres.Where(x => x.Name.Equals(genreOnDB.Name)).ToList();
                SysContext.Genres.RemoveRange(genres);
                SysContext.SaveChanges();
                return true;
            }
        }

        public IList<Genre> GetAll()
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                List<Genre> genres = new List<Genre>();
                foreach (Genre g in SysContext.Genres.ToList())
                {
                    if (genres.Where(x => x.Name.Equals(g.Name)).ToList().Count < 1) genres.Add(g);
                }
                return genres;
            }
        }
    }
}
