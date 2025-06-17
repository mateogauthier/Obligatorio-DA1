using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InDB
{
    public class UserDBRepository : IUserRepository
    {
        public User Add(User newUser)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                SysContext.Users.Add(newUser);
                SysContext.SaveChanges();
            }
            return newUser;
        }


        public bool AddProfile(User user, Profile newProfile)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                User userToMod = SysContext.Users.Include("ProfileList").FirstOrDefault(x => x.Mail == user.Mail);
                userToMod.ProfileList.Add(newProfile);
                SysContext.SaveChanges();
            }
            return true;
        }

        public bool Contains(User user)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                User userToMod = SysContext.Users.FirstOrDefault(x => x.Mail == user.Mail);
                if(userToMod!=null) return true;
                return false;
            }
            
        }

        public bool DeleteProfile(User user, Profile profile)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                User userToMod = SysContext.Users.Include("ProfileList").FirstOrDefault(x => x.Id == user.Id);
                for (int i = 0; i < userToMod.ProfileList.Count; i++)
                {
                    if (userToMod.ProfileList[i].Nickname.Equals(profile.Nickname))
                    {
                        SysContext.Profiles.Remove(userToMod.ProfileList[i]);
                        //userToMod.ProfileList.RemoveAt(i);
                        SysContext.SaveChanges();
                        return true;
                    }
                }
            }
            return false;
        }

        public IList<User> GetAll()
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                return SysContext.Users.Include("ProfileList").ToList();
            }
            
        }

        public User GetUser(string email)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                return SysContext.Users.Include("ProfileList").FirstOrDefault(x => x.Mail == email);
            }
        }
    }
}
