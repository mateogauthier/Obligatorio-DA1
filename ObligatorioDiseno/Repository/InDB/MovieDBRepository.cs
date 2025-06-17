using Dominio;
using Dominio.Classes;
using Microsoft.SqlServer.Server;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InDB
{
    public class MovieDBRepository : IMovieRepository
    {
        public Movie Add(Movie movie)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                SysContext.Movies.Add(movie);
                SysContext.SaveChanges();
            }
            return movie;
        }

        public bool Contains(Movie movie)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                Movie movieOnDB = SysContext.Movies.FirstOrDefault(x => x.Name == movie.Name);
                if (movieOnDB != null) return true;
                return false;
            }
        }

        public IList<Movie> GetAll()
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                return SysContext.Movies.Include("Genre").Include("SecondaryGenreList").Include("Directors").Include("Actors").Where(x=>x.Genre != null).ToList();
            }
        }

        public bool Remove(Movie movie)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                Movie movieOnDB = SysContext.Movies.FirstOrDefault(x => x.Name == movie.Name);
                List<ActorRole> actorRoles = SysContext.ActorRoles.Where(x => x.Movie.Name.Equals(movieOnDB.Name)).ToList();
                SysContext.ActorRoles.RemoveRange(actorRoles);
                SysContext.Movies.Remove(movieOnDB);
                SysContext.SaveChanges();
                return true;
            }
        }
    }
}
