using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceLayer.Services
{
    public interface IPrintService
    {
        byte[] Print(int _transactionID);

        IEnumerable<PrintModel> GetServicesInfo(int _transactionID);
    }
}
