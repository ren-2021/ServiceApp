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
        public PassportAssistance PassportAssistance { get;  set; }
        public LossPassport LossPassport { get;  set; }
        public bool IsIncluded { get; set; }
    }
}
