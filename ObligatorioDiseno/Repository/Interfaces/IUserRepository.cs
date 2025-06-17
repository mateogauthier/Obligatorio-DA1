using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IUserRepository
    {
        User Add(User newUser);
        bool AddProfile(User user,Profile newProfile);
        bool Contains(User user);
        IList<User> GetAll();
        bool DeleteProfile(User user, Profile profile);
        User GetUser (String email);
    }
}
