using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceLayer.Services
{
    public interface IPrintService
    {
        PrintingInfo Print();
    }
}
