using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IUserLogic
    {
        User AddUser(User newUser);
        bool AddProfile(User user, Profile newProfile);
        User CheckLogin(String usernameOrEmail, String password);
        bool DeleteProfile(User user, Profile profile);
        User GetUser(String email);
    }
}
