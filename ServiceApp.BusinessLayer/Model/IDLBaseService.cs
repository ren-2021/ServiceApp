
using ServiceApp.BusinessLayer.Model;
using ServiceApp.DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.DataAccessLayer
{
    public interface IDLBaseService
    {
        IDLTransaction DLTransaction { get; }
        IDLPrint DLPrint { get; }
        IDLDashboard DLDashboard { get; }
    }
}
