using ServiceApp.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceApp.ServiceLayer.Services
{
    public interface ITransactionService
    {
        bool AddTransaction(string sample);
    }
}
