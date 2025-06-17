using Dominio;
using Dominio.Classes;
using Microsoft.SqlServer.Server;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dominio.Exceptions;

namespace Repository.InDB
{
    public class PersonDBRepository : IPersonRepository
    {
        public Person Add(Person newPerson)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                SysContext.Persons.Add(newPerson);
                SysContext.SaveChanges();
            }
            return newPerson;
        }

        public bool AddMovieActor(Movie movie, string actor, String role)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                if (movie == null || actor == null || string.IsNullOrEmpty(role)) return false;

                Person personOnDB = SysContext.Persons.Include("MoviesActed").FirstOrDefault(x => x.Name.Equals(actor));
                Movie movieOnDB = SysContext.Movies.Include("Actors").FirstOrDefault(x => x.Name.Equals(movie.Name));
                ActorRole actorRole = movieOnDB.Actors.FirstOrDefault(x => x.Movie.Name.Equals(movie.Name) && x.Role.Equals(role));

                if (actorRole == null && movieOnDB != null && personOnDB != null && !movieOnDB.Actors.Any(x => x.Role == role) )
                {
                    if (!personOnDB.MoviesActed.Contains(movieOnDB))
                    {
                        personOnDB.MoviesActed.Add(movieOnDB);
                    }
                    movieOnDB.Actors.Add(new ActorRole() { Actor = personOnDB.Name, Movie = movieOnDB, Role = role });
                    SysContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool AddMovieDirector(Movie movie, Person person)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                if (movie == null || person == null) return false;

                Person personOnDB = SysContext.Persons.Include("MoviesDirected").FirstOrDefault(x => x.Name.Equals(person.Name));
                Movie movieOnDB = SysContext.Movies.FirstOrDefault(x => x.Name.Equals(movie.Name));

                if (movieOnDB != null && personOnDB != null && !movieOnDB.Directors.Contains(personOnDB))
                {
                    if (!personOnDB.MoviesDirected.Contains(movieOnDB))
                    {
                        personOnDB.MoviesDirected.Add(movieOnDB);
                    }
                    movieOnDB.Directors.Add(personOnDB);
                    SysContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool Contains(Person person)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                Person personOnDB = SysContext.Persons.FirstOrDefault(x => x.Id == person.Id);
                if (personOnDB != null) return true;
                return false;
            }
        }

        public IList<Person> GetAll()
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                List<Person> persons = new List<Person>();
                foreach(Person p in SysContext.Persons.Include("MoviesActed").Include("MoviesDirected").ToList())
                {
                    if (persons.Where(x => x.Name.Equals(p.Name)).ToList().Count < 1) persons.Add(p);
                }
                return persons;
            }
        }

        public IList<Person> GetAlltoSearch()
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                return SysContext.Persons.Include("MoviesActed").Include("MoviesDirected").ToList();
            }
        }

        public IList<Movie> GetAllMoviesWorkedOn(Person person)
        {
            return GetAllMoviesActed(GetByName(person.Name)).Concat(GetAllMoviesDirected(GetByName(person.Name))).Distinct().ToList();
        }

        public IList<Movie> GetAllMoviesDirected(Person person)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                Person personOnDB = SysContext.Persons.Include("MoviesDirected").FirstOrDefault(x => x.Name.Equals(person.Name));
                return personOnDB.MoviesDirected.ToList();
            }
        }

        public IList<Movie> GetAllMoviesActed(Person person)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                Person personOnDB = SysContext.Persons.Include("MoviesActed").FirstOrDefault(x => x.Name.Equals(person.Name));
                return personOnDB.MoviesActed.ToList();
            }
        }

        public bool Remove(Person person)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                Person personOnDB = SysContext.Persons.Include("MoviesDirected").Include("MoviesActed").FirstOrDefault(x => x.Id == person.Id);
                List<Person> persons = SysContext.Persons.Where(x => x.Name.Equals(personOnDB.Name)).ToList();
                SysContext.Persons.RemoveRange(persons);
                SysContext.SaveChanges();
                return true;
            }
        }

        public Person GetByName(String name)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                return SysContext.Persons.Include("MoviesDirected").Include("MoviesActed").FirstOrDefault(x => x.Name.Equals(name));
            }
        }

        public bool RemoveMovieActor(Movie movie, string actor)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                if (movie == null || actor == null) return false;

                Person personOnDB = SysContext.Persons.Include("MoviesActed").FirstOrDefault(x => x.Name.Equals(actor));
                Movie movieOnDB = SysContext.Movies.Include("Actors").FirstOrDefault(x => x.Name.Equals(movie.Name));

                if (movieOnDB != null && movieOnDB.Actors.FirstOrDefault(x => x.Actor == personOnDB.Name) != null)
                {
                    personOnDB.MoviesActed.RemoveAll(x => x.Name.Equals(movieOnDB.Name));

                    foreach (var actorRole in movieOnDB.Actors.Where(x => x.Actor == personOnDB.Name).ToList())
                    {
                        movieOnDB.Actors.Remove(actorRole);
                    }
                    SysContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool RemoveMovieDirector(Movie movie, Person person)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                if (movie == null || person == null) return false;

                Person personOnDB = SysContext.Persons.Include("MoviesDirected").FirstOrDefault(x => x.Name.Equals(person.Name));
                Movie movieOnDB = SysContext.Movies.Include("Directors").FirstOrDefault(x => x.Name.Equals(movie.Name));

                if (movieOnDB != null && movieOnDB.Directors.Contains(personOnDB))
                {
                    foreach (var m in personOnDB.MoviesDirected.ToList())
                    {
                        if (m.Name.Equals(movieOnDB.Name))
                        {
                            personOnDB.MoviesDirected.Remove(movieOnDB);
                        }
                    }
                    movieOnDB.Directors.Remove(personOnDB);
                    SysContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public Person Update(Person person, Person UpdatedPerson)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                if (UpdatedPerson == null) return person;

                Person personOnDB = SysContext.Persons.Include("MoviesActed").Include("MoviesDirected").FirstOrDefault(x => x.Name.Equals(person.Name));
                personOnDB.Name = UpdatedPerson.Name;
                personOnDB.BirthDate = UpdatedPerson.BirthDate;
                personOnDB.MoviesActed = UpdatedPerson.MoviesActed;
                personOnDB.MoviesDirected = UpdatedPerson.MoviesDirected;
                personOnDB.Picture = UpdatedPerson.Picture;
                SysContext.SaveChanges();
                return UpdatedPerson;
            }
        }
    }
}