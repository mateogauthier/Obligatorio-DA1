using Dominio;
using Dominio.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class testGenre
    {
        [TestMethod]
        public void CreateGenreCorrectly()
        {
            Genre genre = new Genre()
            {
                Name = "Sci-Fi"
            };
            Assert.AreEqual(genre.Name, "Sci-Fi");
         }

        [TestMethod]
        [ExpectedException(typeof(GenreException))]
        public void CreateGenreIncorrectlyEmpty()
        {
            Genre genre = new Genre()
            {
                Name = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(GenreException))]
        public void CreateGenreIncorrectlyWhitepaces()
        {
            Genre genre = new Genre()
            {
                Name = " "
            };
        }

        [TestMethod]
        public void AddDescriptionCorrectly()
        {
            Genre genre = new Genre()
            {
                Name = "Sci-Fi",
                Description = "Fantasy genre set in the future"
            };
            Assert.AreEqual(genre.Description, "Fantasy genre set in the future");
        }
    }
}
