using Dominio;
using Dominio.Classes;
using Dominio.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.InDB;
using Repository.Interfaces;
using System;

namespace UnitTest.testDominio
{
    [TestClass]
    public class testPerson
    {
        [TestMethod]
        public void CreatePerson()
        {
            Person newPerson = new Person() { Name = "TestDirector",
                                              BirthDate = "1995/12/01",
                                              Picture = "./testPoster"};
            Assert.AreEqual("TestDirector", newPerson.Name);
            Assert.AreEqual("1995/12/01", newPerson.BirthDate);
            Assert.AreEqual("./testPoster", newPerson.Picture);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonException))]
        public void CreatePersonEmptyName()
        {
            Person newPerson = new Person()
            {
                Name = "",
                BirthDate = "1995/12/01",
                Picture = "./testPoster"
            };
        }

        [TestMethod]
        [ExpectedException(typeof(PersonException))]
        public void CreatePersonNoBirthday()
        {
            Person newPerson = new Person()
            {
                Name = "TestPerson",
                BirthDate = "",
                Picture = "./testPoster"
            };
        }

        [TestMethod]
        public void AddMovieToActor()
        {
            Person newPerson = new Person()
            {
                Name = "TestActor",
                BirthDate = "1995/12/01",
                Picture = "./testPoster"
            };
            Movie newMovie = new Movie() { Name = "TestMovie", Description = "Test Description" };
            newPerson.AddActed(newMovie);

            Assert.AreEqual(1, newPerson.MoviesActed.Count);
        }

        [TestMethod]
        public void AddMovieToDirector()
        {
            Person newPerson = new Person()
            {
                Name = "TestActor",
                BirthDate = "1995/12/01",
                Picture = "./testPoster"
            };
            Movie newMovie = new Movie() { Name = "TestMovie", Description = "Test Description" };
            newPerson.AddDirected(newMovie);

            Assert.AreEqual(1, newPerson.MoviesDirected.Count);
        }

        [TestMethod]
        public void RemoveMovieFromActor()
        {
            Person newPerson = new Person()
            {
                Name = "TestActor",
                BirthDate = "1995/12/01",
                Picture = "./testPoster"
            };
            Movie newMovie = new Movie() { Name = "TestMovie", Description = "Test Description" };
            newPerson.AddActed(newMovie);
            newPerson.RemoveActed(newMovie);

            Assert.AreEqual(0, newPerson.MoviesActed.Count);
        }

        [TestMethod]
        public void RemoveMovieFromDirector()
        {
            Person newPerson = new Person()
            {
                Name = "TestActor",
                BirthDate = "1995/12/01",
                Picture = "./testPoster"
            };
            Movie newMovie = new Movie() { Name = "TestMovie", Description = "Test Description" };
            newPerson.AddDirected(newMovie);
            newPerson.RemoveDirected(newMovie);

            Assert.AreEqual(0, newPerson.MoviesDirected.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonException))]
        public void RemoveMovieFromActorNotActed()
        {
            Person newPerson = new Person()
            {
                Name = "TestActor",
                BirthDate = "1995/12/01",
                Picture = "./testPoster"
            };
            Movie newMovie = new Movie() { Name = "TestMovie", Description = "Test Description" };
            newPerson.RemoveActed(newMovie);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonException))]
        public void RemoveMovieFromDirectorNotDirected()
        {
            Person newPerson = new Person()
            {
                Name = "TestActor",
                BirthDate = "1995/12/01",
                Picture = "./testPoster"
            };
            Movie newMovie = new Movie() { Name = "TestMovie", Description = "Test Description" };
            newPerson.RemoveDirected(newMovie);
        }
    }
}
