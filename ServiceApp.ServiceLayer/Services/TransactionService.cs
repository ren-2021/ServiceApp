using ServiceApp.BusinessLayer.DomainServices.Services;
using ServiceApp.ServiceLayer;
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
        public TransactionService()
        {
            this.addTransaction = new AddTransaction(this.dataAcesses);
        }

        public bool AddTransaction(string sample)
        {
            return this.addTransaction.Add(sample);
        }
    }
}
