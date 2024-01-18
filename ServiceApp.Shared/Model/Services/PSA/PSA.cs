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
        private readonly Cenomar cenomar;
        private readonly BirthCertificate birthCertificate;
        private readonly MarriageCertificate marriageCertificate;
        private readonly DeathCertificate deathCertificate;
        public Cenomar Cenomar { get => cenomar; set { } }
        public BirthCertificate BirthCertificate { get => birthCertificate; set { } }
        public MarriageCertificate MarriageCertificate { get => marriageCertificate; set { } }
        public DeathCertificate DeathCertificate { get => deathCertificate; set { } }
        public bool IsIncluded { get; set; }

        public PSA(Cenomar cenomar, BirthCertificate birthCertificate, MarriageCertificate marriageCertificate, DeathCertificate deathCertificate)
        {
            this.cenomar = cenomar;
            this.birthCertificate = birthCertificate;
            this.marriageCertificate = marriageCertificate;
            this.deathCertificate = deathCertificate;
        }

    }
}
