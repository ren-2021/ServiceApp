using ServiceApp.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.OtherServices.SubServices
{
    internal class NBIAssistance : IOwnership, IPricing
    {
        public OwnerType OwnerType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Fee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
