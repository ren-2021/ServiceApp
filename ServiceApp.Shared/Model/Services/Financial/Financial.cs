using ServiceApp.Shared.Model.Services.DFA.SubServices;
using ServiceApp.Shared.Model.Services.Financial.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Financial
{
    public class Financial : IFinancial
    {
        private IGCash gcash;
        public IGCash GCash { get => gcash; set { } }
        public bool IsIncluded { get; set; }
        public Financial(IGCash gcash)
        {
            this.gcash = gcash;
        }
    }
}
