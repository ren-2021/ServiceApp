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
        private readonly FilingOfTaxes filingOfTaxes;
        private readonly BIRRegistration birRegistration;
        private readonly ITRPreparation itrPreparation;
        private readonly DTIRegistration dtiRegistration;
        private readonly SECRegistration secRegistration;
        private readonly BusinessPermit businessPermit;
        private readonly PagIbigRegistration pagIbigRegistration;
        private readonly SSSRegistration sssRegistration;
        private readonly PhilhealthRegistration philhealthRegistration;
        private readonly Bookkeeping bookkeeping;
        public BIRRegistration BIRRegistration { get => birRegistration; set { } }
        public ITRPreparation ITRPreparation { get => itrPreparation; set { } }
        public DTIRegistration DTIRegistration { get => dtiRegistration; set { } }
        public SECRegistration SECRegistration { get => secRegistration; set { } }
        public BusinessPermit BusinessPermit { get => businessPermit; set { } }
        public PagIbigRegistration PagIbigRegistration { get => pagIbigRegistration; set { } }
        public SSSRegistration SSSRegistration { get => sssRegistration; set { } }
        public PhilhealthRegistration PhilhealthRegistration { get => philhealthRegistration; set { } }
        public Bookkeeping Bookkeeping { get => bookkeeping; set { } }
        public FilingOfTaxes FilingOfTaxes { get => filingOfTaxes; set { } }
        public bool IsIncluded { get; set; }

        public Accounting(FilingOfTaxes _filingOfTaxes, BIRRegistration _birRegistration, ITRPreparation _itrPreparation, DTIRegistration _dtiRegistration, SECRegistration _secRegistration, BusinessPermit _businessPermit, PagIbigRegistration _pagIbigRegistration, SSSRegistration _sssRegistration, PhilhealthRegistration _philhealthRegistration, Bookkeeping _bookkeeping)
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
