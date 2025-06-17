using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;
using Dominio.Exceptions;

namespace UnitTest
{
    [TestClass]
    public class TestProfile
    {
        [TestMethod]
        public void CreateProfileCorrectly()
        {
            Profile profile = new Profile()
            {
                Nickname = "Jackie"
            };

            Assert.AreEqual("Jackie", profile.Nickname);
        }

        [TestMethod]
        [ExpectedException(typeof(ProfileException))]
        public void CreateProfileWrongNameLength()
        {
            Profile profile = new Profile()
            {
                Nickname = "SicParvisMagnaSicParvisMagna"
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ProfileException))]
        public void CreateProfileWrongNameLengthSecondCase()
        {
            Profile profile = new Profile()
            {
                Nickname = ""
            };
        }

        [TestMethod]
        public void AddPinCorrectly()
        {
            Profile profile = new Profile()
            {
                Nickname = "Jackie",
                Pin = 20901
            };

            Assert.AreEqual(20901, profile.Pin);
        }

        [TestMethod]
        [ExpectedException(typeof(ProfileException))]
        public void AddPinIncorrectly()
        {
            Profile profile = new Profile()
            {
                Nickname = "Jackie",
                Pin = 420
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ProfileException))]
        public void AddPinIncorrectlySecondCase()
        {
            Profile profile = new Profile()
            {
                Nickname = "Jackie",
                Pin = 420590
            };
        }

        [TestMethod]
        public void MakeChildProfileCorrectly()
        {
            Profile profile = new Profile()
            {
                Nickname = "Jackie",
                IsChild = true
            };

            Assert.IsTrue(profile.IsChild);
        }

        [TestMethod]
        public void MakeProfileOwnerCorrectly()
        {
            Profile profile = new Profile()
            {
                Nickname = "Jackie",
                IsOwner = true
            };

            Assert.IsTrue(profile.IsOwner);
        }
    }
}
