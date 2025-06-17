using BusinessLogic.Exceptions;
using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Dominio;
using Dominio.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.InDB;
using Repository.InMemory;
using Repository.Interfaces;
using System;

namespace UnitTest.testLogic
{
    [TestClass]
    public class testViewLogic
    {
        [TestCleanup]
        public void Clean()
        {
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
        public void RegisterViewCorrectly()
        {
            IViewRepository viewRepository = new ViewDBRepository();
            View view = new View() { MovieName = "Dune", ProfileName = "dario12345", UserEmail = "dario@fifo.com", Rating = 2};
            IViewLogic logic = new ViewLogic(viewRepository);
            logic.RegisterView(view);

            Assert.AreEqual(view.Id, logic.GetAllFromProfile("dario@fifo.com", "dario12345")[0].Id);
        }

        [TestMethod]
        public void ObtainAllViewsFromProfileCorrectly()
        {
            IViewRepository viewRepository = new ViewDBRepository();
            View view = new View() { MovieName = "Dune", ProfileName = "dario12345", UserEmail = "dario@fifo.co", Rating = 2 };
            View view2 = new View() { MovieName = "Dune", ProfileName = "marie23423", UserEmail = "marie@fifo.co", Rating = 1 };
            IViewLogic logic = new ViewLogic(viewRepository);
            logic.RegisterView(view);
            logic.RegisterView(view2);

            Assert.AreEqual(1, logic.GetAllFromProfile("dario@fifo.co", "dario12345").Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ViewLogicException))]
        public void RegisterAlreadyExistingView()
        {
            IViewRepository viewRepository = new ViewDBRepository();
            View view = new View() { MovieName = "Dune", ProfileName = "dario12345", UserEmail = "dario@fifo.co", Rating = 2 };
            View view2 = new View() { MovieName = "Dune", ProfileName = "dario12345", UserEmail = "dario@fifo.co", Rating = 1 };
            IViewLogic logic = new ViewLogic(viewRepository);
            logic.RegisterView(view);
            logic.RegisterView(view2);
        }
    }
}
