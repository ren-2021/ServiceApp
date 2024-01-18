using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceApp.BusinessLayer.Model;

namespace ServiceApp.BusinessLayer.DomainServices
{
    public interface IDataAcessFactory
    {
        List<IDataAccess> DataAccess { get; set; }

        T GetDL<T>();
    }
}
