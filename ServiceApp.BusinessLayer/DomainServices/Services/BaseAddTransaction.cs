using ServiceApp.BusinessLayer.Model;
using ServiceApp.DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class BaseAddTransaction : BaseDataAccess
    {
        public IDLTransaction DLTransaction { get { return this.dlBaseService.DLTransaction; } }

        public BaseAddTransaction(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {

        }

        public BaseAddTransaction()
        {

        }
    }
}
