using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InDB
{
    public class ViewDBRepository : IViewRepository
    {
        public View Add(View view)
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                SysContext.Views.Add(view);
                SysContext.SaveChanges();
            }
            return view;
        }

        public IList<View> GetAll()
        {
            using (SystemDbContext SysContext = new SystemDbContext())
            {
                return SysContext.Views.ToList();
            }
        }
    }
}
