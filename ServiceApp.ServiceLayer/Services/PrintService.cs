using ServiceApp.BusinessLayer.DomainServices.Services;
using ServiceApp.Shared.Model;
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

        public PrintingInfo Print()
        {
            return this.printTransaction.Print();
        }
    }
}
