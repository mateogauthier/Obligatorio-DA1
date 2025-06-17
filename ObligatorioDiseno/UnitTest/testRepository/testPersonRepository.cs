using Dominio;
using Dominio.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.InDB;
using Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace UnitTest.testRepository
{
    [TestClass]
    public class testPersonRepository
    {
        [TestCleanup]
        public void Clean()
        {
            using (var context = new SystemDbContext())
            {
                var roles = context.ActorRoles;
                foreach (var cat in roles)
                {
                    context.ActorRoles.Remove(cat);
                }
                context.SaveChanges();
            }
            using (var context = new SystemDbContext())
            {
                var movies = context.Movies;
                foreach (var cat in movies)
                {
                    context.Movies.Remove(cat);
                }
                context.SaveChanges();
            }
            using (var context = new SystemDbContext())
            {
                var genres = context.Genres;
                foreach (var cat in genres)
                {
                    context.Genres.Remove(cat);
                }
                context.SaveChanges();
            }
            using (var context = new SystemDbContext())
            {
                var views = context.Views;
                foreach (var cat in views)
                {
                    context.Views.Remove(cat);
                }
                context.SaveChanges();
            }
            using (var context = new SystemDbContext())
            {
                var persons = context.Persons;
                foreach (var cat in persons)
                {
                    context.Persons.Remove(cat);
                }
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void AddPerson()
        {
            IPersonRepository repo = new PersonDBRepository();
            Person personToAdd = new Person() {
                Id = 201,
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            repo.Add(personToAdd);

            Assert.IsTrue(repo.Contains(personToAdd));
        }

        [TestMethod]
        public void UpdatePerson()
        {
            IPersonRepository repo = new PersonDBRepository();
            Person personToAdd = new Person()
            {
                Id = 201,
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            Person UpdatedPersonData = new Person()
            {
                Name = "TestPersonUpdated",
                BirthDate = "1980/10/10",
            };
            repo.Add(personToAdd);
            repo.Update(personToAdd, UpdatedPersonData);

            Assert.AreEqual(UpdatedPersonData.Name, repo.GetAll()[0].Name);
        }

        [TestMethod]
        public void RemovePerson()
        {
            IPersonRepository repo = new PersonDBRepository();
            Person personToAdd = new Person()
            {
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            repo.Add(personToAdd);
            repo.Remove(personToAdd);

            Assert.IsFalse(repo.Contains(personToAdd));
        }

        [TestMethod]
        public void GetAllPersons()
        {
            IPersonRepository repo = new PersonDBRepository();
            Person personToAdd = new Person()
            {
                Id = 201,
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            repo.Add(personToAdd);

            Assert.AreEqual(1, repo.GetAll().Count);
        }

        [TestMethod]
        public void GetAllPersonstoSearch()
        {
            IPersonRepository repo = new PersonDBRepository();
            Person personToAdd = new Person()
            {
                Id = 201,
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            repo.Add(personToAdd);

            Assert.AreEqual(1, repo.GetAlltoSearch().Count);
        }

        [TestMethod]
        public void AddMovieToDirector()
        {
            IPersonRepository repoPerson = new PersonDBRepository();
            IMovieRepository repoMovie = new MovieDBRepository();
            Person personToAdd = new Person()
            {
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            Movie movieToAdd = new Movie()
            {
                Name = "MovieTest",
                Description = "DescriptionTest"
            };
            repoMovie.Add(movieToAdd);
            repoPerson.Add(personToAdd);
            repoPerson.AddMovieDirector(movieToAdd, personToAdd);

            IList<Movie> m = repoPerson.GetAllMoviesWorkedOn(repoPerson.GetByName(personToAdd.Name));
            Assert.AreEqual(1, m.Count);
            Assert.AreEqual(1, m[0].Directors.Count);
        }

        [TestMethod]
        public void AddMovieToActor()
        {
            IPersonRepository repoPerson = new PersonDBRepository();
            IMovieRepository repoMovie = new MovieDBRepository();
            Person personToAdd = new Person()
            {
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            Movie movieToAdd = new Movie()
            {
                Name = "MovieTest",
                Description = "DescriptionTest"
            };
            repoMovie.Add(movieToAdd);
            repoPerson.Add(personToAdd);
            repoPerson.AddMovieActor(movieToAdd, personToAdd.Name, "role");

            IList<Movie> m = repoPerson.GetAllMoviesWorkedOn(repoPerson.GetByName(personToAdd.Name));
            Assert.AreEqual(1, m.Count);
        }

        [TestMethod]
        public void MovieRoleAddTwice()
        {
            IPersonRepository repoPerson = new PersonDBRepository();
            IMovieRepository repoMovie = new MovieDBRepository();
            Person personToAdd = new Person()
            {
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            Movie movieToAdd = new Movie()
            {
                Name = "MovieTest",
                Description = "DescriptionTest"
            };
            repoMovie.Add(movieToAdd);
            repoPerson.Add(personToAdd);
            repoPerson.AddMovieActor(movieToAdd, personToAdd.Name, "role");

            Assert.IsFalse(repoPerson.AddMovieActor(movieToAdd, personToAdd.Name, "role"));
        }

        [TestMethod]
        public void RemoveMovieFromDirector()
        {
            IPersonRepository repoPerson = new PersonDBRepository();
            IMovieRepository repoMovie = new MovieDBRepository();
            Person personToAdd = new Person()
            {
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            Movie movieToAdd = new Movie()
            {
                Name = "MovieTest",
                Description = "DescriptionTest"
            };
            repoMovie.Add(movieToAdd);
            repoPerson.Add(personToAdd);
            repoPerson.AddMovieDirector(movieToAdd, personToAdd);
            repoPerson.RemoveMovieDirector(movieToAdd, personToAdd);

            Assert.AreEqual(0, repoPerson.GetAllMoviesWorkedOn(repoPerson.GetByName(personToAdd.Name)).Count);
        }

        [TestMethod]
        public void RemoveMovieFromDirectorNotWorkedOn()
        {
            IPersonRepository repoPerson = new PersonDBRepository();
            Person personToAdd = new Person()
            {
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            Movie movieToAdd = new Movie()
            {
                Name = "MovieTest",
                Description = "DescriptionTest"
            };

            Assert.IsFalse(repoPerson.RemoveMovieDirector(movieToAdd, personToAdd));
        }

        [TestMethod]
        public void RemoveMovieFromActor()
        {
            IPersonRepository repoPerson = new PersonDBRepository();
            IMovieRepository repoMovie = new MovieDBRepository();
            Person personToAdd = new Person()
            {
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            Movie movieToAdd = new Movie()
            {
                Name = "MovieTest",
                Description = "DescriptionTest"
            };
            repoMovie.Add(movieToAdd);
            repoPerson.Add(personToAdd);
            repoPerson.AddMovieActor(movieToAdd, personToAdd.Name, "role");
            repoPerson.RemoveMovieActor(movieToAdd, personToAdd.Name);

            Assert.AreEqual(0, repoPerson.GetAllMoviesWorkedOn(repoPerson.GetByName(personToAdd.Name)).Count);
        }

        [TestMethod]
        public void RemoveMovieFromActorNotWorkedOn()
        {
            IPersonRepository repoPerson = new PersonDBRepository();
            Person personToAdd = new Person()
            {
                Name = "TestPerson",
                BirthDate = "1980/10/10",
            };
            Movie movieToAdd = new Movie()
            {
                Name = "MovieTest",
                Description = "DescriptionTest"
            };

            Assert.IsFalse(repoPerson.RemoveMovieActor(movieToAdd, personToAdd.Name));
        }
    }
}
