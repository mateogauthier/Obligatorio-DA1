using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;
using BusinessLogic.Interfaces;
using BusinessLogic.Implementations;
using Dominio.Exceptions;
using Repository.Interfaces;
using Repository.InMemory;
using BusinessLogic.Exceptions;
using Repository.InDB;

namespace UnitTest.testLogic
{
    [TestClass]
    public class testUserLogic
    {
        [TestCleanup]
        public void Clean()
        {
            using (var context = new SystemDbContext())
            {
                var profiles = context.Profiles;
                foreach (var cat in profiles)
                {
                    context.Profiles.Remove(cat);
                }
                context.SaveChanges();
            }
            using (var context = new SystemDbContext())
            {
                var users = context.Users;
                foreach (var cat in users)
                {
                    context.Users.Remove(cat);
                }
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void AddUserCorrectly()
        {
            IUserRepository userRepository = new UserDBRepository();
            string mail = "asdfgh@asdfgh.com";
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = mail };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);

            Assert.AreEqual(user.Name, logic.GetUser(mail).Name);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AddUserIncorrectlyWrongNameLength()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AddUserIncorrectlyWrongPasswordLength()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "123", Mail = "asdfgh@asdfgh.com" };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
        }

        [TestMethod]
        [ExpectedException(typeof(UserLogicException))]
        public void AddUserIncorrectlyAlreadyExists()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            User repeatedUser = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            logic.AddUser(repeatedUser);
        }

        [TestMethod]
        public void LogInUsingEmailCorrectly()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            Assert.AreEqual(logic.CheckLogin("asdfgh@asdfgh.com", "1234567891").Mail,user.Mail);
        }

        [TestMethod]
        public void LogInUsingNameCorrectly()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            Assert.AreEqual(logic.CheckLogin("Jorge289010", "1234567891").Mail,user.Mail);
        }

        [TestMethod]
        [ExpectedException(typeof(UserLogicException))]
        public void LogInIncorrectly()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            logic.CheckLogin("error@error.com", "1234567891");
        }

        [TestMethod]
        public void AddProfileToUserCorrectly()
        {
            IUserRepository userRepository = new UserDBRepository();
            string mail = "asdfgh@asdfgh.com";
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = mail };
            Profile profile = new Profile() { Nickname="Jorgi", Pin = 20391, IsOwner = true};
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            logic.AddProfile(user, profile);

            Assert.AreEqual(profile.Nickname, logic.GetUser(mail).ProfileList[0].Nickname);
        }

        [TestMethod]
        [ExpectedException(typeof(UserLogicException))]
        public void AddProfileToUserInCorrectlyTooManyProfiles()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            Profile profile = new Profile() { Nickname = "Jorgi", Pin = 10391, IsOwner = true };
            Profile profile2 = new Profile() { Nickname = "Jorgi2", Pin = 20491, IsOwner = false };
            Profile profile3 = new Profile() { Nickname = "Jorgi3", Pin = 30491, IsOwner = false };
            Profile profile4 = new Profile() { Nickname = "Jorgi4", Pin = 40491, IsOwner = false };
            Profile profile5 = new Profile() { Nickname = "Jorgi5", Pin = 50491, IsOwner = false };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            logic.AddProfile(user, profile);
            user = logic.GetUser(user.Mail);
            logic.AddProfile(user, profile2);
            user = logic.GetUser(user.Mail);
            logic.AddProfile(user, profile3);
            user = logic.GetUser(user.Mail);
            logic.AddProfile(user, profile4);
            user = logic.GetUser(user.Mail);
            logic.AddProfile(user, profile5);
        }

        [TestMethod]
        [ExpectedException(typeof(UserLogicException))]
        public void TryToCreateSecondOwnerProfile()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            Profile profile = new Profile() { Nickname = "Jorgi", Pin = 20391, IsOwner =true};
            Profile profile2 = new Profile() { Nickname = "Jorgi2", Pin = 20361, IsOwner = true };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            logic.AddProfile(user,profile);
            user = logic.GetUser(user.Mail);
            logic.AddProfile(user,profile2);
        }

        [TestMethod]
        public void DeleteProfileFromUserCorrectly()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            Profile profile = new Profile() { Nickname = "Jorgi", Pin= 20192};
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            logic.AddProfile(user, profile);
            logic.DeleteProfile(user, profile);
            user = logic.GetUser(user.Mail);
            Assert.AreEqual(0, user.ProfileList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(UserLogicException))]
        public void DeleteOwnerProfileFromUser()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            Profile profile = new Profile() { Nickname = "Jorgi" ,Pin= 23412, IsOwner =true};
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            logic.AddProfile(user, profile);
            logic.DeleteProfile(user, profile);
        }

        [TestMethod]
        public void GetUserByEmail()
        {
            IUserRepository userRepository = new UserDBRepository();
            User user = new User() { Name = "Jorge289010", Password = "1234567891", Mail = "asdfgh@asdfgh.com" };
            IUserLogic logic = new UserLogic(userRepository);
            logic.AddUser(user);
            Assert.AreEqual(user.Mail, logic.GetUser(user.Mail).Mail);
        }
    }
}
