using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dominio
{
    public class Profile
    {
        public int Id { get; set; }

        private string _nickname;
        public string Nickname { get => _nickname; set {
                if (value.Length < 1)
                {
                    throw ProfileException.emptyNicknameError();
                }
                if (value.Length > 15)
                {
                    throw ProfileException.lengthNicknameError();
                }
                _nickname = value;
            }
        }

        private int _pin;
        public int Pin
        {
            get => _pin; set
            {
                if (this.IsChild || value.ToString().Length == 5)
                {
                    _pin = value;
                }
                else
                {
                    throw ProfileException.lengthPinError();
                }
            }
        }

        public bool IsChild { get; set; }

        public bool IsOwner { get; set; }
    }
}
