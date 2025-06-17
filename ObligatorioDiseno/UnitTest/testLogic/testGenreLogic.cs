using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.InMemory;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Repository.InDB;

namespace UnitTest.testLogic
{
    [TestClass]
    public class TestGenreLogic
    {
        [TestCleanup]
        public void Clean()
        {
            using (var context = new SystemDbContext())
            {
                var genres = context.Genres;
                foreach (var cat in genres)
                {
                    context.Genres.Remove(cat);
                }
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void AddGenreCorrectly()
        {
            IGenreRepository genreRepository = new GenreDBRepository();
            Genre genre = new Genre() { Name = "Horror", Description = "ExampleDescription" };
            IGenreLogic logic = new GenreLogic(genreRepository);
            logic.AddGenre(genre);

            Assert.AreEqual(genre.Name, logic.GetAll()[0].Name);
        }

        [TestMethod]
        [ExpectedException(typeof(GenreLogicException))]
        public void AddGenreThatAlreadyExists()
        {
            IGenreRepository genreRepository = new GenreDBRepository();
            Genre genre = new Genre() { Name = "Horror", Description = "ExampleDescription" };
            Genre genre2 = new Genre() { Name = "Horror", Description = "ExampleDescription2" };
            IGenreLogic logic = new GenreLogic(genreRepository);
            logic.AddGenre(genre);
            logic.AddGenre(genre2);
        }

        [TestMethod]
        public void RemoveGenreCorrectly()
        {
            IGenreRepository genreRepository = new GenreDBRepository();
            Genre genre = new Genre() { Name = "Horror", Description = "ExampleDescription" };
            IGenreLogic logic = new GenreLogic(genreRepository);
            logic.AddGenre(genre);
            logic.RemoveGenre(genre);

            CollectionAssert.AreEqual(new List<Genre>(), logic.GetAll().ToList());
        }

        [TestMethod]
        [ExpectedException(typeof(GenreLogicException))]
        public void RemoveGenreLinkedToMovie()
        {
            IMovieRepository movieRepository = new MovieMemoryRepository();
            IMovieLogic movieLogic = new MovieLogic(movieRepository);
            IGenreRepository genreRepository = new GenreDBRepository();
            IGenreLogic genreLogic = new GenreLogic(genreRepository, movieLogic);

            Genre genre = new Genre() { Name = "Horror", Description = "ExampleDescription" };
            genreLogic.AddGenre(genre);

            Movie movie = new Movie() { Name = "Frankenstein", Genre = genre };
            movieLogic.AddMovie(movie);

            genreLogic.RemoveGenre(genre);
        }

        [TestMethod]
        [ExpectedException(typeof(GenreLogicException))]
        public void RemoveGenreThatDoesntExist()
        {
            IGenreRepository genreRepository = new GenreDBRepository();
            Genre genre = new Genre() { Name = "Horror", Description = "ExampleDescription" };
            IGenreLogic logic = new GenreLogic(genreRepository);
            logic.RemoveGenre(genre);
        }

        [TestMethod]
        public void GetAllGenresCorrectly()
        {
            IGenreRepository genreRepository = new GenreDBRepository();
            Genre genre = new Genre() { Name = "Horror", Description = "ExampleDescription" };
            Genre genre2 = new Genre() { Name = "Fantasy", Description = "ExampleDescription" };
            IGenreLogic logic = new GenreLogic(genreRepository);
            logic.AddGenre(genre);
            logic.AddGenre(genre2);
            Assert.AreEqual(2, logic.GetAll().Count);
        }

        [TestMethod]
        public void GetGenreByNameCorrectly()
        {
            IGenreRepository genreRepository = new GenreDBRepository();
            Genre genre = new Genre() { Name = "Horror", Description = "ExampleDescription" };
            IGenreLogic logic = new GenreLogic(genreRepository);
            logic.AddGenre(genre);
            Assert.AreEqual("Horror", logic.GetByName("Horror").Name);
        }
    }
}
