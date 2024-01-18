using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.DataAccessLayer;

namespace ServiceApp.BusinessLayer.DomainServices
{
    public abstract class BaseDataAccess
    {
        public bool isValid;
        public List<IDataAccess> dataAccess { get; set; }
        public IDataAcessFactory dataFactory { get; set; }

        public IDLBaseService dlBaseService;

        public BaseDataAccess(List<IDataAccess> pDataAccess)
        {
            dataAccess = pDataAccess;
            dataFactory = new DataAccessFactory(dataAccess);
            dlBaseService = dataFactory.GetDL<IDLBaseService>();
        }

        public BaseDataAccess(IDataAcessFactory pDataFactory)
        {
            dataFactory = pDataFactory;
            dataAccess = dataFactory.DataAccess;
            dlBaseService = dataFactory.GetDL<IDLBaseService>();
        }

        public BaseDataAccess()
        {
        }

    }
}
