using ServiceApp.BusinessLayer.Model;
using ServiceApp.DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.DataAccessLayer
{
    public class DLBaseService : IDataAccess, IDLBaseService
    {
        private IDLTransaction dlTransaction = new DLTransaction();
        private IDLPrint dlPrint = new DLPrint();
        private IDLDashboard dLDashboard = new DLDashboard();
        public IDLTransaction DLTransaction { get { return dlTransaction; } }
        public IDLPrint DLPrint { get { return dlPrint; } }
        public IDLDashboard DLDashboard { get {  return dLDashboard; } }
    }
}
