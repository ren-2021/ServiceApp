using ServiceApp.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.DFA.SubServices
{
    public class PassportAssistance : IPassportAssistance
    {
        public bool IsIncluded { get; set; }
        public ProcessType ProcessType { get; set; }
        public decimal Fee { get; set; }
    }
}
