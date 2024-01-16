using ServiceApp.Shared.Model.Services.OtherServices.SubServices;
using ServiceApp.Shared.Model.Services.PSA.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.PSA
{
    public class PSA: IPSA
    {
        private readonly ICenomar cenomar;
        private readonly IBirthCertificate birthCertificate;
        private readonly IMarriageCertificate marriageCertificate;
        private readonly IDeathCertificate deathCertificate;
        public ICenomar Cenomar => cenomar;
        public IBirthCertificate BirthCertificate => birthCertificate;
        public IMarriageCertificate MarriageCertificate => marriageCertificate;     
        public IDeathCertificate DeathCertificate => deathCertificate;
        public bool IsIncluded { get; set; }

        public PSA(ICenomar cenomar, IBirthCertificate birthCertificate, IMarriageCertificate marriageCertificate, IDeathCertificate deathCertificate)
        {
            this.cenomar = cenomar;
            this.birthCertificate = birthCertificate;
            this.marriageCertificate = marriageCertificate;
            this.deathCertificate = deathCertificate;
        }

    }
}
