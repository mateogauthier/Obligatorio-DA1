using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;
using Dominio.Exceptions;

namespace UnitTest
{
    [TestClass]
    public class testView
    {
        [TestMethod]
        public void RegisterViewCorrectly()
        {
            View view = new View()
            {
                UserEmail = "damian@orbe.com",
                ProfileName = "damon",
                MovieName = "Pulp Fiction",
                Rating = 2

            };

            Assert.AreEqual(view.UserEmail, "damian@orbe.com");
            Assert.AreEqual(view.ProfileName, "damon");
            Assert.AreEqual(view.MovieName, "Pulp Fiction");
            Assert.AreEqual(view.Rating, 2);

        }

    }
}
