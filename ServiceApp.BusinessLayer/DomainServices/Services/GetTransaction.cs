using ServiceApp.BusinessLayer.Model;
using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class GetTransaction : BaseAddTransaction, IGetTransaction
    {
        public GetTransaction(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {

        }
        public List<TransactionInfo> Get()
        {
            return this.DLTransaction.GetTrasactions();
        }
    }
}
