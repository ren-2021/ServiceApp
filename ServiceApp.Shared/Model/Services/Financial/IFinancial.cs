using ServiceApp.Shared.Model.Services.Financial.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Financial
{
    public interface IFinancial
    {
        public IGCash GCash { get; }
        public bool IsIncluded { get; set; }
    }
}
