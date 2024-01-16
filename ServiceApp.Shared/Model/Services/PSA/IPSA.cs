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
        public ICenomar Cenomar { get; }
        public IBirthCertificate BirthCertificate { get; }
        public IMarriageCertificate MarriageCertificate { get; }
        public IDeathCertificate DeathCertificate { get; }
    }
}
