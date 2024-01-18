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
        private GCash gcash;
        public GCash GCash { get => gcash; set { } }
        public bool IsIncluded { get; set; }
        public Financial(GCash gcash)
        {
            this.gcash = gcash;
        }
    }
}
