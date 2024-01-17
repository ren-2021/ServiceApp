﻿using ServiceApp.Shared.Model.Services.ATMPortable.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.ATMPortable
{
    public interface IATMPortable
    {
        public IBankBalanceInquiry BankBalanceInquiry { get; set; }
        public IWithdrawal Withdrawal { get; set; }
        public bool IsIncluded { get; set; }
    }
}