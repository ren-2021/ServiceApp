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
        private readonly PassportAssistance passportAssistance;
        private readonly LossPassport lossPassport;
        public PassportAssistance PassportAssistance { get => passportAssistance; set { } }
        public LossPassport LossPassport { get => lossPassport; set { } }
        public bool IsIncluded { get; set; }
        public DFA(PassportAssistance passportAssistance, LossPassport lossPassport)
        {
            this.passportAssistance = passportAssistance;
            this.lossPassport = lossPassport;
        }
    }
}
