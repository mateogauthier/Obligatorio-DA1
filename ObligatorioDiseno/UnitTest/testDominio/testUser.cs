using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;
using System.Net.Mail;
using System.Security.Cryptography;
using Dominio.Exceptions;

namespace UnitTest
{
    [TestClass]
    public class testUser
    {
        [TestMethod]
        public void CreateUserCorrectly()
        {
            User user = new User()
            {
                Name = "Daigusto2000",
                Mail = "augusto@yahoo.com",
                Password = "sandvis6090"
            };

            Assert.AreEqual(user.Name, "Daigusto2000");
            Assert.AreEqual(user.Mail, "augusto@yahoo.com");
            Assert.AreEqual(user.Password, "sandvis6090");
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void CreateUserIncorrectNameLength()
        {
            User user = new User()
            {
                Name = "Daigusto",
                Mail = "augusto@yahoo.com",
                Password = "sandvis6090"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void CreateUserIncorrectNameLengthSecondCase()
        {
            User user = new User()
            {
                Name = "DaigustoFenomeno888999111",
                Mail = "augusto@yahoo.com",
                Password = "sandvis6090"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void CreateUserIncorrectPasswordLength()
        {
            User user = new User()
            {
                Name = "Daigusto2000",
                Mail = "augusto@yahoo.com",
                Password = "sandvis"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void CreateUserIncorrectPasswordLengthSecondCase()
        {
            User user = new User()
            {
                Name = "Daigusto2000",
                Mail = "augusto@yahoo.com",
                Password = "sandvissandvissandvissandvissandvissandvis"
            };

        }

        [TestMethod]
        public void CreateAdminUser()
        {
            User user = new User()
            {
                Name = "Daigusto2000",
                Mail = "augusto@yahoo.com",
                Password = "sandvis6090",
                IsAdmin = true
            };

            Assert.IsTrue(user.IsAdmin);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void CreateUserWithEmptyMail()
        {
            User user = new User()
            {
                Name = "Daigusto2000",
                Mail = "",
                Password = "sandvis6090"
            };

        }

        [TestMethod]
        public void AddProfileCorrectly()
        {
            User user = new User();

            Profile profile = new Profile()
            {
                Nickname = "July",
            };

            user.ProfileList.Add(profile);

            Assert.AreEqual(user.ProfileList[0].Nickname,"July");
        }

    }
}
