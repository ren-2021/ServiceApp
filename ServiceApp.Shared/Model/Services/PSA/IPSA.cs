using ServiceApp.Shared.Model.Services.PSA.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.PSA
{
    public interface IPSA
    {
        public Cenomar Cenomar { get; set; }
        public BirthCertificate BirthCertificate { get; set; }
        public MarriageCertificate MarriageCertificate { get; set; }
        public DeathCertificate DeathCertificate { get; set; }
        public bool IsIncluded { get; set; }
    }
}
