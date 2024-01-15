using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Accounting
{
    public class Accounting
    {
        public FilingOfTaxes? FilingOfTaxes { get; set; }
        public BIRRegistration? BIRRegistration { get; set; }
        public ITRPreparation? ITRPreparation { get; set; }
        public DTIRegistration? DTIRegistration { get; set; }
        public SECRegistration? SECRegistration { get; set; }
        public BusinessPermit? BusinessPermit { get; set; }
        public PagIbigRegistration? PagIbigRegistration { get; set; }
        public SSSRegistration? SSSRegistration { get; set; }
        public PhilhealthRegistration? PhilhealthRegistration { get; set; }
        public Bookkeeping? Bookkeeping { get; set; }
    }
}
