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
        public ICenomar Cenomar { get => cenomar; set { } }
        public IBirthCertificate BirthCertificate { get => birthCertificate; set { } }
        public IMarriageCertificate MarriageCertificate { get => marriageCertificate; set { } }
        public IDeathCertificate DeathCertificate { get => deathCertificate; set { } }
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
