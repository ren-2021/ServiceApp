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
        public IFilingOfTaxes FilingOfTaxes { get;}
        public IBIRRegistration BIRRegistration { get; }
        public IITRPreparation ITRPreparation { get; }
        public IDTIRegistration DTIRegistration { get; }
        public ISECRegistration SECRegistration { get; }
        public IBusinessPermit BusinessPermit { get; }
        public IPagIbigRegistration PagIbigRegistration { get; }
        public ISSSRegistration SSSRegistration { get; }
        public IPhilhealthRegistration PhilhealthRegistration { get; }
        public IBookkeeping Bookkeeping { get; }
        public bool IsIncluded { get; set; }
    }
}
