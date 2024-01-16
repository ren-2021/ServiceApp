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
        private readonly IBankBalanceInquiry bankBalanceInquiry;
        private readonly IWithdrawal withdrawal;
        public IBankBalanceInquiry BankBalanceInquiry => bankBalanceInquiry;
        public IWithdrawal Withdrawal => withdrawal;
        public bool IsIncluded { get; set; }
        public ATMPortable(IBankBalanceInquiry bankBalanceInquiry, IWithdrawal withdrawal)
        {
            this.bankBalanceInquiry = bankBalanceInquiry;
            this.withdrawal = withdrawal;
        }
    }
}
