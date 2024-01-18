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
        private readonly Domestic domestic;
        private readonly International international;
        public Domestic Domestic { get => domestic; set { } }
        public International International { get => international; set { } }
        public bool IsIncluded { get; set; }
        public Airline(Domestic domestic, International international)
        {
            this.domestic = domestic;
            this.international = international;
        }
    }
}
