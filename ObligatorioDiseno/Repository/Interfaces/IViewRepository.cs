﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IViewRepository
    {
        View Add(View view);
        IList<View> GetAll();
    }
}
