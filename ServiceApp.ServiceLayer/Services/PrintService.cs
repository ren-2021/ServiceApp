using ServiceApp.BusinessLayer.DomainServices.Services;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceLayer.Services
{
    public class PrintService : BaseDataAccessFactory, IPrintService
    {
        private IPrintTransaction printTransaction;
        public PrintService()
        {
            this.printTransaction = new PrintTransaction(this.dataAcesses);
        }

        public PrintingInfo Print(int _transactionID)
        {
            return this.printTransaction.Print(_transactionID);
        }

        public IEnumerable<PrintModel> GetServicesInfo(int _transactionID)
        {
            return this.printTransaction.GetServicesInfo(_transactionID);
        }
    }
}
