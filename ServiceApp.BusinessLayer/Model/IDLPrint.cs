using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.Model
{
    public interface IDLPrint
    {
        public TransactionInfo GetTransactionInfo();
        public IEnumerable<PrintModel> GetTransactionServicesInfo(int _transactionID);
    }
}
