using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model
{
    public class ClientInfo: IClientInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string TinNo { get; set; }
        public string ContactNo { get; set; }
        public string TelNo { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
    }
}
