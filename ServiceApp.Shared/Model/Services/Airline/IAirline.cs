using ServiceApp.Shared.Model.Services.Airline.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Airline
{
    public interface IAirline
    {
        public Domestic Domestic { get; set; }
        public International International { get; set; }
        public bool IsIncluded { get; set; }
    }
}
