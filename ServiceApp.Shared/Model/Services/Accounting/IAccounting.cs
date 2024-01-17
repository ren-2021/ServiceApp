using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Accounting
{
    public interface IAccounting
    {
        public IFilingOfTaxes FilingOfTaxes { get; set; }
        public IBIRRegistration BIRRegistration { get; set; }
        public IITRPreparation ITRPreparation { get; set; }
        public IDTIRegistration DTIRegistration { get; set; }
        public ISECRegistration SECRegistration { get; set; }
        public IBusinessPermit BusinessPermit { get; set; }
        public IPagIbigRegistration PagIbigRegistration { get; set; }
        public ISSSRegistration SSSRegistration { get; set; }
        public IPhilhealthRegistration PhilhealthRegistration { get; set; }
        public IBookkeeping Bookkeeping { get; set; }
        public bool IsIncluded { get; set;}
    }
}
