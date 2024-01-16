using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.ATMPortable.SubServices
{
    public class BankBalanceInquiry : IBankBalanceInquiry
    {
        public bool IsIncluded { get; set; }
        public decimal Fee { get; set; }
    }
}
