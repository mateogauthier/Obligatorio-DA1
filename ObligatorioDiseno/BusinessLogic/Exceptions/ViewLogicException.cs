using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Exceptions
{
    public class ViewLogicException : Exception
    {
        public ViewLogicException(string message) : base(message)
        {
        }

        public static ViewLogicException movieSeenError()
        {
            return new ViewLogicException("Movie was already marked as seen.");
        }
    }
}
