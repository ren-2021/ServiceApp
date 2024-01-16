using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Airline.SubServices
{
    public class Domestic : IDomestic
    {
        public decimal Fee { get; set; }
        public bool IsIncluded { get; set; }
    }
}
