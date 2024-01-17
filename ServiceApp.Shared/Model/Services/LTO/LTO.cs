using ServiceApp.Shared.Model.Services.Financial.SubServices;
using ServiceApp.Shared.Model.Services.LTO.SubService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.LTO
{
    public class LTO : ILTO
    {
        private readonly IRegistration registration;
        public bool IsIncluded { get; set; }
        IRegistration ILTO.Registration { get => registration; set { } }

        public LTO(IRegistration registration)
        {
            this.registration = registration;
        }
    }
}
