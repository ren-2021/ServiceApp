using ServiceApp.Shared.Model;
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
    }
}
