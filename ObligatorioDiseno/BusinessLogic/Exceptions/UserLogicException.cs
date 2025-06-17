using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Exceptions
{
    public class UserLogicException : Exception
    {
        public UserLogicException(string message) : base(message)
        {
        }

        public static UserLogicException ownerExistsError()
        {
            return new UserLogicException("An Owner profile already exists.");
        }

        public static UserLogicException profileLimitError(int profilesAmountLimit)
        {
            return new UserLogicException("There cannot be more than " + profilesAmountLimit + " profiles.");
        }

        public static UserLogicException userExistsError()
        {
            return new UserLogicException("A user with the same e-mail already exists.");
        }

        public static UserLogicException incorrectPasswordError()
        {
            return new UserLogicException("The password is incorrect.");
        }

        public static UserLogicException userNotFound()
        {
            return new UserLogicException("The user was not found.");
        }

        public static UserLogicException deleteOwnerError()
        {
            return new UserLogicException("It is not possible to delete the Owner profile.");
        }
    }
}
