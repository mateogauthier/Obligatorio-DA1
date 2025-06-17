using Dominio;
using Dominio.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class testMovies
    {
        [TestMethod]
        public void CreateMovieCorrectly()
        {
            Genre genre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = genre
            };

            Assert.AreEqual("Bladerunner", movie.Name);
            Assert.AreEqual("Cyberpunk", movie.Genre.Name);  
        }

        [TestMethod]
        [ExpectedException(typeof(MovieException))]
        public void CreateMovieIncorrectlyEmptyName()
        {
            Genre genre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "",
                Genre = genre
            };
        }

        [TestMethod]
        [ExpectedException(typeof(MovieException))]
        public void CreateMovieIncorrectlyWhitespacesName()
        {
            Genre genre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = " ",
                Genre = genre
            };
        }

        [TestMethod]
        [ExpectedException(typeof(MovieException))]
        public void CreateMovieIncorrectlyNoGenre()
        {
            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(MovieException))]
        public void CreateMovieIncorrectlyNoName()
        {
            Genre genre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = null,
                Genre = genre
            };
        }

        [TestMethod]
        public void AddSecondaryGenreCorrectly()
        {
            Genre mainGenre = new Genre()
            {
                Name = "Action"
            };

            Genre secondaryGenre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = mainGenre
            };

            movie.SecondaryGenreListAdd(secondaryGenre);

            Assert.AreEqual(movie.SecondaryGenreList[0].Name, "Cyberpunk");
        }

        [TestMethod]
        [ExpectedException(typeof(MovieException))]
        public void AddSecondaryGenreIncorrectly()
        {
            Genre mainAndSecondaryGenre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = mainAndSecondaryGenre
            };

            movie.SecondaryGenreListAdd(mainAndSecondaryGenre);
        }

        [TestMethod]
        [ExpectedException(typeof(MovieException))]
        public void ChangeMainGenreIncorrectly()
        {
            Genre mainGenre = new Genre()
            {
                Name = "Action"
            };

            Genre secondaryGenre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = mainGenre
            };
            movie.SecondaryGenreListAdd(secondaryGenre);

            movie.Genre = secondaryGenre;
        }

        [TestMethod]
        public void SecondaryGenreListNotModificable ()
        {
            Genre mainAndSecondaryGenre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = mainAndSecondaryGenre
            };

            List<Genre> list = movie.SecondaryGenreList;
            movie.SecondaryGenreList.Add(mainAndSecondaryGenre);

            CollectionAssert.AreEqual(list, movie.SecondaryGenreList);
        }

        [TestMethod]
        public void AddPosterCorrectly()
        {
            Genre genre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = genre,
                Poster = "BladerunnerPoster.jpg"
            };

            Assert.AreEqual(movie.Poster, "BladerunnerPoster.jpg");
        }

        [TestMethod]
        public void MakeSponsoredCorrectly()
        {
            Genre genre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = genre,
                IsSponsored = true
            };

            Assert.IsTrue(movie.IsSponsored);
        }

        [TestMethod]
        public void MakeRatedForGeneralAudiencesCorrectly()
        {
            Genre genre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = genre,
                IsRatedForGA = true
            };

            Assert.IsTrue(movie.IsRatedForGA);
        }

        [TestMethod]
        public void AddDescriptionCorrectly()
        {
            Genre genre = new Genre()
            {
                Name = "Cyberpunk"
            };

            Movie movie = new Movie()
            {
                Name = "Bladerunner",
                Genre = genre,
                Description = "1982 science fiction film"
            };

            Assert.AreEqual(movie.Description, "1982 science fiction film");
        }
    }
}
