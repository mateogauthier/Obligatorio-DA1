using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class User
    {
        public int Id { get; set; }

        private string _name;
        public string Name { get => _name ; set {
                if (value.Length < 10 || value.Length > 20)
                {
                    throw UserException.lengthNameError();
                }
                _name = value;
            }
        }

        private string _email;
        public string Mail
        {
            get => _email;
            set {
                if (value.Length < 1)
                {
                    throw UserException.emptyEmailError();
                }
                _email = value;
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set {
                if (value.Length < 10 || value.Length > 30)
                {
                    throw UserException.lengthPasswordError();
                }   
                _password = value;
            }
        }

        public bool IsAdmin { get; set; }

        public List<Profile> ProfileList { get; set; } = new List<Profile>();
    }
}