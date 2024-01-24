using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model
{
    public class TransactionInfo
    {
        public int TransactionID { get; set; }
        public string FirstName { get; set; }
	    public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string TinNo { get; set; }
        public string Address { get; set; }
        public decimal TotalFee { get; set; }
        public DateTime TransactionDate { get; set; }
}
}
