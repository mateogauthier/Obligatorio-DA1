using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class ViewLogic : IViewLogic
    {
        private IViewRepository _viewRepository;

        public ViewLogic(IViewRepository viewRepository)
        {
            _viewRepository = viewRepository;
        }

        public IList<View> GetAllFromProfile(string Email, string ProfileName)
        {
            IList<View> viewsFromAll = _viewRepository.GetAll();
            IList<View> viewsFromProfile = new List<View>();
            for (int i = 0; i < viewsFromAll.Count; i++)
            {
                if (viewsFromAll[i].UserEmail==Email && viewsFromAll[i].ProfileName==ProfileName) viewsFromProfile.Add(viewsFromAll[i]);
            }
            return viewsFromProfile;
        }

        public View RegisterView(View view)
        {
            IList<View> views = GetAllFromProfile(view.UserEmail, view.ProfileName);
            for (int i = 0; i < views.Count; i++)
            {
                if (view.MovieName == views[i].MovieName) throw ViewLogicException.movieSeenError();
            }
            return _viewRepository.Add(view);
        }
    }
}
