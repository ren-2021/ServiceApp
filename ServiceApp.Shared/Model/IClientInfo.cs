using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model
{
    public interface IClientInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TinNo { get; set; }
        public string Address { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
