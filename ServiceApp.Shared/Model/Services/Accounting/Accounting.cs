using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Accounting
{
    public class Accounting : IAccounting
    {
        private readonly IFilingOfTaxes filingOfTaxes;
        private readonly IBIRRegistration birRegistration;
        private readonly IITRPreparation itrPreparation;
        private readonly IDTIRegistration dtiRegistration;
        private readonly ISECRegistration secRegistration;
        private readonly IBusinessPermit businessPermit;
        private readonly IPagIbigRegistration pagIbigRegistration;
        private readonly ISSSRegistration sssRegistration;
        private readonly IPhilhealthRegistration philhealthRegistration;
        private readonly IBookkeeping bookkeeping;
        public IBIRRegistration BIRRegistration { get => birRegistration; set { } }
        public IITRPreparation ITRPreparation { get => itrPreparation; set { } }
        public IDTIRegistration DTIRegistration { get => dtiRegistration; set { } }
        public ISECRegistration SECRegistration { get => secRegistration; set { } }
        public IBusinessPermit BusinessPermit { get => businessPermit; set { } }
        public IPagIbigRegistration PagIbigRegistration { get => pagIbigRegistration; set { } }
        public ISSSRegistration SSSRegistration { get => sssRegistration; set { } }
        public IPhilhealthRegistration PhilhealthRegistration { get => philhealthRegistration; set { } }
        public IBookkeeping Bookkeeping { get => bookkeeping; set { } }
        public IFilingOfTaxes FilingOfTaxes { get => filingOfTaxes; set { } }
        public bool IsIncluded { get; set; }

        public Accounting(IFilingOfTaxes _filingOfTaxes, IBIRRegistration _birRegistration, IITRPreparation _itrPreparation, IDTIRegistration _dtiRegistration, ISECRegistration _secRegistration, IBusinessPermit _businessPermit, IPagIbigRegistration _pagIbigRegistration, ISSSRegistration _sssRegistration, IPhilhealthRegistration _philhealthRegistration, IBookkeeping _bookkeeping)
        {
            filingOfTaxes = _filingOfTaxes;
            birRegistration = _birRegistration;
            itrPreparation = _itrPreparation;
            dtiRegistration = _dtiRegistration;
            secRegistration = _secRegistration;
            businessPermit = _businessPermit;
            pagIbigRegistration = _pagIbigRegistration;
            sssRegistration = _sssRegistration;
            philhealthRegistration = _philhealthRegistration;
            bookkeeping = _bookkeeping;
    }
    }
}
