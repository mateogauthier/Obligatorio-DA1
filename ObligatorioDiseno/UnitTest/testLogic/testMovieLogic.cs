using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Classes;
using Dominio.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.InDB;
using Repository.InMemory;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.testLogic
{
    [TestClass]
    public class TestMovieLogic
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
        public void AddMovieCorrectly()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre };

            IMovieLogic logic = new MovieLogic(movieRepository);
            logic.AddMovie(movie);

            Assert.AreEqual(movie.Name,logic.GetAllMovies().First().Name);
        }

        [TestMethod]
        [ExpectedException(typeof(MovieLogicException))]
        public void AddAlreadyExistingMovie()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre };

            IMovieLogic logic = new MovieLogic(movieRepository);
            logic.AddMovie(movie);
            logic.AddMovie(movie);
        }

        [TestMethod]
        public void DeleteMovieCorrectly()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre };

            IMovieLogic logic = new MovieLogic(movieRepository);
            logic.AddMovie(movie);
            logic.DeleteMovie(movie);

            Assert.IsFalse(logic.Contains(movie));
        }

        [TestMethod]
        [ExpectedException(typeof(MovieLogicException))]
        public void DeleteThatDoesntExist()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre };

            IMovieLogic logic = new MovieLogic(movieRepository);
            logic.DeleteMovie(movie);
        }

        [TestMethod]
        public void GetAllMoviesCorrectly()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre };

            IMovieLogic logic = new MovieLogic(movieRepository);
            logic.AddMovie(movie);
            IList<Movie> allMovies = logic.GetAllMovies();

            Assert.AreEqual(1, allMovies.Count);
        }

        [TestMethod]
        public void MoviesLinkedToGenre()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre };

            IMovieLogic logic = new MovieLogic(movieRepository);
            logic.AddMovie(movie);
            bool linked = logic.MoviesLinkedToGenre(genre);

            Assert.AreEqual(true, linked);

            logic.DeleteMovie(movie);
            linked = logic.MoviesLinkedToGenre(genre);

            Assert.AreEqual(false, linked);
        }

        [TestMethod]
        public void GetAllMoviesSortedByGenreCorrectly()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre };
            Genre genre2 = new Genre() { Name = "Fantasy" };
            Movie movie2 = new Movie() { Name = "LordOfTheRings", Genre = genre2 };
            Genre genre3 = new Genre() { Name = "Zoo" };
            Movie movie3 = new Movie() { Name = "AnimalPlanet", Genre = genre3 };

            IMovieLogic logic = new MovieLogic(movieRepository);
            logic.AddMovie(movie);
            logic.AddMovie(movie2);
            logic.AddMovie(movie3);
            IList<Movie> allMovies = logic.GetAllMoviesSortedByGenre();

            Assert.AreEqual("LordOfTheRings", allMovies[0].Name);
        }

        [TestMethod]
        public void GetAllMoviesSortedBySponsoredCorrectly()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre, IsSponsored = true };
            Genre genre2 = new Genre() { Name = "Fantasy" };
            Movie movie2 = new Movie() { Name = "LordOfTheRings", Genre = genre2, IsSponsored = false };
            Genre genre3 = new Genre() { Name = "Zoo" };
            Movie movie3 = new Movie() { Name = "AnimalPlanet", Genre = genre3, IsSponsored = true };

            IMovieLogic logic = new MovieLogic(movieRepository);
            logic.AddMovie(movie);
            logic.AddMovie(movie2);
            logic.AddMovie(movie3);
            IList<Movie> allMovies = logic.GetAllMoviesSortedBySponsored();

            Assert.AreEqual("Dune", allMovies[0].Name);
            Assert.AreEqual("AnimalPlanet", allMovies[1].Name);
            Assert.AreEqual("LordOfTheRings", allMovies[2].Name);
        }

        [TestMethod]
        public void GetAllMoviesSortedByScoreCorrectly()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            IViewRepository viewRepository = new ViewMemoryRepository();
            Genre genre = new Genre() { Name = "SpaceOpera" };
            Movie movie = new Movie() { Name = "Dune", Genre = genre, IsSponsored = true };
            Genre genre2 = new Genre() { Name = "Fantasy" };
            Movie movie2 = new Movie() { Name = "LordOfTheRings", Genre = genre2, IsSponsored = false };
            Genre genre3 = new Genre() { Name = "Zoo" };
            Movie movie3 = new Movie() { Name = "AnimalPlanet", Genre = genre3, IsSponsored = true };

            IViewLogic viewLogic = new ViewLogic(viewRepository);
            IMovieLogic logic = new MovieLogic(movieRepository, viewLogic);
            logic.AddMovie(movie);
            logic.AddMovie(movie2);
            logic.AddMovie(movie3);

            View view = new View() {
                MovieName="Dune",
                UserEmail="albert@albert.com",
                ProfileName="albert",
                Rating=2};
            viewLogic.RegisterView(view);

            View view2 = new View()
            {
                MovieName = "LordOfTheRings",
                UserEmail = "albert@albert.com",
                ProfileName = "albert",
                Rating = 1
            };
            viewLogic.RegisterView(view2);

            IList<Movie> allMovies = logic.GetAllMoviesSortedByScore("albert@albert.com", "albert");

            Assert.AreEqual("Dune", allMovies[0].Name);
            Assert.AreEqual("AnimalPlanet", allMovies[2].Name);
            Assert.AreEqual("LordOfTheRings", allMovies[1].Name);
        }

        [TestMethod]
        public void GetActorsFromMovie()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            IPersonRepository personRepository = new PersonDBRepository();
            IViewRepository viewRepository = new ViewDBRepository();

            Movie movie = new Movie() { Name = "Dune", Genre = new Genre() { Name = "test"} };
            Person person = new Person() { Name = "TestPerson",BirthDate = "1988/11/11" };

            IPersonLogic logicP = new PersonLogic(personRepository);
            IViewLogic logicV = new ViewLogic(viewRepository);
            IMovieLogic logicM = new MovieLogic(movieRepository,logicV,logicP);

            logicM.AddMovie(movie);
            logicP.AddPerson(person);
            logicP.LinkMovieActor(person.Name, movie, "role");
            movie = logicM.GetAllMovies().FirstOrDefault(x=>x.Name.Equals(movie.Name));

            Assert.AreEqual(1, logicM.GetActors(movie).Count);
        }

        [TestMethod]
        public void GetMoviesSeenByAProfile()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            IPersonRepository personRepository = new PersonDBRepository();
            IViewRepository viewRepository = new ViewDBRepository();

            Movie movie = new Movie() { Name = "Dune", Genre = new Genre() { Name = "test" } };
            View view = new View() { MovieName = "Dune", UserEmail = "test@test.com", ProfileName = "test", Rating = 2 };

            IPersonLogic logicP = new PersonLogic(personRepository);
            IViewLogic logicV = new ViewLogic(viewRepository);
            IMovieLogic logicM = new MovieLogic(movieRepository, logicV, logicP);

            logicM.AddMovie(movie);
            logicV.RegisterView(view);

            Assert.AreEqual(1, logicM.GetSeenByProfile("test@test.com", "test").Count);
        }

        [TestMethod]
        public void GetDirectorsFromMovie()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            IPersonRepository personRepository = new PersonDBRepository();
            IViewRepository viewRepository = new ViewDBRepository();

            Movie movie = new Movie() { Name = "Dune", Genre = new Genre() { Name = "test" } };
            Person person = new Person() { Name = "TestPerson", BirthDate = "1988/11/11" };

            IPersonLogic logicP = new PersonLogic(personRepository);
            IViewLogic logicV = new ViewLogic(viewRepository);
            IMovieLogic logicM = new MovieLogic(movieRepository, logicV, logicP);

            logicM.AddMovie(movie);
            logicP.AddPerson(person);
            logicP.LinkMovieDirector(person, movie);
            movie = logicM.GetAllMovies().FirstOrDefault(x => x.Name.Equals(movie.Name));

            Assert.AreEqual(1, logicM.GetDirectors(movie).Count);
        }

        [TestMethod]
        public void GetMoviesByActorsSortedByAlphabet()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            IPersonRepository personRepository = new PersonDBRepository();
            IViewRepository viewRepository = new ViewDBRepository();

            IPersonLogic logicP = new PersonLogic(personRepository);
            IViewLogic logicV = new ViewLogic(viewRepository);
            IMovieLogic logicM = new MovieLogic(movieRepository, logicV, logicP);

            Movie movie = new Movie() { Name = "Dune", Genre = new Genre() { Name = "test" } };
            Movie movie2 = new Movie() { Name = "Zen", Genre = new Genre() { Name = "test" } };
            Person person = new Person() { Name = "TestActor", BirthDate = "1988/11/11" };
            

            logicM.AddMovie(movie);
            logicM.AddMovie(movie2);
            logicP.AddPerson(person);
            logicP.LinkMovieActor(person.Name, movie, "role");
            logicP.LinkMovieActor(person.Name, movie2, "role2");

            person = personRepository.GetAll().FirstOrDefault(x=>x.Name.Equals(person.Name));
            List<Person> actors = new List<Person>() { person };

            IList<Movie> m = logicM.GetMoviesByActorsAlphabeticalOrder(actors);
            Assert.AreEqual(2, m.Count);
        }

        [TestMethod]
        public void GetMoviesByActorsSortedByChronological()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            IPersonRepository personRepository = new PersonDBRepository();
            IViewRepository viewRepository = new ViewDBRepository();

            IPersonLogic logicP = new PersonLogic(personRepository);
            IViewLogic logicV = new ViewLogic(viewRepository);
            IMovieLogic logicM = new MovieLogic(movieRepository, logicV, logicP);

            Movie movie = new Movie() { Name = "Dune" , ReleaseYear = 1999, Genre = new Genre() { Name = "test" } };
            Movie movie2 = new Movie() { Name = "Zen" , ReleaseYear = 2002, Genre = new Genre() { Name = "test" } };
            Person person = new Person() { Name = "TestActor", BirthDate = "1988/11/11" };

            logicM.AddMovie(movie);
            logicM.AddMovie(movie2);
            logicP.AddPerson(person);
            logicP.LinkMovieActor(person.Name, movie, "role");
            logicP.LinkMovieActor(person.Name, movie2, "role2");
            person = personRepository.GetAll().FirstOrDefault(x => x.Name.Equals(person.Name));
            List<Person> actors = new List<Person>() { person };

            IList<Movie> m = logicM.GetMoviesByActorsChronologicalOrder(actors);
            Assert.AreEqual(2, m.Count);
        }

        [TestMethod]
        public void GetMoviesByDirectorsSortedByABC()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            IPersonRepository personRepository = new PersonDBRepository();
            IViewRepository viewRepository = new ViewDBRepository();

            IPersonLogic logicP = new PersonLogic(personRepository);
            IViewLogic logicV = new ViewLogic(viewRepository);
            IMovieLogic logicM = new MovieLogic(movieRepository, logicV, logicP);

            Movie movie = new Movie() { Name = "Dune", Genre = new Genre() { Name = "test" } };
            Movie movie2 = new Movie() { Name = "Zen", Genre = new Genre() { Name = "test" } };
            Person person = new Person() { Name = "TestActor", BirthDate = "1988/11/11" };

            logicM.AddMovie(movie);
            logicM.AddMovie(movie2);
            logicP.AddPerson(person);
            logicP.LinkMovieDirector(person, movie);
            logicP.LinkMovieDirector(person, movie2);

            person = personRepository.GetAll().FirstOrDefault(x => x.Name.Equals(person.Name));
            List<Person> directors = new List<Person>() { person };

            IList<Movie> m = logicM.GetMoviesByDirectorsAlphabeticalOrder(directors).ToList();
            Assert.AreEqual(2, m.Count);
        }

        [TestMethod]
        public void GetMoviesByDirectorsSortedByChronological()
        {
            IMovieRepository movieRepository = new MovieDBRepository();
            IPersonRepository personRepository = new PersonDBRepository();
            IViewRepository viewRepository = new ViewDBRepository();

            IPersonLogic logicP = new PersonLogic(personRepository);
            IViewLogic logicV = new ViewLogic(viewRepository);
            IMovieLogic logicM = new MovieLogic(movieRepository, logicV, logicP);

            Movie movie = new Movie() { Name = "Dune", ReleaseYear = 1999, Genre = new Genre() { Name = "test" } };
            Movie movie2 = new Movie() { Name = "Zen", ReleaseYear = 2002, Genre = new Genre() { Name = "test" } };
            Person person = new Person() { Name = "TestActor", BirthDate = "1988/11/11" };

            logicM.AddMovie(movie);
            logicM.AddMovie(movie2);
            logicP.AddPerson(person);
            logicP.LinkMovieDirector(person, movie);
            logicP.LinkMovieDirector(person, movie2);
            person = personRepository.GetAll().FirstOrDefault(x => x.Name.Equals(person.Name));
            List<Person> directors = new List<Person>() { person };

            IList<Movie> m = logicM.GetMoviesByDirectorsChronologicalOrder(directors);
            Assert.AreEqual(2, m.Count);
        }
    }
}
