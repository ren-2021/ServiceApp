using ServiceApp.Shared.Model.Services.ATMPortable.SubServices;
using ServiceApp.Shared.Model.Services.DFA.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.DFA
{
    public class DFA : IDFA
    {
        private readonly IPassportAssistance passportAssistance;
        private readonly ILossPassport lossPassport;
        public IPassportAssistance PassportAssistance { get => passportAssistance; set { } }
        public ILossPassport LossPassport { get => lossPassport; set { } }
        public bool IsIncluded { get; set; }
        public DFA(IPassportAssistance passportAssistance, ILossPassport lossPassport)
        {
            this.passportAssistance = passportAssistance;
            this.lossPassport = lossPassport;
        }
    }
}
