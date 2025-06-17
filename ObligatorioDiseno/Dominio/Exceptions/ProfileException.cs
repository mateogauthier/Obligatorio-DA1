using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dominio.Exceptions
{
    public class ProfileException : Exception
    {
        private ProfileException(string message) : base(message)
        {
        }

        public static ProfileException emptyNicknameError()
        {
            return new ProfileException("The profile nickname cannot be empty.");
        }

        public static ProfileException lengthNicknameError()
        {
            return new ProfileException("The profile nickname cannot be longer than 15 characters.");
        }

        public static ProfileException lengthPinError()
        {
            return new ProfileException("The profile pin must be of 5 digits.");
        }
    }
}
