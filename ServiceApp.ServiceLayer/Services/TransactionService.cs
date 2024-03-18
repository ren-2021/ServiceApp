using ServiceApp.BusinessLayer.DomainServices.Services;
using ServiceApp.ServiceLayer;
using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceApp.ServiceLayer.Services
{
    public class TransactionService : BaseDataAccessFactory, ITransactionService
    {
        private IAddTransaction addTransaction;
        private IGetTransaction getTransaction;
        public TransactionService()
        {
            this.addTransaction = new AddTransaction(this.dataAcesses);
            this.getTransaction = new GetTransaction(this.dataAcesses);
        }

        public bool AddTransaction(string jsonString)
        {
            return this.addTransaction.Add(jsonString);
        }

        public IEnumerable<TransactionInfo> GetTransactions()
        {
            return this.getTransaction.Get();
        }

        public IEnumerable<TransactionInfo> GetTransactionDate(DateOnly start, DateOnly end)
        {
            return this.getTransaction.GetTransactionDate(start, end);
        }
    }
}
