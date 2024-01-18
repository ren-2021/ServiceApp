using Microsoft.Data.SqlClient;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.DataAccessLayer.Services
{
    public class DLPrint : DLBaseDataAccess, IDLPrint
    {
        public TransactionInfo GetTransactionInfo()
        {
            return new TransactionInfo();
        }
    }
}
