using Dominio;
using Dominio.Classes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InDB
{
    public class SystemDbContext : DbContext
    {
        public DbSet<View> Views { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<ActorRole> ActorRoles { get; set; }

        public SystemDbContext(): base("MidnightDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().Property(x => x.Pin).IsOptional();
            modelBuilder.Entity<Person>().HasMany(x => x.MoviesDirected).WithMany(y => y.Directors);
            modelBuilder.Entity<Movie>().HasMany(x => x.SecondaryGenreList).WithMany(y => y.RelatedMovies);
            base.OnModelCreating(modelBuilder);
        }
    }
}
