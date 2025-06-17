using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InMemory
{
    public class UserMemoryRepository : IUserRepository
    {
        private IList<User> _users;
        public UserMemoryRepository()
        {
            _users = new List<User>();
        }

        public User Add(User newUser)
        {
            _users.Add(newUser);
            return newUser;
        }


        public bool AddProfile(User user, Profile newProfile)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Mail == user.Mail)
                {
                    _users[i].ProfileList.Add(newProfile);
                    return true;
                }  
            }
            return false;
        }

        public bool Contains(User user)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Mail.Equals(user.Mail)) return true;
            }
            return false;
        }

        public bool DeleteProfile(User user, Profile profile)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Mail == user.Mail)
                {
                    _users[i].ProfileList.Remove(profile);
                    return true;
                }
            }
            return false;
        }

        public IList<User> GetAll()
        {
            return _users;
        }

        public User GetUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}
