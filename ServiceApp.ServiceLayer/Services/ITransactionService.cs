using ServiceApp.BusinessLayer.Model;
using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceApp.ServiceLayer.Services
{
    public interface ITransactionService
    {
        bool AddTransaction(string jsonString);
        IEnumerable<TransactionInfo> GetTransactions();
    }
}
