using ServiceApp.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class AddTransaction : BaseAddTransaction, IAddTransaction
    {
        public AddTransaction(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {

        }
        public bool Add(string sample)
        {
            this.Initialize();
            this.Validation();
            return this.DLTransaction.AddTrasaction(sample);
        }

        private void Initialize()
        {
        }


        private void Validation()
        {
        }
    }
}
