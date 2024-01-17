using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using ServiceApp.Shared.Model.Services.Airline.SubServices;
using ServiceApp.Shared.Model.Services.LTO.SubService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Airline
{
    public class Airline : IAirline
    {
        private readonly IDomestic domestic;
        private readonly IInternational international;
        public IDomestic Domestic { get => domestic; set { } }
        public IInternational International { get => international; set { } }
        public bool IsIncluded { get; set; }
        public Airline(IDomestic domestic, IInternational international)
        {
            this.domestic = domestic;
            this.international = international;
        }
    }
}
