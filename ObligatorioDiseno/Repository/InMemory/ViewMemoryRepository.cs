using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InMemory
{
    public class ViewMemoryRepository : IViewRepository
    {
        private IList<View> _views;
        public ViewMemoryRepository()
        {
            _views = new List<View>();
        }

        public View Add(View view)
        {
            _views.Add(view);
            return view;
        }

        public IList<View> GetAll()
        {
            return _views;
        }
    }
}
