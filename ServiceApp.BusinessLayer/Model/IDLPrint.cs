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
        public TransactionInfo GetTransactionInfoByID(int _transactionID);
        public IEnumerable<PrintModel> GetTransactionServicesInfo(int _transactionID);

        public void SavePrintingInfo(int _transactionID, string _fileName, string _fullPath);
    }
}
