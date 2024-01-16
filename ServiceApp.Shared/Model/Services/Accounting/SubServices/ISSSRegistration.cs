using ServiceApp.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Accounting.SubServices
{
    public interface ISSSRegistration : IPricing, IOwnership
    {
        public bool IsIncluded { get; set; }
        public new OwnerType OwnerType { get; set; }
        public new decimal Fee { get; set; }
    }
}
