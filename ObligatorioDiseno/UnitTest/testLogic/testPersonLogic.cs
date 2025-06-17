using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.InDB;
using Repository.Interfaces;
using System;

namespace UnitTest.testLogic
{
    [TestClass]
    public class testPersonLogic
    {
        [TestCleanup]
        public void Clean()
        {
            using (var context = new SystemDbContext())
            {
                var persons = context.Persons;
                foreach (var cat in persons)
                {
                    context.Persons.Remove(cat);
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
        }

        [TestMethod]
        public void AddPerson()
        {
            IPersonRepository personRepository = new PersonDBRepository();
            IPersonLogic logic = new PersonLogic(personRepository);
            Person newPerson = new Person() { Name = "TestPerson", BirthDate = "1992/11/11"};
            logic.AddPerson(newPerson);

            Assert.AreEqual(1, logic.GetAll().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonLogicException))]
        public void AddPersonThatAlreadyExists()
        {
            IPersonRepository personRepository = new PersonDBRepository();
            IPersonLogic logic = new PersonLogic(personRepository);
            Person newPerson = new Person() { Name = "TestPerson", BirthDate = "1992/11/11" };
            logic.AddPerson(newPerson);
            logic.AddPerson(newPerson);
        }

        [TestMethod]
        public void UpdatePerson()
        {
            IPersonRepository personRepository = new PersonDBRepository();
            IPersonLogic logic = new PersonLogic(personRepository);
            Person newPerson = new Person() { Name = "TestPerson", BirthDate = "1992/11/11" };
            Person updatedPerson = new Person() { Name = "TestPersonUpdated", BirthDate = "1992/11/10" };
            logic.AddPerson(newPerson);
            logic.UpdatePerson(newPerson, updatedPerson);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonLogicException))]
        public void UpdatePersonThatDoesNotExist()
        {
            IPersonRepository personRepository = new PersonDBRepository();
            IPersonLogic logic = new PersonLogic(personRepository);
            Person newPerson = new Person() { Name = "TestPerson", BirthDate = "1992/11/11" };
            Person updatedPerson = new Person() { Name = "TestPersonUpdated", BirthDate = "1992/11/10" };
            logic.UpdatePerson(newPerson, updatedPerson);
        }

        [TestMethod]
        public void DeletePerson()
        {
            IPersonRepository personRepository = new PersonDBRepository();
            IPersonLogic logic = new PersonLogic(personRepository);
            Person newPerson = new Person() { Name = "TestPerson", BirthDate = "1992/11/11" };
            logic.AddPerson(newPerson);
            logic.RemovePerson(newPerson);

            Assert.AreEqual(0, logic.GetAll().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonLogicException))]
        public void DeletePersonThatDoesNotExist()
        {
            IPersonRepository personRepository = new PersonDBRepository();
            IPersonLogic logic = new PersonLogic(personRepository);
            Person newPerson = new Person() { Name = "TestPerson", BirthDate = "1992/11/11" };
            logic.RemovePerson(newPerson);
        }

        [TestMethod]
        public void SearchPersonByString()
        {
            IPersonRepository personRepository = new PersonDBRepository();
            IPersonLogic logic = new PersonLogic(personRepository);
            Person newPerson = new Person() { Name = "TestPerson", BirthDate = "1992/11/11" };
            Person newPerson2 = new Person() { Name = "abcdefgPerson", BirthDate = "1992/11/11" };
            Person newPerson3 = new Person() { Name = "wxyzPerson", BirthDate = "1992/11/11" };
            logic.AddPerson(newPerson);
            logic.AddPerson(newPerson2);
            logic.AddPerson(newPerson3);
            Assert.AreEqual(3,logic.SearchByName("Person").Count);
        }
    }
}
