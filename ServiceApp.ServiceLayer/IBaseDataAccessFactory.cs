﻿using ServiceApp.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceLayer
{
    public interface IBaseDataAccessFactory
    {
        List<IDataAccess> dataAcesses { get; }
    }
}
