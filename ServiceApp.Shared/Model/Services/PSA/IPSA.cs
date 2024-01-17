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
        public ICenomar Cenomar { get; set; }
        public IBirthCertificate BirthCertificate { get; set; }
        public IMarriageCertificate MarriageCertificate { get; set; }
        public IDeathCertificate DeathCertificate { get; set; }
        public bool IsIncluded { get; set; }
    }
}
