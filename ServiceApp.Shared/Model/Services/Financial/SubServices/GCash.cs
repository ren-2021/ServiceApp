using ServiceApp.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Financial.SubServices
{
    public class GCash : IGCash
    {
        public bool IsIncluded { get; set; }
        public decimal Fee { get; set; }
    }
}
