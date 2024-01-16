
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Airline.SubServices
{
    public interface IDomestic
    {
        public bool IsIncluded { get; set; }
        public decimal Fee {  get; set; }
    }
}
