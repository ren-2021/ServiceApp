using ServiceApp.Shared.Model.Services.Airline.SubServices;
using ServiceApp.Shared.Model.Services.ATMPortable.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.ATMPortable
{
    public class ATMPortable : IATMPortable
    {
        private readonly BankBalanceInquiry bankBalanceInquiry;
        private readonly Withdrawal withdrawal;
        public BankBalanceInquiry BankBalanceInquiry { get => bankBalanceInquiry; set { } }
        public Withdrawal Withdrawal { get => withdrawal; set { } }
        public bool IsIncluded { get; set; }
        public ATMPortable(BankBalanceInquiry bankBalanceInquiry, Withdrawal withdrawal)
        {
            this.bankBalanceInquiry = bankBalanceInquiry;
            this.withdrawal = withdrawal;
        }
    }
}
