using ServiceApp.BusinessLayer.Model;
using ServiceApp.DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class BaseGetPercentage: BaseDataAccess
    {
        public IDLDashboard DLDashboard { get { return this.dlBaseService.DLDashboard; } }

        public BaseGetPercentage(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {
            
        }
    }
}
