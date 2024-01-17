using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared.Model.Services.Airline;
using ServiceApp.Shared.Model.Services.ATMPortable;
using ServiceApp.Shared.Model.Services.DFA;
using ServiceApp.Shared.Model.Services.Financial;
using ServiceApp.Shared.Model.Services.LTO;
using ServiceApp.Shared.Model.Services.Notary;
using ServiceApp.Shared.Model.Services.OtherServices;
using ServiceApp.Shared.Model.Services.PSA;
using ServiceApp.Shared.Model.Services.VISAProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.ModelRequest
{
    public class MainServices
    {
        public Accounting? Accounting { get; set; }
        public Airline? Airline { get; set; }
        public ATMPortable ATMPortable { get; set; }
        public DFA DFA { get; set; }
        public Financial Financial { get; set; }
        public LTO LTO { get; set; }
        public Notary Notary { get; set; }
        public OtherServices OtherServices { get; set; }
        public PSA PSA { get; set; }
        public VISAProcessing VISAProcessing { get; set; }
    }
}
