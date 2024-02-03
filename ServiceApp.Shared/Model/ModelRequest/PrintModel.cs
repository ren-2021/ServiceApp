using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.ModelRequest
{
    public class PrintModel
    {
        public string ServiceType { get; set; }
        public string Description { get; set; }
        public decimal Fee { get; set; }
        public int OwnershipType { get; set; }
    }
}
