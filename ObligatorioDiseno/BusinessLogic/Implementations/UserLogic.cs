using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class UserLogic : IUserLogic
    {
        private IUserRepository _userRepository;
        private int profilesAmountLimit = 4;

        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool AddProfile(User user, Profile newProfile)
        {
            if (newProfile.IsOwner)
            {
                for (int i = 0; i < user.ProfileList.Count; i++)
                {
                    if (user.ProfileList[i].IsOwner) throw UserLogicException.ownerExistsError();
                }
            }

            if (user.ProfileList.Count >= profilesAmountLimit) throw UserLogicException.profileLimitError(profilesAmountLimit);
            return _userRepository.AddProfile(user,newProfile);
        }

        public User AddUser(User newUser)
        {
            if (!_userRepository.Contains(newUser))
            {
                _userRepository.Add(newUser);
            }
            else
            {
                throw UserLogicException.userExistsError();
            }
            return newUser;
        }

        public User CheckLogin(string usernameOrEmail, string password)
        {
            IList<User> userList = _userRepository.GetAll();
            for (int i = 0; i < userList.Count; i++)
            {
                if (usernameOrEmail.Equals(userList[i].Name) && password.Equals(userList[i].Password)) return userList[i];
                if (usernameOrEmail.Equals(userList[i].Mail) && password.Equals(userList[i].Password)) return userList[i];
                if (usernameOrEmail.Equals(userList[i].Mail) || usernameOrEmail.Equals(userList[i].Name)) throw UserLogicException.incorrectPasswordError();
            }

            throw UserLogicException.userNotFound();
        }

        public bool DeleteProfile(User user, Profile profile)
        {
            if (profile.IsOwner) throw UserLogicException.deleteOwnerError();
            return _userRepository.DeleteProfile(user,profile);
        }

        public User GetUser(string email)
        {
            return _userRepository.GetUser(email);
        }
    }
}
