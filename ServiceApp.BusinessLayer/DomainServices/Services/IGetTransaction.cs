using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public interface IGetTransaction
    {
        List<TransactionInfo> Get();
        List<TransactionInfo> GetTransactionDate(DateOnly Start, DateOnly End);
    }
}
