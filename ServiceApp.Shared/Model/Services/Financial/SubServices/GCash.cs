using ServiceApp.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Financial.SubServices
{
    public class GCash : IPricing
    {
        public decimal Fee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TransactType TrasactType { get; set; }
    }
}
