using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IViewLogic
    {
        View RegisterView(View view);
        IList<View> GetAllFromProfile(String Email, String ProfileName);
    }
}
