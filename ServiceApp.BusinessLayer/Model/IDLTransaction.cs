using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.DataAccessLayer.Services
{
    public interface IDLTransaction
    {
        bool AddTrasaction(string jsonString);

        List<TransactionInfo> GetTrasactions();
        List<TransactionInfo> GetTransactionDate(DateOnly start, DateOnly end);
    }
}
