using ServiceApp.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.OtherServices.SubServices
{
    public class PCABAssistance : IPCABAssistance
    {
        public bool IsIncluded { get; set; }
        public OwnerType OwnerType { get; set; }
        public decimal Fee { get; set; }
    }
}
