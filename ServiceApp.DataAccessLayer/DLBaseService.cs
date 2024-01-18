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
        public IDLTransaction DLTransaction { get { return dlTransaction; } }
    }
}
