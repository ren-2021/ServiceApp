using ServiceApp.Shared.Model.Services.DFA.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.DFA
{
    public interface IDFA
    {
        public IPassportAssistance PassportAssistance { get; }
        public ILossPassport LossPassport { get; }
        public bool IsIncluded { get; set; }
    }
}
